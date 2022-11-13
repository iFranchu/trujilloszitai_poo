using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
	class GeneradorNombres
	{
		public GeneradorNombres() { }

		public string GenerarNombre()
		{
			string result;
			result = _firstName[rFirstName.Next(_firstName.Length)];
			return result;
		}
		static Random rFirstName = new Random();

		string[] _firstName = new string[] { "Adam", "Alex", "Aaron", "Ben", "Carl", "Dan", "David", "Edward", "Fred", "Frank", "George", "Hal", "Hank", "Ike", "John", "Jack", "Joe", "Larry", "Monte", "Matthew", "Mark", "Nathan", "Otto", "Paul", "Peter", "Roger", "Roger", "Steve", "Thomas", "Tim", "Ty", "Victor", "Walter" };
	}
}
