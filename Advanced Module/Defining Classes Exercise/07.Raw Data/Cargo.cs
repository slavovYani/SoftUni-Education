using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
		public Cargo(string type,int weight)
		{
			this.Type = type;
			this.Weight = weight;
		}
		private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		private int weight;

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

	}
}
