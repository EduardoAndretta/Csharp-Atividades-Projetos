/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 26/05/2021
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Informando_Numeros
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
	
			
			int num = int.Parse(textBox1.Text);
			
			switch (num) {
				
				case 0:
					textBox2.Text = "Zero";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 1:
					textBox2.Text = "Um";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 2:
					textBox2.Text = "Dois";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 3:
					textBox2.Text = "Três";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 4:
					textBox2.Text = "Quatro";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 5:
					textBox2.Text = "Cinco";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 6:
					textBox2.Text = "Seis";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 7:
					textBox2.Text = "Sete";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 8:
					textBox2.Text = "Oito";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				case 9:
					textBox2.Text = "Nove";
					label2.Text = "(" + num + ") Por Extenso:";
					break;
				
				default:
					MessageBox.Show("Digite um Número Válido");
					break;
			}

			}
			
		}
	}

