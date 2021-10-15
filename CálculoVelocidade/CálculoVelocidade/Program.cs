
using System;

namespace CálculoVelocidade
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Delcarando as váriaveis
			
			float distancia, tempo, velocidade;	
			
			//Pedindo a distância percorrida pelo objeto
			
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			
			Console.WriteLine("                             ╔═════════════════════════════════════════════════╗");
			Console.WriteLine("                             ║Digite a Distância percorrida pelo objeto em Km/h║");
			Console.WriteLine("                             ╚═════════════════════════════════════════════════╝");
			distancia = float.Parse(Console.ReadLine());
			Console.WriteLine();
					
			//Pedindo o Tempo do objeto
			
			Console.WriteLine("                             ╔════════════════════════════════╗");
			Console.WriteLine("                             ║Digite o tempo gasto pelo objeto║");
			Console.WriteLine("                             ╚════════════════════════════════╝");
			Console.WriteLine();
			tempo = float.Parse(Console.ReadLine());
			
			//Realizando o cálculo
		
			velocidade = (distancia/tempo);	
			
			Console.WriteLine("                             ╔════════════════════════╗");
			Console.WriteLine("                             ║A velocidade do objeto é║    ► Km/h " + velocidade);
			Console.WriteLine("                             ╚════════════════════════╝");
			Console.WriteLine();
			
			
			Console.WriteLine();
			Console.WriteLine("                             ╔═══════════════════════════════╗");
			Console.WriteLine("                             ║Press any key to continue . . .║");
			Console.WriteLine("                             ╚═══════════════════════════════╝");
			Console.ReadKey(true);
		}
	}
}