/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 27/04/2021
 * Time: 13:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Aplicacao
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando Variáveis
			
			double txJuros, vlrAplicado, r;
			
			//Atribuindo cor ao Console
			
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			
			//Requisitando Valores
			
			Console.WriteLine("Olá, Digite os Valores solicitados");
			Console.WriteLine();
			Console.WriteLine("Digite o Valor Aplicado");
			vlrAplicado = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite a Taxa de Juros");
			txJuros = double.Parse(Console.ReadLine());
			
			//Realizando Cálculo
			
			r = ((txJuros/100) * vlrAplicado);
			
			//Informando Dados ao Usuário
			
			//Dados Informados
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Dados Informados");
			Console.WriteLine();
			Console.WriteLine("Valor da Aplicação: R$" +vlrAplicado);
			Console.WriteLine("Taxa de Juros: " +txJuros+ "%");
			Console.WriteLine();
			
			//Informando o Resultado
			
			Console.WriteLine();
			Console.WriteLine("Resultado");
			Console.WriteLine();
			Console.WriteLine("Rendimento: R$" +r);
			Console.WriteLine();
			
			//Press any key to continue...
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}