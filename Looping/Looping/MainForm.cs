/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 02/06/2021
 * Time: 20:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Looping
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
	
			for (int cont = 0; cont <= 40; cont++)
			{
				
				listBox1.Items.Add("Oyasumi");
				listBox1.Items.Add("José");
				listBox1.Items.Add("Boa noite aluno "+ cont);
				
			}
			
			
		}
	}
}
