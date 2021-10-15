/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 02/05/2021
 * Time: 18:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SalarioAumento
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando Variáveis
			
			string nome1 = "Pedro", nome2 = "Karina", nome3 = "Tanaka", nome4 = "Luiz", nome5 = "Silmara";
			double salario1 = 2080.00, salario2 = 1821.1, salario3 = 980, salario4 = 1000.00, salario5 = 2500.00;
			double porcentagem, x;
			
			//Adicionando Cor
			
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			
			//Exibindo Salários Originais
			
			Console.WriteLine("Salário Inincial");
			Console.WriteLine();
			Console.WriteLine("Funcionario 1 - " +nome1);
			Console.WriteLine("Salário - R$" +salario1);
			Console.WriteLine();
			Console.WriteLine("Funcionario 2 - " +nome2);
			Console.WriteLine("Salário - R$" +salario2);
			Console.WriteLine();
			Console.WriteLine("Funcionario 3 - " +nome3);
			Console.WriteLine("Salário - R$" +salario3);
			Console.WriteLine();
			Console.WriteLine("Funcionario 4 - " +nome4);
			Console.WriteLine("Salário - R$" +salario4);
			Console.WriteLine();
			Console.WriteLine("Funcionario 5 - " +nome5);
			Console.WriteLine("Salário - R$" +salario5);
			Console.WriteLine();
			Console.WriteLine();
			
			//Pedindo a Porcentagem de aumento
			
			Console.Write("Digite a Porcentagem de Aumento:");
			porcentagem = float.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine();
			
			//Realizando Cálculos
			
			x = (porcentagem/100);
			salario1 = (salario1 + (salario1*x));
			salario2 = (salario2 + (salario2*x));
			salario3 = (salario3 + (salario3*x));
			salario4 = (salario4 + (salario4*x));
			salario5 = (salario5 + (salario5*x));
			
			//Exibindo Resultado
			
			Console.WriteLine("Porcentagem: " +porcentagem+ "%");
			Console.WriteLine();
			Console.WriteLine("Salário Final");
			Console.WriteLine();
			Console.WriteLine("Funcionario 1 - " +nome1);
			Console.WriteLine("Salário - R$" +salario1);
			Console.WriteLine();
			Console.WriteLine("Funcionario 2 - " +nome2);
			Console.WriteLine("Salário - R$" +salario2);
			Console.WriteLine();
			Console.WriteLine("Funcionario 3 - " +nome3);
			Console.WriteLine("Salário - R$" +salario3);
			Console.WriteLine();
			Console.WriteLine("Funcionario 4 - " +nome4);
			Console.WriteLine("Salário - R$" +salario4);
			Console.WriteLine();
			Console.WriteLine("Funcionario 5 - " +nome5);
			Console.WriteLine("Salário - R$" +salario5);
			Console.WriteLine();
			
			//Press any key to continue...
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}