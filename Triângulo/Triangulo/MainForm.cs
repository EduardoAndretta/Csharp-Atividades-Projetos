/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 26/05/2021
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Triangulo
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
		void Button1Click(object sender, EventArgs e)
		{
	
			
			float a = float.Parse(textBox1.Text);
			float b = float.Parse(textBox2.Text);
			float c = float.Parse(textBox3.Text);
			
			if(a==b && c==b){textBox4.Text = "Triângulo Equilátero";}
				
			if(a==b && a!=c){textBox4.Text = "Triângulo Isosceles";}	
			if(a==c && a!=b){textBox4.Text = "Triângulo Isosceles";}

			if(b==a && b!=c){textBox4.Text = "Triângulo Isosceles";}	
			if(b==c && b!=a){textBox4.Text = "Triângulo Isosceles";}

			if(c==b && c!=a){textBox4.Text = "Triângulo Isosceles";}	
			if(c==a && c!=b){textBox4.Text = "Triângulo Isosceles";}

			if(a!=c && c!=b){textBox4.Text = "Trângulo Escaleno";}
			
	
			//Correção
			
			if(a==b && c==b)
				textBox4.Text = "Triângulo Equilátero";
			
			else if(a==b || a==c || c==b)
				textBox4.Text = "Triângulo Isosceles";
			
			else
				textBox4.Text = "Trângulo Escaleno";
			
			
			
		}
	}
}
