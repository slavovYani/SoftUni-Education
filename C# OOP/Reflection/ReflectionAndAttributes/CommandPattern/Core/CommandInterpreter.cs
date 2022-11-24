
namespace CommandPattern.Core
{
    using Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] commArgs = args.Split(' ');
            string command = commArgs[0];
            string[] arguments = commArgs.Skip(1).ToArray();

            Assembly assembly = Assembly.GetEntryAssembly();

            Type comdType = assembly.GetTypes().FirstOrDefault(t => t.Name == $"{command}Command");
            
            MethodInfo method = comdType.GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(m => m.Name == "Execute");

            if (method == null)
            {
                throw new InvalidOperationException("Method is not implemented");
            }

            object typeInstance = Activator.CreateInstance(comdType);

            string result = (string)method.Invoke(typeInstance, new object[] { arguments });

            return result;
        }
    }
}
