using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
		public Tires(int age,float pressure)
		{
			this.age = age;
			this.pressure = pressure;

			//Tires[] tires = new Tires[4];	
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private float pressure;

		public float Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}


	}
}
