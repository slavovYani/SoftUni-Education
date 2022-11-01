using System;
using System.Linq;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            var result = new StringBuilder();
            string gender = string.Empty;

            while (type != "Beast!")
            {

                try
                {
                    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    if (input.Length > 2)
                    {
                        gender = input[2];
                    }

                    //if (int.Parse(input[1]) <= 0 || string.IsNullOrEmpty(input[2]))
                    //{
                    //    throw new ArgumentException("Invalid input!");
                    //    //Console.WriteLine("Invalid input!");
                    //    //continue;
                    //}

                    switch (type)
                    {
                        case "Cat":
                            var cat = new Cat(input[0], int.Parse(input[1]), gender);
                            result.AppendLine(cat.ToString());
                            break;

                        case "Dog":
                            var dog = new Dog(input[0], int.Parse(input[1]), gender);
                            result.AppendLine(dog.ToString());

                            break;

                        case "Frog":
                            var frog = new Frog(input[0], int.Parse(input[1]), gender);
                            result.AppendLine(frog.ToString());

                            break;

                        case "Kitten":

                            var kitten = new Kitten(input[0], int.Parse(input[1]));
                            result.AppendLine(kitten.ToString());

                            break;

                        case "Tomcat":
                            var tomcat = new Tomcat(input[0], int.Parse(input[1]));
                            result.AppendLine(tomcat.ToString());

                            break;

                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }



                type = Console.ReadLine();

            }

            Console.WriteLine(result.ToString());



        }
    }
}