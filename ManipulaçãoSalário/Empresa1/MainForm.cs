/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 22/06/2021
 * Time: 20:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Empresa1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		string[] nomes = new string[30];
		string[] cargos = new string[30];
		float[] salarios = new float[30];
		
		int cont = 0;
		string cargo ="";
		float salario = 0;
		
		
			void Button1Click(object sender, EventArgs e)
		{
	
				cargo ="";
				salario = 0;
				
				salario = float.Parse(textBox2.Text);
				cargo = textBox1.Text;
				
				
				if(cargo == "Gerente" || cargo == "gerente"){
					
					salario = (float)((salario * 0.1) + (salario));
					salarios[cont] = salario;
				
				}else if(cargo == "Engenheiro" || cargo == "engenheiro"){
					
					salario = (float)((salario * 0.2) + (salario));
					salarios[cont] = salario;
				
				
				}else if(cargo == "Técnico" || cargo == "técnico"){
					
					salario = (float)((salario * 0.3) + (salario));
					salarios[cont] = salario;
									
				}else{
					
					salario = (float)((salario * 0.4) + (salario));
					salarios[cont] = salario;
					

				}
						
				cargos[cont] = textBox1.Text;		
				nomes[cont] = textBox3.Text;

				cont++;
				
				textBox1.Clear();
				textBox2.Clear();
				textBox3.Clear();
				
				listBox1.Items.Clear();
		
			}
		void Button2Click(object sender, EventArgs e)
		{
		
			listBox1.Items.Clear();
			
			for(int i = 0; i<cont; i++){
				
					
				listBox1.Items.Add(nomes[i]);
				listBox1.Items.Add(cargos[i]);
				listBox1.Items.Add(salarios[i]);
				listBox1.Items.Add("");
				
	
				
			}
			
			
			
			
			
			
			
			
			
		}
	
	
	
	
	
	
	
	
	
	
	
	
	}
}
