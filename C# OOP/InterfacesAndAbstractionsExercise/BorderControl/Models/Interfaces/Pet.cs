
namespace BorderControl.Models.Interfaces
{
    public class Pet : IBirthDay
    {
        public Pet(string name, string birthDay)
        {
            Name = name;
            BirthDay = birthDay;
        }

        public string Name { get; set; }
        public string BirthDay { get; set; }
    }
}
