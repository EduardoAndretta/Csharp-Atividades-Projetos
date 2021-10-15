
using System;

namespace ExempleMaster
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Barra Barra significa comentário, vale até o final da linha
			//Comentários não saem na tela quando o programa está rodando.
			
			Console.WriteLine(); //Linha em Branco
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(); //Mnadei pular quatro linhas
		
			//Agora vou contruir uma janela
			
			//Caracter 201 seguido de 25x o caracter 205 e o caracter 187 no fim da linha
			Console.WriteLine("                 ╔═════════════════════════╗");
			
			//Caracter 186 seguindo de 25 em branco e o 186 no fim da linha
			Console.WriteLine("                 ║                         ║");
			
			//Repete essa linha mais cinco vezes
			Console.WriteLine("                 ║     AULA DE LÓGICA      ║");
			Console.WriteLine("                 ║                         ║");
			Console.WriteLine("                 ║       BOA NOITE         ║");
			Console.WriteLine("                 ║                         ║");
			Console.WriteLine("                 ║                         ║");
			
			//Finaliza com caracter 200, 25x caracter 205 e o 188 no fim da linha
			Console.WriteLine("                 ╚═════════════════════════╝");
			
			//Pulando mais quatro linhas
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}