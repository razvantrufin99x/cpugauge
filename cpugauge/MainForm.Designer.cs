/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/16/2020
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cpugauge
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(23, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 101);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(52, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(52, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(227, 165);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "cpugauge";
			this.TransparencyKey = System.Drawing.Color.White;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.ResumeLayout(false);

		}
	}
}
