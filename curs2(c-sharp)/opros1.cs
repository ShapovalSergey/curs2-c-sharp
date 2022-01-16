using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace curs2_c_sharp_
{
    class Opros1:ISaveOpros
    {
		private bool sopli;
		private bool kashel;
		private bool bol_v_gorle;
		private bool zalozhen_nos;
		private bool bol_v_ushah;
		private bool golov_bol;
		private bool oznob;
		private double temperature;
		private bool zhar;
		private string rezult()
		{
			string vivod = " ";
			if (sopli == true)
			{
				vivod += " 1 ";
			}
			else
			{
				vivod += " 0 ";
			}
			if (kashel == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (bol_v_gorle == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (zalozhen_nos == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (bol_v_ushah == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (golov_bol == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (oznob == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (zhar == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			vivod += temperature;
			return vivod;
}
		public Opros1() { }
		public Opros1(bool sopli, bool kashel, bool bol_v_gorle, bool zalozhen_nos, bool bol_v_ushah, bool golov_bol, bool oznob, bool zhar, double temperature)
		{

			Sopli = sopli;
			Kashel = kashel;
			BolVGorle = bol_v_gorle;
			ZalozhenNos = zalozhen_nos;
			BolVUshah = bol_v_ushah;
			GolovBol = golov_bol;
			Oznob = oznob;
			Zhar = zhar;
			Temperature = temperature;
		}

		public bool Sopli
		{
			set { sopli = value; }
			get { return sopli; }
		}
		public bool Kashel
		{
			set { kashel = value; }
			get { return kashel; }
		}
		public bool BolVGorle
		{
			set { bol_v_gorle = value; }
			get { return bol_v_gorle; }
		}
		public bool ZalozhenNos
		{
			set { zalozhen_nos = value; }
			get { return zalozhen_nos; }
		}
		public bool BolVUshah
		{
			set { bol_v_ushah = value; }
			get { return bol_v_ushah; }
		}
		public bool GolovBol
		{
			set { golov_bol = value; }
			get { return golov_bol; }
		}
		public bool Oznob
		{
			set { oznob = value; }
			get { return oznob; }
		}
		public bool Zhar
		{
			set { zhar = value; }
			get { return zhar; }
		}
		public double Temperature 
		{
			set { temperature = value; }
			get { return temperature; }
		}

		public void SaveOpros(string doc, string pat) { }


			public void saveopros(string doc, string pat)
			{
			string str; int day, month, year, hour, minute;
			day = DateTime.Now.Day;
			month = DateTime.Now.Month;
			year = DateTime.Now.Year;
			hour = DateTime.Now.Hour;
			minute = DateTime.Now.Minute;
			str = doc + " " + pat + " " + day + "." + month + "." + year + "_" + hour + "-" + minute + " " + rezult() + "\n";
			File.AppendAllText(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\opros1.txt", str, Encoding.GetEncoding(1251));
		}
	}
}
