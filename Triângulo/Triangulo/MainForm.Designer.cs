/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 26/05/2021
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Triangulo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(172, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(197, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(205, 357);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Analisar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(232, 288);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(71, 26);
			this.textBox2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(232, 259);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Segundo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(92, 262);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Primeiro";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(371, 259);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Terceiro";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 288);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(71, 26);
			this.textBox1.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(371, 288);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(71, 26);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(188, 474);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(169, 26);
			this.textBox4.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(232, 436);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Resultado:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 651);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Triangulo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
