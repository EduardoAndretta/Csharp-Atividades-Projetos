/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 10/05/2021
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exemplo1
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void Button1Click(object sender, EventArgs e) //Método - Clique no Botão
		{
	
			// componente.Propriedade
			
			int n1 = int.Parse(textBox1.Text);
			int n2 = int.Parse(textBox2.Text);
			
			int soma = n1 + n2;
			
			textBox3.Text = soma.ToString();
	
			this.BackColor = Color.AliceBlue;
		
		
		}
}

	
}