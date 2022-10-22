using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();

        }
        public List<CPU> Multiprocessor { get; set; }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Count => Multiprocessor.Count;



        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count + 1 <= Capacity)   // check here without equal??
            {

                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            var currentCpu = Multiprocessor.Find(n => n.Brand == brand);
            if (currentCpu != null)                           // not sure here
            {
                Multiprocessor.Remove(currentCpu);
                return true;
            }
            return false;

        }

        public CPU MostPowerful()
        {
            var mostCapacityCPU = Multiprocessor.First();

            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Frequency > mostCapacityCPU.Frequency)
                {
                    mostCapacityCPU = Multiprocessor[i];
                }

            }

            return mostCapacityCPU;





        }

        public CPU GetCPU(string brand)
        {
            return Multiprocessor.FirstOrDefault(x => x.Brand == brand);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {this.Model}:");

            foreach (var item in Multiprocessor)
            {
                sb.AppendLine(item.ToString());     //check for trimEnd here?
            }
            return sb.ToString().TrimEnd();   

        }



    }
}
