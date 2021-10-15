/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 27/04/2021
 * Time: 13:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Data_Mes_Dia
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando Variáveis
			
			string ano, mes, dia;
			
			//Requisitando Dados
			
			//Atribuindo cor ao Console
			
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			
			Console.WriteLine("Digite o Ano");
			ano = (Console.ReadLine());
			Console.WriteLine("Digite o Mês");
			mes = (Console.ReadLine());
			Console.WriteLine("Digite o Dia");
			dia = (Console.ReadLine());
			
		    //Exibindo Resultado
		    
		   	//Dados Fornecidos
		   	
		   	Console.WriteLine();
		   	Console.WriteLine("Dados Fornecidos");
		   	Console.WriteLine();
		   	Console.WriteLine("Dia: " +dia);
		   	Console.WriteLine("Mês: " +mes);
		   	Console.WriteLine("Ano: " +ano);
		   	Console.WriteLine();

		   	//Alternativo: string resp = dia + "/" + mes + "/" + ano; 
		   	//             Console.WriteLine(resp);

		    Console.WriteLine();
		    Console.WriteLine("Data: " +dia+ "/" +mes+ "/" +ano);
		    Console.WriteLine();
			
		    //Press any key to continue...
		    
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}