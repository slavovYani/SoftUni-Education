
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string nameOfClass, params string[] nameOfFields)
        {
            Type classType = Type.GetType(nameOfClass);
            

            FieldInfo[] fields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[]{ });

            sb.AppendLine($"Class under investigation: {nameOfClass}");

            foreach (var field in fields.Where(f=>nameOfFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            MethodInfo[] methodsPublic = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] methodsNonPublic = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in methodsNonPublic.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            foreach (MethodInfo method in methodsPublic.Where(m=>m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");

            }

            return sb.ToString().Trim();

        }

        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            StringBuilder sb = new StringBuilder();

            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            sb.AppendLine($"All Private Methods of Class: {classType.FullName}");

            var baseClass = classType.BaseType.Name;

            sb.AppendLine($"Base Class: {baseClass}");

            foreach (MethodInfo method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] methods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            foreach (MethodInfo method in methods.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in methods.Where(m=>m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}
