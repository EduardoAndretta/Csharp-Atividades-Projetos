/*
 * Created by SharpDevelop.
 * User: Eduardo Andretta
 * Date: 17/05/2021
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Exemplo3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		
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
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(50, 31);
			this.button1.MaximumSize = new System.Drawing.Size(250, 250);
			this.button1.MinimumSize = new System.Drawing.Size(150, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 163);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(50, 255);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(250, 93);
			this.button3.TabIndex = 2;
			this.button3.Text = "JOGAR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(385, 278);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 85);
			this.label1.TabIndex = 7;
			this.label1.Text = "_________";
			// 
			// button2
			// 
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(250, 31);
			this.button2.MaximumSize = new System.Drawing.Size(250, 250);
			this.button2.MinimumSize = new System.Drawing.Size(150, 150);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 163);
			this.button2.TabIndex = 8;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.Location = new System.Drawing.Point(451, 31);
			this.button4.MaximumSize = new System.Drawing.Size(250, 250);
			this.button4.MinimumSize = new System.Drawing.Size(150, 150);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(150, 163);
			this.button4.TabIndex = 9;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.Location = new System.Drawing.Point(653, 31);
			this.button5.MaximumSize = new System.Drawing.Size(250, 250);
			this.button5.MinimumSize = new System.Drawing.Size(150, 150);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(150, 163);
			this.button5.TabIndex = 10;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button6.Location = new System.Drawing.Point(855, 31);
			this.button6.MaximumSize = new System.Drawing.Size(250, 250);
			this.button6.MinimumSize = new System.Drawing.Size(150, 150);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(150, 163);
			this.button6.TabIndex = 11;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(57, 403);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(947, 279);
			this.panel1.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.ForestGreen;
			this.ClientSize = new System.Drawing.Size(1063, 733);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Exemplo3";
			this.ResumeLayout(false);

		}
	}
}
