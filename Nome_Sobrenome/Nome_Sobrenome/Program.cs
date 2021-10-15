/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 27/04/2021
 * Time: 13:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Nome_Sobrenome
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando Variáveis
			
			string nome, sobrenome;
			
			//Requisitando Valores
			
			//Atribuindo cor ao Console
			
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			
			Console.WriteLine("Digite seu Nome");
			nome = (Console.ReadLine());
			Console.WriteLine("Digite seu Sobrenome");
			sobrenome = (Console.ReadLine());
			
			//Informando Sobrenome, Nome ao Usuário
			
			//Dados Informados
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Dados Informados");
			Console.WriteLine();
			Console.WriteLine("Nome: " +nome);
			Console.WriteLine("Sobrenome: " +sobrenome);
			Console.WriteLine();
			
			//Informando o Resultado
			
			Console.WriteLine();
			Console.WriteLine("Resultado");
			Console.WriteLine();
			Console.WriteLine(sobrenome+ ", " +nome);
			Console.WriteLine();
			
			//Press any key to continue...
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}