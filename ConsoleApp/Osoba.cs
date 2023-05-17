using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	// objekt osoba a její vlastnosti
	internal class Osoba
	{
		public string Jmeno { get; private set; }
		public string Prijmeni { get; private set; }
		public int Vek { get; set; }
		public int Tel { get; set; }


		public Osoba(string jmeno, string prijmeni, int vek, int tel)
		{
			Jmeno = jmeno;
			Prijmeni = prijmeni;
			Vek = vek;
			Tel = tel;
		}

		
		public override string ToString()
		{
			return string.Format("Pojištěný: {0} {1}, věk: {2}, tel: {3}", Jmeno, Prijmeni, Vek, Tel);
		}
	}
}
