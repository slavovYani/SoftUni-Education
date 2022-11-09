
namespace BorderControl.Models
{
    using Models.Interfaces;
    public class Citizen : ICitizen, IIdentity, IBirthDay,IBuyer
    {
        private int food;
        public Citizen(string name,int age,string id, string birthDay)
        {
            this.Name = name;
            this.Age= age;
            this.ID = id;
            this.BirthDay = birthDay;
        }
        public string Name { get;  set; }    

        public int Age { get;  set; }

        public string ID { get;  set; }

        public string BirthDay { get; set; }

        public int Food { get { return food; } private set { } }

        public int BuyFood() => food += 10;   // increment directly
    }
}
