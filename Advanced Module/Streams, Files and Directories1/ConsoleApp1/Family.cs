using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
		private List<Person> members;

		public List<Person> Members
		{
			get { return members; }
			set { members = value; }
		}

		public Family()
		{
			Members = new List<Person>();
		}


		public void AddMember(Person member)
		{
			this.members.Add(member);
		}
		public List<Person> GetPersonsAbove30() 
		{
			return members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
			
		}


	}
}
