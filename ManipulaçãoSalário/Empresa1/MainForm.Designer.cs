/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 22/06/2021
 * Time: 20:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Empresa1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(33, 125);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(244, 26);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(33, 211);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(244, 26);
			this.textBox2.TabIndex = 1;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(329, 81);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(277, 484);
			this.listBox1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(57, 353);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Cargo";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 33);
			this.label2.TabIndex = 5;
			this.label2.Text = "Salário";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(329, 571);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(277, 32);
			this.button2.TabIndex = 6;
			this.button2.Text = "Exibir";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 33);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nome";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(33, 302);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(244, 26);
			this.textBox3.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(573, 33);
			this.label4.TabIndex = 9;
			this.label4.Text = "Cálculo e Aumento de Salário";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 649);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Empresa1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
