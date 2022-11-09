

namespace BorderControl.Models
{
    using Interfaces;
    
    public class Buyer : ICitizen, IIdentity, IBirthDay
    {
        

        private Buyer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Buyer(string name, int age,string id,string birthDay) : this(name,age)
        {
            
            this.ID= id;    
            this.BirthDay=birthDay;
            this.Citizen = new Citizen(name,age,id,birthDay);
        }
        public Buyer(string name, int age, string group ) : this(name,age)
        {
            this.Group = group;
            this.Rebel = new Rebel(name, age, group);

        }
        private Rebel Rebel { get; set; }
        private Citizen Citizen { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public string BirthDay { get; set; }
        public string Group { get; set;}

        
    }
}
