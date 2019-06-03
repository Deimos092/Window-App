namespace Combo_Programs
{
	partial class InfoTxT
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoTxT));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.Btn_ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(293, 157);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseDown);
			this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseMove);
			this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseUp);
			// 
			// Btn_ok
			// 
			this.Btn_ok.FlatAppearance.BorderSize = 0;
			this.Btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
			this.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_ok.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Btn_ok.Location = new System.Drawing.Point(12, 175);
			this.Btn_ok.Name = "Btn_ok";
			this.Btn_ok.Size = new System.Drawing.Size(293, 32);
			this.Btn_ok.TabIndex = 1;
			this.Btn_ok.Text = "OK";
			this.Btn_ok.UseVisualStyleBackColor = true;
			this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
			// 
			// InfoTxT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(314, 217);
			this.Controls.Add(this.Btn_ok);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(333, 258);
			this.MinimumSize = new System.Drawing.Size(314, 217);
			this.Name = "InfoTxT";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "InfoTxT";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button Btn_ok;
	}
}