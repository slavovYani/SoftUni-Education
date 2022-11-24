using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType = Type.GetType("Demo.MyDemoClass");

            Type baseType = typeof(MyDemoClass).BaseType;

            Type[] interfaces =typeof(MyDemoClass).GetInterfaces();

            //Console.WriteLine(baseType.Name);

            //foreach (var inter in interfaces)
            //{
            //    Console.WriteLine(inter.FullName);
            //}
            

            //make instance with Activator

            Type sbType = Type.GetType("System.Text.StringBuilder");
            StringBuilder sbInstance = (StringBuilder)Activator.CreateInstance(sbType);

            StringBuilder sbInstanceCapacity = (StringBuilder)Activator.CreateInstance(sbType, new object[]{10});
            Console.WriteLine(sbInstanceCapacity.Capacity);

            // get fields

            Type type = typeof(MyDemoClass);

            FieldInfo field = typeof(MyDemoClass).GetField("name");

            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);


            Console.WriteLine(fields.Length);

            Type demoType = typeof(MyDemoClass);

            // create instance with value through constructor

            MyDemoClass demoInstance = (MyDemoClass)Activator.CreateInstance(demoType, new object[] {"Mitko", 10});

            // set value fields


            FieldInfo fieldDemo = demoType.GetField("name");

            fieldDemo.SetValue(demoInstance, "Gosho");

           string name = (string)fieldDemo.GetValue(demoInstance);

            Console.WriteLine(name);

            Console.WriteLine(fieldDemo.IsPublic);

            //constructors

            ConstructorInfo[] constructorInfos = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(constructorInfos.Length);

            //foreach (var constructor in constructorInfos)
            //{
                 
            //    ParameterInfo[] parameters = constructor.GetParameters();
            //    Console.WriteLine(parameters.Length);

            //    foreach (var parameter in parameters)
            //    {
            //        Console.WriteLine(parameter.Name);
            //    }
            //}

            // methods 
            MethodInfo method = demoType.GetMethod("Hello");

            method.Invoke(demoInstance, new object[] { "Mitaka" });

            MethodInfo[] methods = demoType.GetMethods();



        }
    }
    
    public class MyDemoClass : IEnumerable
    {
       
        public string name;
        public int age;
        private int id;
        internal double score;
        protected string friend;

        public MyDemoClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }
        protected string Friend { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Hello(string name)
        {
            Console.WriteLine($"Hello my name is {name}, and my previous name was {this.Name}!");
        }
    }
}
