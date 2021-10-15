/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 23/06/2021
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Empresa4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(34, 173);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(554, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Analisar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(34, 127);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(156, 26);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(229, 127);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(156, 26);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(432, 127);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(156, 26);
			this.textBox3.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 31);
			this.label1.TabIndex = 4;
			this.label1.Text = "Primeiro";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(229, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 31);
			this.label2.TabIndex = 5;
			this.label2.Text = "Segundo";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(432, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 31);
			this.label3.TabIndex = 6;
			this.label3.Text = "Terceiro";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 31);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lados Triângulo";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(34, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(209, 56);
			this.panel1.TabIndex = 8;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(178, 276);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(272, 26);
			this.textBox4.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(178, 318);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(271, 227);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 574);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Empresa4";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
