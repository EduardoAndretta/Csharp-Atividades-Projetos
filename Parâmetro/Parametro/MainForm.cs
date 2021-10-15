/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 26/05/2021
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Parametro
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
	
			
			float num = float.Parse (textBox1.Text);
			
			if((num >= 30 && num <= 80) || (num > 200)){
				
				
				MessageBox.Show("Número Válido");
				
					
			}else{
				
				
				MessageBox.Show("Número Inválido");
				
			
			}
			
			
		}
	}
}
