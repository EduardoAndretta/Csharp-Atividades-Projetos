/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 07/06/2021
 * Time: 21:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vetor_Array
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
		
		int cont = 0;
		
		string [] nomes = new string[10];
		
		//string [] nomes = {"Maria","Pedro","Juca","Marcio","Eliana","Valmir","Julia","Camila","Rosa","João"};
			
				
		void Button1Click(object sender, EventArgs e)
		{
	
		//	nomes[0] = "Maria";
		//	nomes[1] = "Pedro";
		//	nomes[2] = "Juca";
		//	nomes[3] = "Marcio";
			
		listBox1.Items.Clear();
		
		for(int i = 0; i < cont; i++){
			
			listBox1.Items.Add(nomes[i]);
			
			
		}
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
	
			nomes[cont] = textBox1.Text;
			textBox1.Clear();
			
			cont++;
			label1.Text = "Registro:" + cont;
			
			if(cont == 10){
				
				button2.Enabled = false;
				MessageBox.Show("Limite Alcançado");
			
			}
			
			Button1Click(this, null);
			
		}
		void Button3Click(object sender, EventArgs e)
		{
	
			
			int pos = int.Parse(textBox3.Text);
			pos = pos - 1;
			
			nomes[pos] = textBox2.Text;
			
			textBox2.Clear();
			textBox3.Clear();
			
			MessageBox.Show("Alteração efetuada com sucesso");
			
			Button1Click(this, null);
		
		}
		void Button4Click(object sender, EventArgs e)
		{
	
			string s = "CAVALO";
			
			for( int i =0; i <6; i++)
				
				listBox1.Items.Add(s[i]);
			
			
			
		}
		
		
	}
}
