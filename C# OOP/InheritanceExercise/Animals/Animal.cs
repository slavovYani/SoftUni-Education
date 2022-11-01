
using System;
using System.Text;

namespace Animals
{
    public class Animal
    {

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            private set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {

                    //Console.WriteLine("Invalid input!");
                    throw new ArgumentException("Invalid input!");
                }

            }    // here also for checking
        }


        private string gender;

        public string Gender
        {
            get { return gender; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid input!");

                gender = value;


                // here again for check!
            }
        }



        public virtual string ProduceSound()
        {
            return null;    // here not sure for Animal
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(GetType().Name);
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine(ProduceSound());

            return sb.ToString().TrimEnd();
        }

    }

}
