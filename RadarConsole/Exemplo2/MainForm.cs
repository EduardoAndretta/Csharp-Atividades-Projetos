/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 12/05/2021
 * Time: 19:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exemplo2
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
	
			float p1 = float.Parse(textBox1.Text);
			float p2 = float.Parse(textBox2.Text);
			float t = float.Parse(textBox3.Text);
			
			float res = (p2 - p1)/t;
			
			label5.Text = res.ToString()+"Km/h";
			
			if(res>80){
				
				label7.Text = "Você está Multado!";
				pictureBox8.Load("Guarda.png");
					
			}else{
				
				label7.Text = "Tudo Correto!";
				pictureBox8.Load("Flanders.jpg");
				
				
			}
			
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		
	}
}
