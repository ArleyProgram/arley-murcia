class program

{

	static void Main()
	{
		Random rnd = new Random();
		int pp = 0;
		int pv = 0;

		while (pp < 3 && pv < 3)
		{
			Console.WriteLine("elija piedra, papel, tijera, lagarto o spock");
			String eperson = Console.ReadLine().ToLower();

			if (eperson != "piedra" && eperson != "papel" && eperson != "tijera" && eperson != "lagarto" && eperson != "spock")
			{
				Console.WriteLine("Ups! solo puedes elegir entre piedra, papel, tijera, lagarto y spock");
			}

			
			String[] opciones = { "piedra", "papel", "tijera", "lagarto", "spock" };
			int opcionaleatoria = rnd.Next(0, 5);
			String evirtual = opciones[opcionaleatoria];

			
			Console.WriteLine("tu elegiste " + eperson);
			Console.WriteLine("el jugador virtual eligio " + evirtual);

			if (eperson == evirtual)
			{
				Console.WriteLine("Empate!!");
			}
			else
				if ((eperson == "piedra" && (evirtual == "tijera" || evirtual == "largarto")) ||
				(eperson == "papel" && (evirtual == "piedra" || evirtual == "spock")) ||
				(eperson == "tijera" && (evirtual == "papel" || evirtual == "lagarto")) ||
				(eperson == "largarto" && (evirtual == "spock" || evirtual == "papel")) ||
				(eperson == "spock" && (evirtual == "tijeras" || evirtual == "piedra")))
			{
				Console.WriteLine("ganaste esta ronda");
				pp++;
			}
			else
			{
				Console.WriteLine("el jugador virtual a ganado esta ronda");
				pv++;
			}
			Console.WriteLine($"marcador actual:tu [{pp}] - jugador virtual [{pv}] ");
			Console.WriteLine();

		}
	
		if (pp >= 3)
		{
			Console.WriteLine("has ganado");
		}
		else if (pv >= 3)
		{
			Console.WriteLine("juagador virtual ha ganado");
		}

	}
}
