/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 15/05/2021
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dados
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
		
		
		
		
		
		
		
		Random rnd = new Random();
		
		void Button10Click(object sender, EventArgs e)
		{
	
			int n = rnd.Next(1,7);
			button10.Text = n.ToString();
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			this.BackColor = Color.White;
			button10.BackColor = Color.WhiteSmoke;
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			this.BackColor = Color.Green;
			button10.BackColor = Color.WhiteSmoke;
		
		}
		void Button3Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.Red;
			button10.BackColor = Color.WhiteSmoke;
			
		}
		void Button4Click(object sender, EventArgs e)
		{
		
			this.BackColor = Color.Blue;
			button10.BackColor = Color.WhiteSmoke;
		
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.Yellow;
			button10.BackColor = Color.WhiteSmoke;
		
		}
		void Button6Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.Pink;
			button10.BackColor = Color.WhiteSmoke;
			
		}
		void Button7Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.AliceBlue;
			button10.BackColor = Color.WhiteSmoke;
			
		}
		void Button8Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.Gray;
			button10.BackColor = Color.WhiteSmoke;
			
		}
		void Button9Click(object sender, EventArgs e)
		{
	
			this.BackColor = Color.Cyan;
			button10.BackColor = Color.WhiteSmoke;	
			
		}
	}
}
