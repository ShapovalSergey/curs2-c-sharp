using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs2_c_sharp_
{
    class Person
    {

		private string name;
		private string surname;
		private string otch;
		public Person() { }
		public Person(string name, string surname, string otch) 
		{
			Name = name;
			Surname = surname;
			Otch = otch;
		}
		public string Name {
			set { name = value; }
			get { return name; }
		}
		public string Surname {
			set { surname = value; }
			get { return surname; }
		}
		public string Otch {
			set { otch = value; }
			get { return otch; }
		}

	}
}
