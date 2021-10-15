/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 12/05/2021
 * Time: 18:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CálculadoraBásica
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
	
			float soma1 = float.Parse(textBox2.Text);
			float soma2 = float.Parse(textBox1.Text);
			
			float soma = soma1 + soma2;
			
			textBox3.Text = soma.ToString();
				
		}
		void Button2Click(object sender, EventArgs e)
		{
	
			float sub1 = float.Parse(textBox2.Text);
			float sub2 = float.Parse(textBox1.Text);
			
			float sub = sub1 - sub2;
			
			textBox3.Text = sub.ToString();
		
		}
		void Button3Click(object sender, EventArgs e)
		{
	
			float div1 = float.Parse(textBox2.Text);
			float div2 = float.Parse(textBox1.Text);
			
			float div = div1 / div2;
			
			textBox3.Text = div.ToString();

		}
		void Button4Click(object sender, EventArgs e)
		{
	
			float mult1 = float.Parse(textBox2.Text);
			float mult2 = float.Parse(textBox1.Text);
			
			float mult = mult1 * mult2;
			
			textBox3.Text = mult.ToString();
			
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.DarkGray;
			
			textBox1.BackColor = Color.LightGray;
			textBox2.BackColor = Color.LightGray;
			textBox3.BackColor = Color.LightGray;
		
			button1.BackColor = Color.DarkGray;
			button2.BackColor = Color.DarkGray;
			button3.BackColor = Color.DarkGray;
			button4.BackColor = Color.DarkGray;
		
		}
		void Button6Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.AliceBlue;
			textBox1.BackColor = Color.LightSteelBlue;
			textBox2.BackColor = Color.LightSteelBlue;
			textBox3.BackColor = Color.LightSteelBlue;
			
			button1.BackColor = Color.AliceBlue;
			button2.BackColor = Color.AliceBlue;
			button3.BackColor = Color.AliceBlue;
			button4.BackColor = Color.AliceBlue;
			
		}
		void Button7Click(object sender, EventArgs e)
		{
			
			this.BackColor = Color.White;
			textBox1.BackColor = Color.White;
			textBox2.BackColor = Color.White;
			textBox3.BackColor = Color.White;
		
			button1.BackColor = Color.WhiteSmoke;
			button2.BackColor = Color.WhiteSmoke;
			button3.BackColor = Color.WhiteSmoke;
			button4.BackColor = Color.WhiteSmoke;
		}
		
		
	}
}
