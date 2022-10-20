using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        public Catalog(string name, int neededRenovators, string project)
        {
            
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;

            this.renovators = new List<Renovator>();
            
        }

        public IReadOnlyCollection<Renovator> Renovators => this.renovators;

        public string Name { get; private set; }
        public int NeededRenovators { get; private set; }
        public string Project { get; private set; }

       
        public int Count
        {
            get { return renovators.Count; }
            
        }


        public string AddRenovator(Renovator renovator)
        {

            if (String.IsNullOrEmpty(renovator.Name) || String.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if (Renovators.Count >= this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            
            
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            

        }
        public bool RemoveRenovator(string name)
        {
            var renovator = renovators.FirstOrDefault(n => n.Name == name);
            if(renovator == null)
            {
                return false;
            }
            renovators.Remove(renovator);
            return true;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            //int counter = renovators.Where(n => n.Type==type).Count(); 
            return renovators.RemoveAll(n => n.Type==type);
           
        }
        public Renovator HireRenovator(string name)
        {
            var targetRenovator = this.renovators.FirstOrDefault(x => x.Name == name);
            if (targetRenovator == null)
            {
                return null;
            }
            this.renovators.FirstOrDefault(x => x.Name == name).Hired = true;
            return targetRenovator;
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovators = new List<Renovator>();

           return renovators = Renovators.Where(r => r.Days >= days).ToList();
            
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine($"Renovators available for Project {this.Project}:");

            foreach (var renovator in Renovators)
            {
                if (renovator.Hired==false)
                {
                    sb.AppendLine(renovator.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }

    }
}
