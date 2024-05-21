/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/20/2024
 * Time: 5:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace mouseDrawing
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox7;
		
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
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(42, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(290, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "0";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(42, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(290, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "0";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(42, 82);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(290, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "0";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(42, 108);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(290, 20);
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "0";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(42, 135);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(290, 459);
			this.listBox1.TabIndex = 4;
			this.listBox1.SelectedValueChanged += new System.EventHandler(this.ListBox1SelectedValueChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(42, 4);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 5;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(148, 4);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(184, 20);
			this.textBox6.TabIndex = 6;
			this.textBox6.Text = "SHAPE";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(339, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "SELECT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(339, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "MODIFY";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(406, 556);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(538, 20);
			this.textBox7.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 611);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "mouseDrawing";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
