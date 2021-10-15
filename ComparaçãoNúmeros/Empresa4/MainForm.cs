/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 23/06/2021
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Empresa4
{
	
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
            
            //Triângulo Equilátero
            
            if(a==b && c==b){
            	
            	textBox4.Text = "Triângulo Equilátero";
            	pictureBox1.Load("Equilatero.png");
            
            }
                
            //Triângulo Isosceles
            
            if(a==b && a!=c)
            {	
            	textBox4.Text = "Triângulo Isosceles";
            	pictureBox1.Load("Isosceles.png");
            }
            if(a==c && a!=b)
            {
            	textBox4.Text = "Triângulo Isosceles";
            	pictureBox1.Load("Isosceles.png");
            }

            if(b==a && b!=c)
            {
            	textBox4.Text = "Triângulo Isosceles";
            	pictureBox1.Load("Isosceles.png");
            }
            if(b==c && b!=a)
            {
            	textBox4.Text = "Triângulo Isosceles";
            	pictureBox1.Load("Isosceles.png");
            }

            if(c==b && c!=a)
            {
            	textBox4.Text = "Triângulo Isosceles";
            	pictureBox1.Load("Isosceles.png");
            }
            if(c==a && c!=b)
            {
            	textBox4.Text = "Triângulo Isosceles";
            	pictureBox1.Load("Isosceles.png");
            	
            }

            //Trângulo Escaleno
            
            if(a!=c && c!=b)
            {
            	textBox4.Text = "Trângulo Escaleno";
            	pictureBox1.Load("Escaleno.png");
            	
            }
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
		
		}
        
    }
}

	
	
	
	
	
	