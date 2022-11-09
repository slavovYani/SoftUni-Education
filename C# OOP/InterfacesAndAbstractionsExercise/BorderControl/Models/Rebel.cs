

namespace BorderControl.Models
{
    using Interfaces;
    public class Rebel : ICitizen, IBuyer
    {
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public int Food { get => food; private set { } }
        public int BuyFood() => food += 5;   // increment direct
        
    }
}
