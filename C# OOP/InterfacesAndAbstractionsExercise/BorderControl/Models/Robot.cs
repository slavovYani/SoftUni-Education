
namespace BorderControl.Models
{
    using Interfaces;
    public class Robot : IRobot
    {
        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }

        public string Model { get;  set; }
        public string ID { get;  set; }
    }
}
