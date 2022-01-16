using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace curs2_c_sharp_
{
    class Opros3
    {
		private bool zhidkiy_stul;
		private bool izhoga;
		private bool zapor;
		private bool poterya_apetita;
		private bool snizhenie_vesa;
		private bool toshnota;
		private bool rvota;
		private bool spazm_v_zhivote;
		private bool bol_v_zhivote;
		private string rezult()
		{
			string vivod = " ";
			if (zhidkiy_stul == true)
			{
				vivod += " 1 ";
			}
			else
			{
				vivod += " 0 ";
			}
			if (izhoga == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (zapor == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (poterya_apetita == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (snizhenie_vesa == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (toshnota == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (rvota == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			if (spazm_v_zhivote == true)
			{
				vivod += "1 ";
			}
			else
			{
				vivod += "0 ";
			}
			return vivod;
}
		public Opros3() { }
		public Opros3(bool zhidkiy_stul, bool izhoga, bool zapor, bool poterya_apetita, bool snizhenie_vesa, bool toshnota, bool rvota, bool spazm_v_zhivote, bool bol_v_zhivote)
		{

			ZhidkiyStul = zhidkiy_stul;
			Izhoga = izhoga;
			Zapor = zapor;
			PoteryaApetita = poterya_apetita;
			SnizhenieVesa = snizhenie_vesa;
			Toshnota = toshnota;
			Rvota = rvota;
			SpazmVZhivote = spazm_v_zhivote;
			BolVZhivote = bol_v_zhivote;
		}

		public bool ZhidkiyStul
		{
			set { zhidkiy_stul = value; }
			get { return zhidkiy_stul; }
		}
		public bool Izhoga
		{
			set { izhoga = value; }
			get { return izhoga; }
		}
		public bool Zapor
		{
			set { zapor = value; }
			get { return zapor; }
		}
		public bool PoteryaApetita
		{
			set { poterya_apetita = value; }
			get { return poterya_apetita; }
		}
		public bool SnizhenieVesa
		{
			set { snizhenie_vesa = value; }
			get { return snizhenie_vesa; }
		}
		public bool Toshnota
		{
			set { toshnota = value; }
			get { return toshnota; }
		}
		public bool Rvota
		{
			set { rvota = value; }
			get { return rvota; }
		}
		public bool SpazmVZhivote
		{
			set { spazm_v_zhivote = value; }
			get { return spazm_v_zhivote; }
		}
		public bool BolVZhivote
		{
			set { bol_v_zhivote = value; }
			get { return bol_v_zhivote; }
		}

		public void SaveOpros(string doc, string pat) { }


			public void saveopros(string doc, string pat)
			{
				string str;  int day, month, year, hour, minute;
				day = DateTime.Now.Day;
				month = DateTime.Now.Month;
				year = DateTime.Now.Year;
				hour = DateTime.Now.Hour;
				minute = DateTime.Now.Minute;
				str = doc + " " + pat + " " + day + "." + month + "." + year + "_" + hour + "-" + minute + " " + rezult()+"\n";
				File.AppendAllText(@"C:\Users\User\source\repos\curs2(c-sharp)\curs2(c-sharp)\opros3.txt", str, Encoding.GetEncoding(1251));
		}
	}
}
