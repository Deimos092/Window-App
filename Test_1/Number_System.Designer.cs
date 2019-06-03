namespace Combo_Programs
{
	partial class Number_System
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
			this.Btn_OK = new System.Windows.Forms.Button();
			this.TB_A = new System.Windows.Forms.TextBox();
			this.TB_SYS_A = new System.Windows.Forms.TextBox();
			this.TB_B = new System.Windows.Forms.TextBox();
			this.TB_SYS_B = new System.Windows.Forms.TextBox();
			this.LB_A = new System.Windows.Forms.Label();
			this.LB_SYS_A = new System.Windows.Forms.Label();
			this.LB_B = new System.Windows.Forms.Label();
			this.LB_SYS_B = new System.Windows.Forms.Label();
			this.TB_Result = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TB_SYS_RES = new System.Windows.Forms.TextBox();
			this.lb_resCode = new System.Windows.Forms.Label();
			this.chkb_Operation = new System.Windows.Forms.CheckBox();
			this.GB_Operators = new System.Windows.Forms.GroupBox();
			this.Btn_div = new System.Windows.Forms.Button();
			this.Btn_minus = new System.Windows.Forms.Button();
			this.Btn_plus = new System.Windows.Forms.Button();
			this.Btn_multy = new System.Windows.Forms.Button();
			this.Btn_close = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.chkb_NumRep = new System.Windows.Forms.CheckBox();
			this.chkb_ReversCode = new System.Windows.Forms.CheckBox();
			this.lb_sign_A = new System.Windows.Forms.Label();
			this.lb_sign_B = new System.Windows.Forms.Label();
			this.TB_prom_a = new System.Windows.Forms.TextBox();
			this.TB_prom_b = new System.Windows.Forms.TextBox();
			this.lb_prom = new System.Windows.Forms.Label();
			this.lb_prom_a = new System.Windows.Forms.Label();
			this.lb_prom_B = new System.Windows.Forms.Label();
			this.lb_Operate = new System.Windows.Forms.Label();
			this.lb_OverFloat = new System.Windows.Forms.Label();
			this.GB_Operators.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_OK
			// 
			this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.Btn_OK.FlatAppearance.BorderSize = 0;
			this.Btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
			this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_OK.ForeColor = System.Drawing.Color.Lime;
			this.Btn_OK.Location = new System.Drawing.Point(16, 240);
			this.Btn_OK.Name = "Btn_OK";
			this.Btn_OK.Size = new System.Drawing.Size(318, 32);
			this.Btn_OK.TabIndex = 8;
			this.Btn_OK.Text = "&OK";
			this.Btn_OK.UseVisualStyleBackColor = false;
			this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
			// 
			// TB_A
			// 
			this.TB_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.TB_A.Location = new System.Drawing.Point(16, 25);
			this.TB_A.MaxLength = 15;
			this.TB_A.Name = "TB_A";
			this.TB_A.Size = new System.Drawing.Size(244, 15);
			this.TB_A.TabIndex = 0;
			this.TB_A.TextChanged += new System.EventHandler(this.TB_A_TextChanged);
			this.TB_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Key_A_Down);
			this.TB_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
			// 
			// TB_SYS_A
			// 
			this.TB_SYS_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_SYS_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_SYS_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_SYS_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_SYS_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.TB_SYS_A.Location = new System.Drawing.Point(265, 25);
			this.TB_SYS_A.MaxLength = 2;
			this.TB_SYS_A.Name = "TB_SYS_A";
			this.TB_SYS_A.Size = new System.Drawing.Size(69, 15);
			this.TB_SYS_A.TabIndex = 1;
			this.TB_SYS_A.TextChanged += new System.EventHandler(this.TB_SYS_A_TextChanged);
			this.TB_SYS_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Sys_KeyPress);
			// 
			// TB_B
			// 
			this.TB_B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_B.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_B.Enabled = false;
			this.TB_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.TB_B.Location = new System.Drawing.Point(16, 68);
			this.TB_B.MaxLength = 15;
			this.TB_B.Name = "TB_B";
			this.TB_B.Size = new System.Drawing.Size(244, 15);
			this.TB_B.TabIndex = 4;
			this.TB_B.TextChanged += new System.EventHandler(this.TB_B_TextChanged);
			this.TB_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Key_B_Down);
			this.TB_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
			// 
			// TB_SYS_B
			// 
			this.TB_SYS_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_SYS_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_SYS_B.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_SYS_B.Enabled = false;
			this.TB_SYS_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_SYS_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.TB_SYS_B.Location = new System.Drawing.Point(265, 68);
			this.TB_SYS_B.MaxLength = 2;
			this.TB_SYS_B.Name = "TB_SYS_B";
			this.TB_SYS_B.Size = new System.Drawing.Size(69, 15);
			this.TB_SYS_B.TabIndex = 5;
			this.TB_SYS_B.TextChanged += new System.EventHandler(this.TB_SYS_B_TextChanged);
			this.TB_SYS_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Sys_KeyPress);
			// 
			// LB_A
			// 
			this.LB_A.AutoSize = true;
			this.LB_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LB_A.Location = new System.Drawing.Point(13, 9);
			this.LB_A.Name = "LB_A";
			this.LB_A.Size = new System.Drawing.Size(49, 13);
			this.LB_A.TabIndex = 10;
			this.LB_A.Text = "Число А";
			// 
			// LB_SYS_A
			// 
			this.LB_SYS_A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LB_SYS_A.AutoSize = true;
			this.LB_SYS_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LB_SYS_A.Location = new System.Drawing.Point(262, 9);
			this.LB_SYS_A.Name = "LB_SYS_A";
			this.LB_SYS_A.Size = new System.Drawing.Size(72, 13);
			this.LB_SYS_A.TabIndex = 11;
			this.LB_SYS_A.Text = "Кодировка A";
			// 
			// LB_B
			// 
			this.LB_B.AutoSize = true;
			this.LB_B.Enabled = false;
			this.LB_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LB_B.Location = new System.Drawing.Point(13, 52);
			this.LB_B.Name = "LB_B";
			this.LB_B.Size = new System.Drawing.Size(49, 13);
			this.LB_B.TabIndex = 12;
			this.LB_B.Text = "Число B";
			// 
			// LB_SYS_B
			// 
			this.LB_SYS_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LB_SYS_B.AutoSize = true;
			this.LB_SYS_B.Enabled = false;
			this.LB_SYS_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LB_SYS_B.Location = new System.Drawing.Point(262, 52);
			this.LB_SYS_B.Name = "LB_SYS_B";
			this.LB_SYS_B.Size = new System.Drawing.Size(72, 13);
			this.LB_SYS_B.TabIndex = 13;
			this.LB_SYS_B.Text = "Кодировка B";
			// 
			// TB_Result
			// 
			this.TB_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_Result.ForeColor = System.Drawing.Color.Lime;
			this.TB_Result.Location = new System.Drawing.Point(16, 218);
			this.TB_Result.Name = "TB_Result";
			this.TB_Result.ReadOnly = true;
			this.TB_Result.Size = new System.Drawing.Size(243, 15);
			this.TB_Result.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.label5.Location = new System.Drawing.Point(13, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Результат";
			// 
			// TB_SYS_RES
			// 
			this.TB_SYS_RES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_SYS_RES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_SYS_RES.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_SYS_RES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_SYS_RES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.TB_SYS_RES.Location = new System.Drawing.Point(265, 219);
			this.TB_SYS_RES.MaxLength = 2;
			this.TB_SYS_RES.Name = "TB_SYS_RES";
			this.TB_SYS_RES.Size = new System.Drawing.Size(69, 15);
			this.TB_SYS_RES.TabIndex = 7;
			this.TB_SYS_RES.Text = "10";
			this.TB_SYS_RES.TextChanged += new System.EventHandler(this.TB_SYS_RES_TextChanged);
			this.TB_SYS_RES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Sys_KeyPress);
			// 
			// lb_resCode
			// 
			this.lb_resCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_resCode.AutoSize = true;
			this.lb_resCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.lb_resCode.Location = new System.Drawing.Point(262, 203);
			this.lb_resCode.Name = "lb_resCode";
			this.lb_resCode.Size = new System.Drawing.Size(62, 13);
			this.lb_resCode.TabIndex = 15;
			this.lb_resCode.Text = "Кодировка";
			// 
			// chkb_Operation
			// 
			this.chkb_Operation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkb_Operation.AutoSize = true;
			this.chkb_Operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.chkb_Operation.Location = new System.Drawing.Point(341, 43);
			this.chkb_Operation.Name = "chkb_Operation";
			this.chkb_Operation.Size = new System.Drawing.Size(133, 17);
			this.chkb_Operation.TabIndex = 3;
			this.chkb_Operation.Text = "Выполнить операции";
			this.chkb_Operation.UseVisualStyleBackColor = true;
			this.chkb_Operation.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// GB_Operators
			// 
			this.GB_Operators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GB_Operators.Controls.Add(this.Btn_div);
			this.GB_Operators.Controls.Add(this.Btn_minus);
			this.GB_Operators.Controls.Add(this.Btn_plus);
			this.GB_Operators.Controls.Add(this.Btn_multy);
			this.GB_Operators.Enabled = false;
			this.GB_Operators.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GB_Operators.Location = new System.Drawing.Point(341, 58);
			this.GB_Operators.Name = "GB_Operators";
			this.GB_Operators.Size = new System.Drawing.Size(134, 138);
			this.GB_Operators.TabIndex = 6;
			this.GB_Operators.TabStop = false;
			// 
			// Btn_div
			// 
			this.Btn_div.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.Btn_div.FlatAppearance.BorderSize = 0;
			this.Btn_div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
			this.Btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_div.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Btn_div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Btn_div.Location = new System.Drawing.Point(67, 72);
			this.Btn_div.Name = "Btn_div";
			this.Btn_div.Size = new System.Drawing.Size(64, 63);
			this.Btn_div.TabIndex = 3;
			this.Btn_div.Text = "/";
			this.Btn_div.UseVisualStyleBackColor = false;
			this.Btn_div.Click += new System.EventHandler(this.Btn_div_Click);
			// 
			// Btn_minus
			// 
			this.Btn_minus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.Btn_minus.FlatAppearance.BorderSize = 0;
			this.Btn_minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
			this.Btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_minus.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Btn_minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Btn_minus.Location = new System.Drawing.Point(67, 8);
			this.Btn_minus.Name = "Btn_minus";
			this.Btn_minus.Size = new System.Drawing.Size(64, 63);
			this.Btn_minus.TabIndex = 1;
			this.Btn_minus.Text = "-";
			this.Btn_minus.UseVisualStyleBackColor = false;
			this.Btn_minus.Click += new System.EventHandler(this.Btn_minus_Click);
			// 
			// Btn_plus
			// 
			this.Btn_plus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.Btn_plus.FlatAppearance.BorderSize = 0;
			this.Btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
			this.Btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_plus.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Btn_plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Btn_plus.Location = new System.Drawing.Point(2, 8);
			this.Btn_plus.Name = "Btn_plus";
			this.Btn_plus.Size = new System.Drawing.Size(64, 63);
			this.Btn_plus.TabIndex = 0;
			this.Btn_plus.Text = "+";
			this.Btn_plus.UseVisualStyleBackColor = false;
			this.Btn_plus.Click += new System.EventHandler(this.Btn_plus_Click);
			// 
			// Btn_multy
			// 
			this.Btn_multy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_multy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.Btn_multy.FlatAppearance.BorderSize = 0;
			this.Btn_multy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
			this.Btn_multy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_multy.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Btn_multy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Btn_multy.Location = new System.Drawing.Point(2, 72);
			this.Btn_multy.Name = "Btn_multy";
			this.Btn_multy.Size = new System.Drawing.Size(64, 63);
			this.Btn_multy.TabIndex = 2;
			this.Btn_multy.Text = "*";
			this.Btn_multy.UseVisualStyleBackColor = false;
			this.Btn_multy.Click += new System.EventHandler(this.Btn_multy_Click);
			// 
			// Btn_close
			// 
			this.Btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.Btn_close.FlatAppearance.BorderSize = 0;
			this.Btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Btn_close.Location = new System.Drawing.Point(341, 240);
			this.Btn_close.Name = "Btn_close";
			this.Btn_close.Size = new System.Drawing.Size(133, 32);
			this.Btn_close.TabIndex = 9;
			this.Btn_close.Text = "Закрыть";
			this.Btn_close.UseVisualStyleBackColor = false;
			this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.btn_clear.FlatAppearance.BorderSize = 0;
			this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.btn_clear.Location = new System.Drawing.Point(341, 202);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(133, 32);
			this.btn_clear.TabIndex = 20;
			this.btn_clear.Text = "Очистить";
			this.btn_clear.UseVisualStyleBackColor = false;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// chkb_NumRep
			// 
			this.chkb_NumRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkb_NumRep.AutoSize = true;
			this.chkb_NumRep.Location = new System.Drawing.Point(341, 4);
			this.chkb_NumRep.Name = "chkb_NumRep";
			this.chkb_NumRep.Size = new System.Drawing.Size(137, 17);
			this.chkb_NumRep.TabIndex = 21;
			this.chkb_NumRep.Text = "Представление чисел";
			this.chkb_NumRep.UseVisualStyleBackColor = true;
			this.chkb_NumRep.CheckedChanged += new System.EventHandler(this.chkb_NumRep_CheckedChanged);
			// 
			// chkb_ReversCode
			// 
			this.chkb_ReversCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkb_ReversCode.AutoSize = true;
			this.chkb_ReversCode.Location = new System.Drawing.Point(341, 23);
			this.chkb_ReversCode.Name = "chkb_ReversCode";
			this.chkb_ReversCode.Size = new System.Drawing.Size(98, 17);
			this.chkb_ReversCode.TabIndex = 24;
			this.chkb_ReversCode.Text = "Обратный код";
			this.chkb_ReversCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkb_ReversCode.UseVisualStyleBackColor = true;
			this.chkb_ReversCode.Visible = false;
			// 
			// lb_sign_A
			// 
			this.lb_sign_A.AutoSize = true;
			this.lb_sign_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_sign_A.ForeColor = System.Drawing.Color.Lime;
			this.lb_sign_A.Location = new System.Drawing.Point(4, 24);
			this.lb_sign_A.Name = "lb_sign_A";
			this.lb_sign_A.Size = new System.Drawing.Size(12, 15);
			this.lb_sign_A.TabIndex = 25;
			this.lb_sign_A.Text = "-";
			this.lb_sign_A.Visible = false;
			// 
			// lb_sign_B
			// 
			this.lb_sign_B.AutoSize = true;
			this.lb_sign_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_sign_B.ForeColor = System.Drawing.Color.Lime;
			this.lb_sign_B.Location = new System.Drawing.Point(4, 66);
			this.lb_sign_B.Name = "lb_sign_B";
			this.lb_sign_B.Size = new System.Drawing.Size(12, 15);
			this.lb_sign_B.TabIndex = 26;
			this.lb_sign_B.Text = "-";
			this.lb_sign_B.Visible = false;
			// 
			// TB_prom_a
			// 
			this.TB_prom_a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_prom_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_prom_a.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_prom_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_prom_a.ForeColor = System.Drawing.Color.Yellow;
			this.TB_prom_a.Location = new System.Drawing.Point(16, 133);
			this.TB_prom_a.MaxLength = 16;
			this.TB_prom_a.Name = "TB_prom_a";
			this.TB_prom_a.ReadOnly = true;
			this.TB_prom_a.Size = new System.Drawing.Size(150, 15);
			this.TB_prom_a.TabIndex = 27;
			this.TB_prom_a.Visible = false;
			// 
			// TB_prom_b
			// 
			this.TB_prom_b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_prom_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.TB_prom_b.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TB_prom_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TB_prom_b.ForeColor = System.Drawing.Color.Yellow;
			this.TB_prom_b.Location = new System.Drawing.Point(184, 133);
			this.TB_prom_b.Name = "TB_prom_b";
			this.TB_prom_b.ReadOnly = true;
			this.TB_prom_b.Size = new System.Drawing.Size(150, 15);
			this.TB_prom_b.TabIndex = 28;
			this.TB_prom_b.Visible = false;
			// 
			// lb_prom
			// 
			this.lb_prom.AutoSize = true;
			this.lb_prom.Location = new System.Drawing.Point(13, 97);
			this.lb_prom.Name = "lb_prom";
			this.lb_prom.Size = new System.Drawing.Size(144, 13);
			this.lb_prom.TabIndex = 29;
			this.lb_prom.Text = "Промежуточный результат";
			this.lb_prom.Visible = false;
			// 
			// lb_prom_a
			// 
			this.lb_prom_a.BackColor = System.Drawing.Color.Transparent;
			this.lb_prom_a.ForeColor = System.Drawing.Color.Yellow;
			this.lb_prom_a.Location = new System.Drawing.Point(13, 113);
			this.lb_prom_a.Name = "lb_prom_a";
			this.lb_prom_a.Size = new System.Drawing.Size(15, 17);
			this.lb_prom_a.TabIndex = 30;
			this.lb_prom_a.Text = "A";
			this.lb_prom_a.Visible = false;
			// 
			// lb_prom_B
			// 
			this.lb_prom_B.BackColor = System.Drawing.Color.Transparent;
			this.lb_prom_B.ForeColor = System.Drawing.Color.Yellow;
			this.lb_prom_B.Location = new System.Drawing.Point(181, 112);
			this.lb_prom_B.Name = "lb_prom_B";
			this.lb_prom_B.Size = new System.Drawing.Size(15, 18);
			this.lb_prom_B.TabIndex = 31;
			this.lb_prom_B.Text = "B";
			this.lb_prom_B.Visible = false;
			// 
			// lb_Operate
			// 
			this.lb_Operate.AutoSize = true;
			this.lb_Operate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.lb_Operate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.lb_Operate.Location = new System.Drawing.Point(300, 96);
			this.lb_Operate.Name = "lb_Operate";
			this.lb_Operate.Size = new System.Drawing.Size(0, 25);
			this.lb_Operate.TabIndex = 32;
			// 
			// lb_OverFloat
			// 
			this.lb_OverFloat.AutoSize = true;
			this.lb_OverFloat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(55)))), ((int)(((byte)(27)))));
			this.lb_OverFloat.ForeColor = System.Drawing.Color.Lime;
			this.lb_OverFloat.Location = new System.Drawing.Point(158, 200);
			this.lb_OverFloat.Name = "lb_OverFloat";
			this.lb_OverFloat.Size = new System.Drawing.Size(101, 13);
			this.lb_OverFloat.TabIndex = 33;
			this.lb_OverFloat.Text = "Нет переполнения";
			this.lb_OverFloat.Visible = false;
			// 
			// Number_System
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(486, 284);
			this.Controls.Add(this.lb_OverFloat);
			this.Controls.Add(this.lb_Operate);
			this.Controls.Add(this.lb_prom_B);
			this.Controls.Add(this.lb_prom_a);
			this.Controls.Add(this.lb_prom);
			this.Controls.Add(this.lb_sign_B);
			this.Controls.Add(this.lb_sign_A);
			this.Controls.Add(this.chkb_ReversCode);
			this.Controls.Add(this.chkb_NumRep);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.Btn_close);
			this.Controls.Add(this.GB_Operators);
			this.Controls.Add(this.chkb_Operation);
			this.Controls.Add(this.lb_resCode);
			this.Controls.Add(this.TB_SYS_RES);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TB_Result);
			this.Controls.Add(this.LB_SYS_B);
			this.Controls.Add(this.LB_B);
			this.Controls.Add(this.LB_SYS_A);
			this.Controls.Add(this.LB_A);
			this.Controls.Add(this.TB_SYS_B);
			this.Controls.Add(this.TB_B);
			this.Controls.Add(this.TB_SYS_A);
			this.Controls.Add(this.TB_A);
			this.Controls.Add(this.Btn_OK);
			this.Controls.Add(this.TB_prom_b);
			this.Controls.Add(this.TB_prom_a);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(650, 330);
			this.MinimumSize = new System.Drawing.Size(447, 271);
			this.Name = "Number_System";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Number_System";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Number_System_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Number_System_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Number_System_MouseUp);
			this.GB_Operators.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_OK;
		private System.Windows.Forms.TextBox TB_A;
		private System.Windows.Forms.TextBox TB_SYS_A;
		private System.Windows.Forms.TextBox TB_B;
		private System.Windows.Forms.TextBox TB_SYS_B;
		private System.Windows.Forms.Label LB_A;
		private System.Windows.Forms.Label LB_SYS_A;
		private System.Windows.Forms.Label LB_B;
		private System.Windows.Forms.Label LB_SYS_B;
		private System.Windows.Forms.TextBox TB_Result;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TB_SYS_RES;
		private System.Windows.Forms.Label lb_resCode;
		private System.Windows.Forms.CheckBox chkb_Operation;
		private System.Windows.Forms.GroupBox GB_Operators;
		private System.Windows.Forms.Button Btn_div;
		private System.Windows.Forms.Button Btn_multy;
		private System.Windows.Forms.Button Btn_minus;
		private System.Windows.Forms.Button Btn_plus;
		private System.Windows.Forms.Button Btn_close;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.CheckBox chkb_NumRep;
		private System.Windows.Forms.CheckBox chkb_ReversCode;
		private System.Windows.Forms.Label lb_sign_A;
		private System.Windows.Forms.Label lb_sign_B;
		private System.Windows.Forms.TextBox TB_prom_a;
		private System.Windows.Forms.TextBox TB_prom_b;
		private System.Windows.Forms.Label lb_prom;
		private System.Windows.Forms.Label lb_prom_a;
		private System.Windows.Forms.Label lb_prom_B;
		private System.Windows.Forms.Label lb_Operate;
		private System.Windows.Forms.Label lb_OverFloat;
	}
}