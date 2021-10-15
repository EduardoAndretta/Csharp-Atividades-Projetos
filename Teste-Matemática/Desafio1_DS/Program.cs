
using System;

namespace Desafio1_DS
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.Clear();
			
			float num1, num2, soma, subtracao, divisao, multiplicacao;
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("                                         Digite o primeiro número:");
			Console.WriteLine("                                       ═════════════════════════════");
			num1 = float.Parse(Console.ReadLine());
			
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("                                         Digite o segundo número:");
			Console.WriteLine("                                       ════════════════════════════");
			num2 = float.Parse(Console.ReadLine());
			
			soma = num1 + num2;
			subtracao = num1 - num2;
			divisao = num1 / num2;
			multiplicacao = num1 * num2;
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write("                                         O Resultado de "+ num1 +" + "+ num2 +" é "+soma);
			Console.WriteLine();
			Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
			Console.ReadKey(true);
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("                                         O Resultado de "+ num1 +" - "+ num2 +" é "+subtracao);
			Console.WriteLine();
			Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
			Console.ReadKey(true);
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.Write("                                         O Resultado de "+ num1 +" / "+ num2 +" é "+divisao);
			Console.WriteLine();
			Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
			Console.ReadKey(true);
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("                                          O Resultado de "+ num1 +" * "+ num2 + " é "+multiplicacao);
			Console.WriteLine();
			Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			
		}
	}
}