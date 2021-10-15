/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 27/04/2021
 * Time: 12:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Media_5N
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando Váriaveis
			
			float num1, num2, num3, num4, num5, total, media;
			
			//Atribuindo cor ao Console
			
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			
			//Requsitando Valores
			
			Console.WriteLine("Digite o Primeiro Número");
			num1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o Segundo Número");
			num2 = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o Terceiro Número");
			num3 = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o Quarto Número");
			num4 = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o Quinto Número");
			num5 = float.Parse(Console.ReadLine());
			
			//Modo Alternativo: float num1 = float.Parse(Console.ReadLine()); (Deste modo, declara-se a variável e a pede ao mesmo tempo)
			
			//Realizando o Cálculo
			
			total = (num1 + num2 + num3 + num4 + num5);
			media = (total/5);
			
			//Informando Resultado para o Usuário
		
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Informações Registradas");
			Console.WriteLine();
			Console.WriteLine("Primeiro Número: " +num1);
			Console.WriteLine("Segundo Número: " +num2);
			Console.WriteLine("Terceiro Número: " +num3);
			Console.WriteLine("Quarto Número: " +num4);
			Console.WriteLine("Quinto Número: " +num5);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Total: " +total);
			Console.WriteLine();
			Console.WriteLine("Média: " +media);
			Console.WriteLine();
			
			//Press any key to continue...
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}