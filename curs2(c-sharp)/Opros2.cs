using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace curs2_c_sharp_
{
    class Opros2
    {
		private bool onemenie;
		private bool golovokruzhenie;
		private bool slabost;
		private bool pokalivanie;
		private bool podergivanie;
		private bool golov_bol;
		private bool epilep_pripadki;
		private bool shataet_pri_hodbe;
		private bool bol_v_spine;
		private string rezult()
		{
			string vivod = " ";
			if (onemenie == true)
			{
				vivod += " 1 ";
			}
			else
			{
				vivod += " 0 ";
			}
			if (golovokruzhenie == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (slabost == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (pokalivanie == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (podergivanie == true)
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
			if (epilep_pripadki == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (shataet_pri_hodbe == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (bol_v_spine == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			return vivod;
}
		public Opros2() { }
		public Opros2(bool onemenie, bool golovokruzhenie, bool slabost, bool pokalivanie, bool podergivanie, bool golov_bol, bool epilep_pripadki, bool shataet_pri_hodbe, bool bol_v_spine)
		{

			Onemenie = onemenie;
			Golovokruzhenie = golovokruzhenie;
			Slabost = slabost;
			Pokalivanie = pokalivanie;
			Podergivanie = podergivanie;
			GolovBol = golov_bol;
			EpilepPripadki = epilep_pripadki;
			ShataetPriHodbe = shataet_pri_hodbe;
			BolVSpine = bol_v_spine;
		}

		public bool Onemenie
		{
			set { onemenie = value; }
			get { return onemenie; }
		}
		public bool Golovokruzhenie
		{
			set { golovokruzhenie = value; }
			get { return golovokruzhenie; }
		}
		public bool Slabost
		{
			set { slabost = value; }
			get { return slabost; }
		}
		public bool Pokalivanie
		{
			set { pokalivanie = value; }
			get { return pokalivanie; }
		}
		public bool Podergivanie
		{
			set { podergivanie = value; }
			get { return podergivanie; }
		}
		public bool GolovBol
		{
			set { golov_bol = value; }
			get { return golov_bol; }
		}
		public bool EpilepPripadki
		{
			set { epilep_pripadki = value; }
			get { return epilep_pripadki; }
		}
		public bool ShataetPriHodbe
		{
			set { shataet_pri_hodbe = value; }
			get { return shataet_pri_hodbe; }
		}
		public bool BolVSpine
		{
			set { bol_v_spine = value; }
			get { return bol_v_spine; }
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
				File.AppendAllText(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\opros2.txt", str, Encoding.GetEncoding(1251));	}
	}
}
