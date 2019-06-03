namespace Combo_Programs
{
	partial class Alert_info
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
			if ( disposing && ( components != null ) )
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
			this.lb_time = new System.Windows.Forms.Label();
			this.lb_message = new System.Windows.Forms.Label();
			this.btn_OK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_time
			// 
			this.lb_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lb_time.AutoSize = true;
			this.lb_time.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
			this.lb_time.Location = new System.Drawing.Point(116, 9);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(64, 29);
			this.lb_time.TabIndex = 0;
			this.lb_time.Text = "00:00";
			this.lb_time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lb_message
			// 
			this.lb_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_message.ForeColor = System.Drawing.Color.Red;
			this.lb_message.Location = new System.Drawing.Point(12, 65);
			this.lb_message.Name = "lb_message";
			this.lb_message.Size = new System.Drawing.Size(260, 57);
			this.lb_message.TabIndex = 1;
			this.lb_message.Text = "Ваше сообщение";
			this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_OK
			// 
			this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OK.Location = new System.Drawing.Point(12, 125);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(260, 23);
			this.btn_OK.TabIndex = 2;
			this.btn_OK.Text = "OK";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// Alert_info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(284, 160);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.lb_message);
			this.Controls.Add(this.lb_time);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Alert_info";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alert_info";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_F_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_F_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_F_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button btn_OK;
		public System.Windows.Forms.Label lb_time;
		public System.Windows.Forms.Label lb_message;
	}
}