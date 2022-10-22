using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {

        public CPU(string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;
        }


        private string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		private int cores;

		public int Cores
		{
			get { return cores; }
			set { cores = value; }
		}

		private double frequency;

		public double Frequency
		{
			get { return  frequency; }
			set {  frequency = value; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			// check here with properties, not fields.

			sb.AppendLine($"{this.brand} CPU:");
			sb.AppendLine($"Cores: {this.cores}");
			sb.AppendLine($"Frequency: {this.frequency:f1} GHz");

			return sb.ToString().TrimEnd();

		}


	}
}
