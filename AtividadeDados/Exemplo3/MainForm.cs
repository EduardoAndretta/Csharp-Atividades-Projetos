/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 17/05/2021
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exemplo3
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
		
		//Random  rnd = new Random();
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			
			//int n = rnd.Next(1,7);     //Gera números entre 1 e 6
			
			
			//if (n % 2 != 0)  //O % resulta no resto da divisão
			//{
			//	
			//	button1.ForeColor = Color.Blue;
			//	
			//}
			//if(n==2 || n==4 || n==6)
			//{	
			//	
			//	button1.ForeColor = Color.DarkOrange;
			//	
		    //}
		    
		    //button1.BackgroundImage = Image.FromFile("" +n+ ".png");
		    
		    
		    
		    
		}
		
		Random  rnd = new Random();
		
		
		void Button3Click(object sender, EventArgs e)
		{
		
			int n1 = rnd.Next(1,7);
			
			button1.BackgroundImage = Image.FromFile(n1+ ".png");
			
			int n2 = rnd.Next(1,7);
			
			button2.BackgroundImage = Image.FromFile(n2+ ".png");
			
			int n3 = rnd.Next(1,7);
			
			button4.BackgroundImage = Image.FromFile(n3+ ".png");
			
			int n4 = rnd.Next(1,7);
			
			button5.BackgroundImage = Image.FromFile(n4+ ".png");
			
			int n5 = rnd.Next(1,7);
			
			button6.BackgroundImage = Image.FromFile(n5+ ".png");
			
			//Quina
			
			if(n1==n2 && n1==n3 && n1==n4 && n1==n5){ label1.Text = "Quina"; }
			else{ label1.Text = "_________"; }
			 
			//Quadra
			
			if(n1==n2 && n3==n4 && n1==n3 && n5!=n1){ label1.Text = "Quadra"; } 
			if(n1==n2 && n3==n5 && n1==n5 && n4!=n1){ label1.Text = "Quadra"; }  
			if(n1==n2 && n5==n4 && n1==n4 && n3!=n1){ label1.Text = "Quadra"; } 
			if(n1==n5 && n3==n4 && n1==n3 && n2!=n1){ label1.Text = "Quadra"; }
			if(n2==n3 && n4==n5 && n2==n4 && n1!=n2){ label1.Text = "Quadra"; }

			//Trinca
		
			if(n1==n2 && n1==n3 && n5!=n1 && n4!=n1){ label1.Text = "Trinca"; }
			if(n1==n3 && n1==n4 && n2!=n1 && n5!=n1){ label1.Text = "Trinca"; }
			if(n1==n4 && n1==n5 && n2!=n1 && n3!=n1){ label1.Text = "Trinca"; }
			
			if(n2==n3 && n2==n4 && n5!=n2 && n1!=n2){ label1.Text = "Trinca"; }
			if(n2==n4 && n2==n5 && n3!=n2 && n1!=n2){ label1.Text = "Trinca"; }
			if(n2==n5 && n2==n1 && n4!=n2 && n3!=n2){ label1.Text = "Trinca"; }
			
			if(n3==n4 && n3==n5 && n2!=n3 && n1!=n3){ label1.Text = "Trinca"; }
			if(n3==n5 && n3==n1 && n2!=n3 && n4!=n3){ label1.Text = "Trinca"; }
			if(n3==n1 && n3==n2 && n5!=n3 && n4!=n3){ label1.Text = "Trinca"; }
			
			if(n4==n5 && n4==n1 && n2!=n4 && n3!=n4){ label1.Text = "Trinca"; }
			if(n4==n1 && n4==n2 && n3!=n4 && n5!=n4){ label1.Text = "Trinca"; }
			if(n4==n2 && n4==n3 && n5!=n4 && n1!=n4){ label1.Text = "Trinca"; }
			
			if(n5==n1 && n5==n2 && n4!=n5 && n3!=n5){ label1.Text = "Trinca"; }
			if(n5==n2 && n5==n3 && n4!=n5 && n1!=n5){ label1.Text = "Trinca"; }
			if(n5==n3 && n5==n4 && n2!=n5 && n1!=n5){ label1.Text = "Trinca"; }
			
			if(n1==n2 && n1==n3 && n5!=n1 && n4!=n1){ label1.Text = "Trinca"; }
			if(n1==n3 && n1==n4 && n2!=n1 && n5!=n1){ label1.Text = "Trinca"; }
			if(n1==n4 && n1==n5 && n2!=n1 && n3!=n1){ label1.Text = "Trinca"; }
			
			
		
		
		
		}
		

		
			// if (n1==n2 && n1==n3 && n1==n4 && n1==n5){ label1.Text = "Quina"; 
			//
	        //}	else if((n1==n2 && n3==n4 && n1==n3) ||
			//			(n1==n2 && n3==n5 && n1==n5) ||  
			//			(n1==n2 && n5==n4 && n1==n4) ||
			//			(n1==n5 && n3==n4 && n1==n3) ||
			//			(n2==n3 && n4==n5 && n2==n4) ) { 
			//
			//
			//label1.Text = "Quadra"; 
			//
			//}else  if((n1==n2 && n1==n3 && n5!=n1 && n4!=n1){ label1.Text = "Trinca"; }
			//		    (n1==n3 && n1==n4) ||
			//		    (n1==n4 && n1==n5) ||
			//		    (n2==n3 && n2==n4) ||
			//		    (n2==n4 && n2==n5) ||
			//		    (n2==n5 && n2==n1) ||
			//		    (n3==n4 && n3==n5) ||
			//		    (n3==n5 && n3==n1) ||
			//		    (n3==n1 && n3==n2) ||
			//		    (n4==n5 && n4==n1) ||
			//		    (n4==n1 && n4==n2) ||
			//		    (n4==n2 && n4==n3) ||
			//		    (n5==n1 && n5==n2) ||
			//		    (n5==n2 && n5==n3) ||
			//		    (n5==n3 && n5==n4)){
			//		    	
			//		    	label1.Text = "Trinca";
			//		    }
			//	}else{
			//
			//		label1.Text = "_________";
			//
			//		}
			
			

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	}

}
