/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 28/04/2021
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Troca
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando e Requisitando as Variáveis
			
			int a, b, aux;
			
			//Requsitando Dados
			
			Console.Write("Valor A:");
			a = int.Parse(Console.ReadLine());
			Console.Write("Valor B:");
			b = int.Parse(Console.ReadLine());
			
			//Efetuando a Troca1
			
			aux = b;
			b = a;
			a = aux;
				
			//Exibindo o Resultado
		
			Console.WriteLine();
			Console.WriteLine("A: " +a);
			Console.WriteLine("B: " +b);
			Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}