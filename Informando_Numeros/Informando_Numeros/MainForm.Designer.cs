﻿/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 26/05/2021
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Informando_Numeros
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(46, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(201, 47);
			this.button1.TabIndex = 0;
			this.button1.Text = "Informar por Extenso";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(46, 142);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(201, 26);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(46, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Número:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(46, 312);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(201, 26);
			this.textBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(46, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Por Extenso:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(46, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 46);
			this.label3.TabIndex = 5;
			this.label3.Text = "Digite um Número de um Digito";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 403);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Informando_Numeros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
