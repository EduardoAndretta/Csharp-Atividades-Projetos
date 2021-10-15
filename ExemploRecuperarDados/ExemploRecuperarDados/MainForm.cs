/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 30/06/2021
 * Time: 19:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExemploRecuperarDados
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		int contador = 0;
		string[] nomes;
		
		
		void Button1Click(object sender, EventArgs e)
		{
	
			//Botão Salvar

			richTextBox1.SaveFile(textBox1.Text, RichTextBoxStreamType.PlainText);
			MessageBox.Show("Arquivo salvo com sucesso","AVISO!");
			
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
	
			//Botão Abrir
			
			try{
			
				richTextBox1.LoadFile(textBox1.Text, RichTextBoxStreamType.PlainText);
				nomes = richTextBox1.Text.Split(' ','\n');
				
			}catch (Exception ex){
				
				System.Media.SystemSounds.Beep.Play();
				MessageBox.Show("Erro ao abrir o arquivo","AVISO!");
				
			}
				
		}
		void Button3Click(object sender, EventArgs e)
		{
	
			//Adcionar
			
			richTextBox1.Text += textBox2.Text + "\n" ;
			
			nomes[contador] = textBox2.Text;
			nomes = richTextBox1.Text.Split(' ','\n');
			
			textBox2.Clear();
			textBox2.Focus();
			
			
			contador++;
		}
		void Button4Click(object sender, EventArgs e)
		{
	
			//Listar
			
			int contPalavra = 0;
			
			foreach(string nome in nomes){
				
				listBox1.Items.Add(nome);
				if(nome == textBox5.Text){
					
					contPalavra++;
					
				}
				
				
			}
			
			label4.Text = "Quantidade de Palavras: " +nomes.Length;
			label5.Text = "Quantidade de Palavras Especificas: " +contPalavra;
			
		}
		void Button5Click(object sender, EventArgs e)
		{
	
		
			string texto = textBox4.Text;
			char caracter = textBox3.Text[0];
		
			string[] vetor = texto.Split(caracter);
			
			//Listar
			
			listBox1.Items.Clear();
			foreach(string elemento in vetor)
				listBox1.Items.Add(elemento);
			
			
		}
	}
}
