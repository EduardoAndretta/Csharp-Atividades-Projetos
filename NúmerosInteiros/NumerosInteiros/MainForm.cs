/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 26/05/2021
 * Time: 19:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NumerosInteiros
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
	
			int a = int.Parse(textBox1.Text);
			int b = int.Parse(textBox2.Text);
			int c = int.Parse(textBox3.Text);
			
			if(a>b && c<b){
				
				textBox4.Text = "Primeiro " +a;
				textBox5.Text = "Segundo " +b;
				textBox6.Text = "Terceiro " +c;
				
					
					
			}if(b>a && c>b){
				
				textBox4.Text = "Primeiro " +c;
				textBox5.Text = "Segundo " +b;
				textBox6.Text = "Terceiro " +a;
				
				
				
				
			}if(c>a && b<a){
				
				textBox4.Text = "Primeiro " +c;
				textBox5.Text = "Segundo " +a;
				textBox6.Text = "Terceiro " +b;
				
				
				
			}if(b>c && c<a){
				
				textBox4.Text = "Primeiro " +b;
				textBox5.Text = "Segundo " +a;
				textBox6.Text = "Terceiro " +c;
				
				
				
			}if(b>c && a<c){
				
				textBox4.Text = "Primeiro " +b;
				textBox5.Text = "Segundo " +c;
				textBox6.Text = "Terceiro " +a;
				
				
			}if(a>b && b<c){
				
				textBox4.Text = "Primeiro " +a;
				textBox5.Text = "Segundo " +c;
				textBox6.Text = "Terceiro " +b;
				
				
				
			}if(a==b && b>c){
				
				textBox4.Text = "Primeiro " +a;
				textBox5.Text = "Segundo " +b;
				textBox6.Text = "Terceiro " +c;
				
			
			}if(a==c && b<c){
				
				textBox4.Text = "Primeiro " +a;
				textBox5.Text = "Segundo " +c;
				textBox6.Text = "Terceiro " +b;
				
		
			}if(a==b && b<c){
				
				textBox4.Text = "Primeiro " +c;
				textBox5.Text = "Segundo " +b;
				textBox6.Text = "Terceiro " +a;
		
			
			}if(a==c && b>c){
				
				textBox4.Text = "Primeiro " +b;
				textBox5.Text = "Segundo " +c;
				textBox6.Text = "Terceiro " +a;
		
			
			}if(b==c && a>c){
				
				textBox4.Text = "Primeiro " +a;
				textBox5.Text = "Segundo " +c;
				textBox6.Text = "Terceiro " +b;
			
			
			}if(b==c && a<c){
				
				textBox4.Text = "Primeiro " +b;
				textBox5.Text = "Segundo " +c;
				textBox6.Text = "Terceiro " +a;
			
			
			}if(a==c && b==c){
				
				textBox4.Text = "Primeiro " +a;
				textBox5.Text = "Segundo " +c;
				textBox6.Text = "Terceiro " +b;
				
			}
			
			
			//Correção
			
			int maior, meio, menor, n;
			
			maior = int.Parse(textBox1.Text);
			
			n     = int.Parse(textBox2.Text);
			
			if (n > maior)
			{
			   meio = maior;
			   maior = n;
			}
			else 
			{
			   meio = n;
			}
			
			n = int.Parse(textBox3.Text);
			
			if (n > maior)
			{
			   menor = meio;
			   meio = maior;
			   maior = n;
			}
			else if (n > meio)
			{
			  menor = meio;
			  meio = n;
			}
			else
			{
			  menor = n;
			}
			
			textBox4.Text = "Primeiro " +menor;
			textBox5.Text = "Segundo " +meio;
			textBox6.Text = "Terceiro " +maior;
			
			
			
			//listBox1.Clear();
			
			//listBox1.Items.Add(menor);
			//listBox1.Items.Add(meio);
			//listBox1.Items.Add(maior);
		
			//Correção 2.0
			
			maior = int.Parse(textBox1.Text);
			meio  = int.Parse(textBox2.Text);
			
			
			
			if (meio > maior)
			{
				
				//Alogitmo de troca (swap)
				
				n = meio;
				meio = maior;
				maior = n;
				
			}	
			
			menor = int.Parse(textBox3.Text);
			
			if (menor > maior)
			{
				
				n = menor;
				menor = meio;
				meio = maior;
				maior = n;	
			}
			else if (menor > meio)
			{
				n = menor;
				menor = meio;
				meio = n;
			}
		
		}
	}
}
