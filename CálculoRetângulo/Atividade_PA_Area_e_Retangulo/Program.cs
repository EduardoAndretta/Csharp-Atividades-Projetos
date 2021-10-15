
using System;

namespace Atividade_PA_Area_e_Retangulo
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando váriaveis
			
			float ladoMaior, ladoMenor, area, perimetro;
			
			
			//Pedindo as váriaveis ladoMaior e ladoMenor
			
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			
			Console.WriteLine("                                      ╔════════════════════════════════╗");
			Console.WriteLine("                                      ║Digite o Lado Maior do Retângulo║");
			Console.WriteLine("                                      ╚════════════════════════════════╝");
			
			ladoMaior = float.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("                                      ╔════════════════════════════════╗");
			Console.WriteLine("                                      ║Digite o Lado Menor do Retângulo║");
			Console.WriteLine("                                      ╚════════════════════════════════╝");
			
			ladoMenor = float.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine();
			
			
			//Realizando os cálculos 
			
			perimetro = (ladoMaior + ladoMaior + ladoMenor + ladoMenor);
			
			area = (ladoMaior * ladoMenor);
			
			//Exibindo as informações coletadas 

			
			Console.WriteLine("                                      ╔══════════════════╗");
			Console.WriteLine("                                      ║Valores Informados║");
			Console.WriteLine("                                      ╚══════════════════╝");
			Console.WriteLine();
			Console.WriteLine();

			
			Console.WriteLine("                                      ╔═══════════════════════╗");
			Console.WriteLine("                                      ║Lado Maior do Retângulo║ ► "  + ladoMaior);
			Console.WriteLine("                                      ╚═══════════════════════╝");
			Console.WriteLine();
			Console.WriteLine();
			
			
			Console.WriteLine("                                      ╔═══════════════════════╗");
			Console.WriteLine("                                      ║Lado Menor do Retângulo║ ► " + ladoMenor);
			Console.WriteLine("                                      ╚═══════════════════════╝");
			Console.WriteLine();
			Console.WriteLine();
			
			//Exibindo os Resultados
			
			Console.WriteLine("                                      ╔══════════════════════════════════════╗");
			Console.WriteLine("                                      ║A Área deste Retângulo é equivalente a║ ► " + area);
			Console.WriteLine("                                      ╚══════════════════════════════════════╝");
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("                                      ╔═══════════════════════════════════════════╗");
			Console.WriteLine("                                      ║O Perímetro deste Retângulo é equivalente a║ ► "+ perimetro);
			Console.WriteLine("                                      ╚═══════════════════════════════════════════╝");
			Console.WriteLine();
			Console.WriteLine();
			
			//Press Key to continue. . . 
			
			Console.WriteLine("                                      ╔═══════════════════════════════╗");
			Console.WriteLine("                                      ║Press any key to continue . . .║");
			Console.WriteLine("                                      ╚═══════════════════════════════╝"); 
			Console.ReadKey(true);
		}
	}
}