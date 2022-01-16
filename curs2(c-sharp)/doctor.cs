using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs2_c_sharp_
{
    class Doctor:Person
    {

		private string speciality;
		public Doctor() { /*person();*/ }
		Doctor(string name1, string surname1, string otch1,string speciality):base(name1,surname1,otch1)
		{
			//person(name, surname, otch);
			Speciality = speciality;
		}
		
		public string Speciality {
			set { speciality = value; }
			get { return speciality; }
		}

	}
}
