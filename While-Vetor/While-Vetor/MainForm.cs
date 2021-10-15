/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 09/06/2021
 * Time: 19:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace While_Vetor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
		
		}
		
		//Variáveis globais (Fora de qualquer Método, mas dentro da Classe)
			
		string[] nomes = new string[10];
			
		int cont=0;
		                       
		void Button1Click(object sender, EventArgs e)
		{
		
			//Variáveis locais (Dentro do Método)
			
			if (textBox1.Text !=""){
				
				nomes[cont] = textBox1.Text;
				textBox1.Clear();
				textBox1.Focus();
				MessageBox.Show("Registro cadastrado com sucesso.");
				
			}else{
				
				MessageBox.Show("Preencha o campo nome.");
				textBox1.Focus();
			}
			
			
				cont++;
			
			if(cont==10){
				
				button1.Enabled = false;
			}
		
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
	
			//While
				
			int i = 0;
			listBox1.Items.Clear();
				
			
			while(i<cont){
					
					
				listBox1.Items.Add(nomes[i]);
				i++;
				
			}
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
	
			listBox1.Items.Clear();
			
			//Exemplo Floreach = Para cada
			
			foreach(string nome in nomes){
				
				listBox1.Items.Add(nome);
				
			}
			
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
	
			for(int i=0; i<10; i++){
				
				nomes[i] = "";
				
			}
			
			MessageBox.Show("Vetor inicializado");
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
	
			//Botão Salvar
			
			richTextBox1.SaveFile("Teste1.txt",RichTextBoxStreamType.PlainText);
			MessageBox.Show("Registro salvo com sucesso");
			
		}
		
		void Button5Click(object sender, EventArgs e)
		
		{
	
			richTextBox1.LoadFile("Teste1.txt",RichTextBoxStreamType.PlainText);
			
		}
		
		
	}
}
