using ConsoleApp;

internal class Program
{
    // úvod (welcome sekce)
	private static void Main(string[] args)
	{		
        Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.WriteLine("--------------------");
		Console.WriteLine("Evidence pojištěných");
		Console.WriteLine("--------------------");
		Console.ForegroundColor = ConsoleColor.DarkGray;
		Console.WriteLine("Dnes je: {0}", DateTime.Now.ToShortDateString());
        Console.ForegroundColor = ConsoleColor.White;
		Thread.Sleep(500);

        // instance databáze
        Databaze databaze = new Databaze();

		char volba = '0';

		// hlavní cyklus výběru akce
		while (volba != '4')
		{
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3 - Vyhledat pojištěného");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("4 - Konec \n");
            Console.ForegroundColor = ConsoleColor.White;


            volba = Console.ReadKey().KeyChar;
            Thread.Sleep(500);
            Console.WriteLine();

			// reakce na volbu
			switch (volba)
			{
				case '1':
                    Console.WriteLine("Přidat nového pojištěného \n");
					databaze.PridejOsobu();
                    Console.WriteLine();
                    break;
				case '2':
                    Console.WriteLine("Vypsat všechny pojištěné \n");
                    databaze.NajdiOsobu();
                    Console.WriteLine();
                    break;
				case '3':
                    Console.WriteLine("Vyhledat pojištěného \n");
					databaze.VyhledejOsobu();
                    Console.WriteLine();
                    break;
				case '4':
                    Console.WriteLine("Na shledanou");
					break;
                default: Console.WriteLine("Neplatná volba");
					break;
			}
        }


	}
}