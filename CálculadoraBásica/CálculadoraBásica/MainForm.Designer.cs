/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 12/05/2021
 * Time: 18:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CálculadoraBásica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(107, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Primeiro Número";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(283, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Segundo Número";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(125, 132);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(116, 26);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(297, 132);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(116, 26);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(220, 426);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 26);
			this.textBox3.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(225, 400);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Resultado";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(125, 221);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 45);
			this.button1.TabIndex = 6;
			this.button1.Text = "Soma";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(297, 221);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 46);
			this.button2.TabIndex = 7;
			this.button2.Text = "Subtração";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(125, 286);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 45);
			this.button3.TabIndex = 8;
			this.button3.Text = "Divisão";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(297, 286);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(116, 46);
			this.button4.TabIndex = 9;
			this.button4.Text = "Multiplicação";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button5.Location = new System.Drawing.Point(22, 27);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(28, 28);
			this.button5.TabIndex = 10;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.AliceBlue;
			this.button6.Location = new System.Drawing.Point(56, 27);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(28, 28);
			this.button6.TabIndex = 11;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(90, 27);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(28, 28);
			this.button7.TabIndex = 12;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 528);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CálculadoraBásica";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
