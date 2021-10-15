/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 22/06/2021
 * Time: 22:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Empresa3
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
	
		int numeroSaque = 0;
		string resposta = "";
		
		int nota200 = 0;
		int nota100 = 0;
		int nota50 = 0;
		int nota20 = 0;
		int nota10 = 0;
		int resto = 0;
		
		
		
		void Button1Click(object sender, EventArgs e){
			
		nota200 = 0;
		nota100 = 0;
		nota50 = 0;
		nota20 = 0;
		nota10 = 0;
		resto = 0;
			
			
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			listBox3.Items.Clear();
			listBox4.Items.Clear();
			listBox5.Items.Clear();
			listBox6.Items.Clear();
			listBox7.Items.Clear();
			
			numeroSaque = int.Parse(textBox1.Text);
				
			//listBox7.Items.Add("R$"+numeroSaque);
			
			//listBox1.Items.Add("Notas de R$200,00: " +numeroSaque/200);
			
			//numeroSaque =  numeroSaque - numeroSaque/200*200;
			
			//listBox2.Items.Add("Notas de R$100,00: " +numeroSaque/100);
			
			//numeroSaque =  numeroSaque - numeroSaque/100*100;
			
			//listBox3.Items.Add("Notas de R$50,00: " +numeroSaque/50);
			
			//numeroSaque = numeroSaque % 50;
			
			//listBox4.Items.Add("Notas de R$20,00: " +numeroSaque/20);
			
			//numeroSaque = numeroSaque % 20;
			
			//listBox5.Items.Add("Notas de R$10,00: " +numeroSaque/10);
			
			//numeroSaque = numeroSaque % 10;
			
			//listBox6.Items.Add("Restante: R$" +numeroSaque);
			
			//textBox1.Clear();
			
		
		
		//Segunda opção 
		
		
		for(int i = 0; i<numeroSaque; i++){
			
			if(numeroSaque >= 200){
				
				nota200 = nota200 + 1;
				numeroSaque = numeroSaque - 200;	
			
			}if(numeroSaque >= 100 && numeroSaque < 200){
				 
				nota100 = nota100 + 1;
				numeroSaque = numeroSaque - 100;	
					
			}if(numeroSaque >= 50 && numeroSaque < 100){
				
				nota50 = nota50 + 1;
				numeroSaque = numeroSaque - 50;	
						
			}if(numeroSaque >= 20 && numeroSaque < 50){
				
				nota20 = nota20 + 1;
				numeroSaque = numeroSaque - 20;	
				
			}if(numeroSaque >= 10 && numeroSaque < 20){
				
				nota10 = nota10 + 1;
				numeroSaque = numeroSaque - 10;	
					
			}if(numeroSaque < 10){
				
				resto = numeroSaque;
	
			}
			
		}
		
		
		
		listBox1.Items.Add("Notas de R$200,00: " +nota200);
		listBox2.Items.Add("Notas de R$100,00: " +nota100);
		listBox3.Items.Add("Notas de R$50,00: " +nota50);
		listBox4.Items.Add("Notas de R$20,00: " +nota20);
		listBox5.Items.Add("Notas de R$10,00: " +nota10);
		listBox6.Items.Add("Restante: " +resto);
		
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
	
			textBox1.Clear();
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			listBox3.Items.Clear();
			listBox4.Items.Clear();
			listBox5.Items.Clear();
			listBox6.Items.Clear();
			listBox7.Items.Clear();
	
			
			
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
	}
}
