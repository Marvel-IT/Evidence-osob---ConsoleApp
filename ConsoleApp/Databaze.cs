using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	internal class Databaze
	{
		// databáze osob
		private List<Osoba> osoby;

		public Databaze()
		{
			osoby = new List<Osoba>();
		}

		// metoda přidání nové osoby
		public void PridejOsobu()			
		{
            Console.Write("Zadejte jméno pojištěného: ");
			string jmeno = Console.ReadLine();
            Console.Write("Zadejte přijmení pojištěného: ");
			string prijmeni = Console.ReadLine();
            Console.Write("Zadejte věk: ");
			int vek = int.Parse(Console.ReadLine());
			Console.Write("Zadejte telefonní číslo: ");
			int tel = int.Parse(Console.ReadLine());
            osoby.Add(new Osoba(jmeno, prijmeni, vek, tel));
		}


		// metoda vypsání poj. osoby
		public void VypisOsoby()
		{
            Console.WriteLine(osoby);
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
			Console.ReadKey();
		}

		// metoda vypsání všech osob
		public List<Osoba> NajdiOsobu()
		{
			if (osoby.Count > 0)
			{                
				foreach (Osoba o in osoby)
                    Console.WriteLine(o);
				Console.WriteLine("Pokračujte libovolnou klávesou...");
				Console.ReadKey();
			}
			else
                Console.WriteLine("V databázi nejsou žádné záznamy.");
			return osoby;
        }		 

		// metoda hlední poj. osoby
		public void VyhledejOsobu()
		{
			if (osoby.Count > 0)
			{
                Console.WriteLine("Zadejte jméno pojištěného: ");
				string jmeno = Console.ReadLine();
				Console.WriteLine("Zadejte přijmení pojištěného: ");
				string prijmeni = Console.ReadLine();
                Console.WriteLine(); 
                foreach (Osoba o in osoby)
				{
					if ((o.Jmeno.Trim().ToLower() == jmeno.Trim().ToLower()) && (o.Prijmeni.Trim().ToLower() == prijmeni.Trim().ToLower()))
						Console.WriteLine(o);
					Console.WriteLine("Pokračujte libovolnou klávesou...");
                    Console.ReadKey();
                }
            }
			else
				Console.WriteLine("V databázi nejsou žádné záznamy.");
		}
				
	}
}
