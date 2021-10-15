/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 22/06/2021
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Empresa2
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		
		}
		
		string[] nomes = new string[50];
		float[] saldos = new float[50];
		float[] saldosBonus = new float[50];
		float[] saldoTotal = new float[50];
		
		int cont = 0;
		float saldoBonus = 0;
		float saldo = 0;
		string nome = "";
		
		
		void Button1Click(object sender, EventArgs e)
		{
	
			if(cont == 49){
                
                button1.Enabled = false;
                MessageBox.Show("Limite Alcançado");
            
            }

			saldo = 0;
			saldoBonus = 0;
			nome = "";
			
			saldos[cont] = float.Parse(textBox1.Text);
			saldo = float.Parse(textBox1.Text);
			nomes[cont] = textBox2.Text;
			
			if(saldo >= 0 && saldo <= 200){
			   	
				saldoBonus = 0;
				saldosBonus[cont] = saldoBonus;
			
			}else if(saldo >= 201 && saldo <= 400){
				
				saldoBonus = (float)(saldo * 0.2);
				saldosBonus[cont] = saldoBonus;
			
			}else if(saldo >= 401 && saldo <= 600){
				
				saldoBonus = (float)(saldo * 0.3);	
				saldosBonus[cont] = saldoBonus;
			
			}else if(saldo >= 601){
				
				saldoBonus = (float)(saldo * 0.4);	
				saldosBonus[cont] = saldoBonus;
			
			}else{
					
				MessageBox.Show("Digite um número válido");
				
			}
			
	
			saldoTotal[cont] = saldoBonus + saldo;
			
			
			cont++;

			textBox1.Clear();
			textBox2.Clear();
			
			listBox1.Items.Clear();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
	
			listBox1.Items.Clear();
			
			for(int i = 0; i<cont; i++){
				
				listBox1.Items.Add("Nome:" +nomes[i]);
				listBox1.Items.Add("Saldo:" +saldos[i]);
				listBox1.Items.Add("Saldo Bônus:" +saldosBonus[i]);
				listBox1.Items.Add("");
				listBox1.Items.Add("Total:" +saldoTotal[i]);
				listBox1.Items.Add("");
				
			}
			
			
			
			
		}
	
	
	
	
	
	
	
	
	
	
	
	}
}
