/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 05/05/2021
 * Time: 20:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Radar
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declarando Variáveis
			
			float p1, p2, t, resultado;
			
			//Requisitando Dados
			
			Console.Write("Digite a Posição do Primeiro Radar: ");
			p1 = float.Parse(Console.ReadLine());
			
			Console.Write("Digite a Posição do Segundo Radar: ");
			p2 = float.Parse(Console.ReadLine());
			
			Console.Write("Digite o Tempo gasto: ");
			t = float.Parse(Console.ReadLine());
			
			//Cálculo
			
			resultado = ((p2 - p1)/t);
			
			//If e Else
			
			if(resultado>80) {
				
				Console.WriteLine();
				Console.WriteLine("Você está multado!!!");
				Console.WriteLine("Média de Velocidade: " +resultado);
				Console.WriteLine();
				
			}else {
				
				Console.WriteLine();
				Console.WriteLine("Você está dentro do Limite");
				Console.WriteLine("Média de Velocidade: " +resultado);
				Console.WriteLine();
				
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}