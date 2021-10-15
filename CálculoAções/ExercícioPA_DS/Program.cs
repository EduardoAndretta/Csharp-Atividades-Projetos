
using System;

namespace ExercícioPA_DS
{
	class Program
	{
		public static void Main(string[] args)
		{
			float precoAcao, dividendos, dividendYield, totalProventos;
			int qtdAcao;
			
			
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			
			//Pedindo o valor da ação
			
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("                      ╔═══════════════════════════╗");
			Console.WriteLine("                      ║Olá, digite o valor da ação║");
			Console.WriteLine("                      ╚═══════════════════════════╝");
			precoAcao = float.Parse(Console.ReadLine());
			
			//Pedindo o valor de provento pago por ação
			
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("                      ╔═════════════════════════════════════════════╗");
			Console.WriteLine("                      ║Digite o valor do Provento pago por cada ação║");
			Console.WriteLine("                      ╚═════════════════════════════════════════════╝");
			dividendos = float.Parse(Console.ReadLine());
			
			//Pedindo a quantidade de ações adquiridas
			
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("                      ╔═══════════════════════════════════╗");
			Console.WriteLine("                      ║Digite o número de ações adquiridas║");
			Console.WriteLine("                      ╚═══════════════════════════════════╝");
			qtdAcao = int.Parse(Console.ReadLine());
			
			
			Console.WriteLine();
			
			//Total de Proventos em um ano
			
			//Justificativa = 3 porque há 12 meses e os dividendo são pagos a cada quatro meses.
			
			dividendYield = (((3 * dividendos/precoAcao)) * qtdAcao);
			
			totalProventos = 3 * dividendos * qtdAcao;
			 
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("                      ╔══════════════════╗");
			Console.WriteLine("                      ║Números Informados║");
			Console.WriteLine("                      ╚══════════════════╝");
			
			
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			
			//Informando os Valores usados para o cálculo
			
			Console.WriteLine("                      ╔═══════════════════════════════════╗");
			Console.WriteLine("                      ║Valor da Ação                      ║-->  "+ precoAcao);
			Console.WriteLine("                      ║Valor do Provento por Ação         ║-->  "+ dividendos);
			Console.WriteLine("                      ║Quantidade de ações adquiridas     ║-->  "+ qtdAcao);
			Console.WriteLine("                      ╚═══════════════════════════════════╝");
			Console.WriteLine();
			Console.WriteLine();
			 
			//Informando o Total de Proventos recebidos no período de um ano
			
			Console.WriteLine("                      ╔═══════════════════════════════════════════════════════════════╗");
			Console.WriteLine("                      ║O Total de Dividendo recebidos no período de um ano equivale a ║-->  R$" + totalProventos);
			Console.WriteLine("                      ╚═══════════════════════════════════════════════════════════════╝");
			Console.WriteLine();
			Console.WriteLine();
			
			//Informando o Dividend Yield
		
			Console.WriteLine("                      ╔════════════════════════════╗");
			Console.WriteLine("                      ║O Dividend Yield equivale a ║-->  " + dividendYield + "%");
			Console.WriteLine("                      ╚════════════════════════════╝");
			Console.WriteLine();
			Console.WriteLine();
		
			
			//Press Key. . .
			
			Console.WriteLine("                      ╔════════════════════════════════╗");
			Console.WriteLine("                      ║Press any key to continue . . . ║");
			Console.WriteLine("                      ╚════════════════════════════════╝");
			Console.ReadKey(true);
		}
	}
}