﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
		public Engine(int speed,int power)
		{
			this.Speed = speed;
			this.Power = power;
		}
		private int speed;

		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}
		private int power;

		public int Power
		{
			get { return power; }
			set { power = value; }
		}


	}
}
