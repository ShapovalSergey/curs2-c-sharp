using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs2_c_sharp_
{
    class Patient:Person
    {
		private int age;
		//private bool sex;
		private int height;
		private int weight;
		private int day_of_birth;
		private int month_of_birth;
		private int year_of_birth;
		public Patient() { }
		public Patient(string name, string surname, string otch, int age, int height, int weight, int day_of_birth, int month_of_birth, int year_of_birth):base(name,surname,otch)
		{
			//person(name, surname, otch);
			Age = age;
			//Sex = sex;
			Height = height;
			Weight = weight;
			DayOfBirth = day_of_birth;
			MonthOfBirth = month_of_birth;
			YearOfBirth = year_of_birth;
		}
		public int Age 
		{
			set { age = value; }
			get { return age; }
		}
		public int Height
		{
			set { height = value; }
			get { return height; }
		}
		public int Weight
		{
			set { weight = value; }
			get { return weight; }
		}
		public int DayOfBirth
		{
			set { day_of_birth = value; }
			get { return day_of_birth; }
		}
		public int MonthOfBirth
		{
			set { month_of_birth = value; }
			get { return month_of_birth; }
		}
		public int YearOfBirth
		{
			set { year_of_birth = value; }
			get { return year_of_birth; }
		}



	}
}
