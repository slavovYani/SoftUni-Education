using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
           
           
        }
        private string name;
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private double rate;

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        private int days;

        public int Days
        {
            get { return days; }
            set { days = value; }
        }

        public bool Hired { get; set; } = false;
    


        public override string ToString()
        {
             var sb = new StringBuilder();
            sb.AppendLine($"-Renovator: {this.Name}");
            sb.AppendLine($"--Specialty: {this.Type}");
            sb.AppendLine($"--Rate per day: {this.Rate} BGN");
            return sb.ToString().TrimEnd();

        }

    }
}
