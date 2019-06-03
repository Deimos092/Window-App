namespace Combo_Programs
{
	partial class MyPage
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
			this.components = new System.ComponentModel.Container();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.tbOccupation = new System.Windows.Forms.ComboBox();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tbAge = new System.Windows.Forms.TextBox();
			this.tbAddres = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.Lboutput = new System.Windows.Forms.Label();
			this.LbAge = new System.Windows.Forms.Label();
			this.LBOccupation = new System.Windows.Forms.Label();
			this.LbAddres = new System.Windows.Forms.Label();
			this.LbName = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lb_Name = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_Phone = new System.Windows.Forms.Label();
			this.lb_location = new System.Windows.Forms.Label();
			this.tb_Website = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_website = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_phone = new System.Windows.Forms.TextBox();
			this.lb_occupation = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.btnClear.FlatAppearance.BorderSize = 0;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.btnClear.Location = new System.Drawing.Point(523, 105);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(91, 41);
			this.btnClear.TabIndex = 29;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.Red;
			this.btnClose.Location = new System.Drawing.Point(523, 404);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(91, 41);
			this.btnClose.TabIndex = 28;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tbOccupation
			// 
			this.tbOccupation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOccupation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.tbOccupation.Enabled = false;
			this.tbOccupation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tbOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbOccupation.FormattingEnabled = true;
			this.tbOccupation.Items.AddRange(new object[] {
            "Programmer",
            "Designer",
            "Driver",
            "Economist"});
			this.tbOccupation.Location = new System.Drawing.Point(80, 108);
			this.tbOccupation.Name = "tbOccupation";
			this.tbOccupation.Size = new System.Drawing.Size(433, 23);
			this.tbOccupation.TabIndex = 3;
			this.tbOccupation.Text = "Proffesion";
			this.tbOccupation.SelectedIndexChanged += new System.EventHandler(this.tbOccupation_SelectedIndexChanged);
			this.tbOccupation.TextChanged += new System.EventHandler(this.tbOccupation_TextChanged);
			this.tbOccupation.MouseEnter += new System.EventHandler(this.tbOccupation_MouseEnter);
			this.tbOccupation.MouseLeave += new System.EventHandler(this.tbOccupation_MouseLeave);
			this.tbOccupation.Validating += new System.ComponentModel.CancelEventHandler(this.tbOccupation_Validating);
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.btnHelp.FlatAppearance.BorderSize = 0;
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHelp.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.btnHelp.Location = new System.Drawing.Point(523, 58);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(91, 41);
			this.btnHelp.TabIndex = 26;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = false;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.btnOK.Enabled = false;
			this.btnOK.FlatAppearance.BorderSize = 0;
			this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.ForeColor = System.Drawing.Color.Lime;
			this.btnOK.Location = new System.Drawing.Point(523, 11);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(91, 41);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Visible = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tbAge
			// 
			this.tbAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbAge.Enabled = false;
			this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAge.Location = new System.Drawing.Point(80, 163);
			this.tbAge.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.tbAge.MaxLength = 2;
			this.tbAge.Name = "tbAge";
			this.tbAge.Size = new System.Drawing.Size(433, 19);
			this.tbAge.TabIndex = 5;
			this.tbAge.Text = "Age";
			this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
			this.tbAge.Enter += new System.EventHandler(this.tbAge_Enter);
			this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
			this.tbAge.Leave += new System.EventHandler(this.tbAge_Leave);
			// 
			// tbAddres
			// 
			this.tbAddres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAddres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.tbAddres.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbAddres.Enabled = false;
			this.tbAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbAddres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAddres.Location = new System.Drawing.Point(80, 37);
			this.tbAddres.Multiline = true;
			this.tbAddres.Name = "tbAddres";
			this.tbAddres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbAddres.Size = new System.Drawing.Size(433, 40);
			this.tbAddres.TabIndex = 1;
			this.tbAddres.Text = "Addres";
			this.tbAddres.TextChanged += new System.EventHandler(this.tbAddres_TextChanged);
			this.tbAddres.Enter += new System.EventHandler(this.tbAddres_Enter);
			this.tbAddres.Leave += new System.EventHandler(this.tbAddres_Leave);
			this.tbAddres.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddres_Validating);
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbName.Location = new System.Drawing.Point(80, 11);
			this.tbName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.tbName.MaxLength = 8;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(433, 19);
			this.tbName.TabIndex = 0;
			this.tbName.Text = "Name";
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
			this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
			// 
			// Lboutput
			// 
			this.Lboutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Lboutput.AutoSize = true;
			this.Lboutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Lboutput.Location = new System.Drawing.Point(22, 196);
			this.Lboutput.Name = "Lboutput";
			this.Lboutput.Size = new System.Drawing.Size(52, 13);
			this.Lboutput.TabIndex = 19;
			this.Lboutput.Text = "Visit View";
			// 
			// LbAge
			// 
			this.LbAge.AutoSize = true;
			this.LbAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LbAge.Location = new System.Drawing.Point(48, 166);
			this.LbAge.Name = "LbAge";
			this.LbAge.Size = new System.Drawing.Size(26, 13);
			this.LbAge.TabIndex = 18;
			this.LbAge.Text = "Age";
			// 
			// LBOccupation
			// 
			this.LBOccupation.AutoSize = true;
			this.LBOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LBOccupation.Location = new System.Drawing.Point(12, 112);
			this.LBOccupation.Name = "LBOccupation";
			this.LBOccupation.Size = new System.Drawing.Size(62, 13);
			this.LBOccupation.TabIndex = 17;
			this.LBOccupation.Text = "Occupation";
			// 
			// LbAddres
			// 
			this.LbAddres.AutoSize = true;
			this.LbAddres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LbAddres.Location = new System.Drawing.Point(34, 37);
			this.LbAddres.Name = "LbAddres";
			this.LbAddres.Size = new System.Drawing.Size(40, 13);
			this.LbAddres.TabIndex = 16;
			this.LbAddres.Text = "Addres";
			// 
			// LbName
			// 
			this.LbName.AutoSize = true;
			this.LbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.LbName.Location = new System.Drawing.Point(39, 14);
			this.LbName.Name = "LbName";
			this.LbName.Size = new System.Drawing.Size(35, 13);
			this.LbName.TabIndex = 15;
			this.LbName.Text = "Name";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Combo_Programs.Properties.Resources.Visit_Back;
			this.pictureBox1.InitialImage = global::Combo_Programs.Properties.Resources.Visit_Back;
			this.pictureBox1.Location = new System.Drawing.Point(80, 208);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(433, 237);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.Firebrick;
			this.button1.Location = new System.Drawing.Point(523, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 41);
			this.button1.TabIndex = 31;
			this.button1.Text = "Print";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// lb_Name
			// 
			this.lb_Name.AutoSize = true;
			this.lb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
			this.lb_Name.Font = new System.Drawing.Font("Haettenschweiler", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_Name.ForeColor = System.Drawing.Color.White;
			this.lb_Name.Location = new System.Drawing.Point(356, 259);
			this.lb_Name.Name = "lb_Name";
			this.lb_Name.Size = new System.Drawing.Size(100, 40);
			this.lb_Name.TabIndex = 32;
			this.lb_Name.Text = "DefSec";
			this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
			this.label1.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(374, 303);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 21);
			this.label1.TabIndex = 33;
			this.label1.Text = "Corporation";
			// 
			// lb_Phone
			// 
			this.lb_Phone.AutoSize = true;
			this.lb_Phone.BackColor = System.Drawing.Color.White;
			this.lb_Phone.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lb_Phone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
			this.lb_Phone.Location = new System.Drawing.Point(137, 283);
			this.lb_Phone.Name = "lb_Phone";
			this.lb_Phone.Size = new System.Drawing.Size(85, 16);
			this.lb_Phone.TabIndex = 34;
			this.lb_Phone.Text = "Phone number";
			// 
			// lb_location
			// 
			this.lb_location.BackColor = System.Drawing.Color.White;
			this.lb_location.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lb_location.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
			this.lb_location.Location = new System.Drawing.Point(137, 310);
			this.lb_location.Name = "lb_location";
			this.lb_location.Size = new System.Drawing.Size(185, 35);
			this.lb_location.TabIndex = 35;
			this.lb_location.Text = "Your location";
			// 
			// tb_Website
			// 
			this.tb_Website.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Website.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.tb_Website.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_Website.Enabled = false;
			this.tb_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_Website.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tb_Website.Location = new System.Drawing.Point(80, 83);
			this.tb_Website.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.tb_Website.MaxLength = 25;
			this.tb_Website.Name = "tb_Website";
			this.tb_Website.Size = new System.Drawing.Size(433, 19);
			this.tb_Website.TabIndex = 2;
			this.tb_Website.Text = "https://www.mywebsite.com";
			this.tb_Website.TextChanged += new System.EventHandler(this.tb_Website_TextChanged);
			this.tb_Website.Enter += new System.EventHandler(this.tb_Website_Enter);
			this.tb_Website.Leave += new System.EventHandler(this.tb_Website_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.label2.Location = new System.Drawing.Point(28, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 37;
			this.label2.Text = "Website";
			// 
			// lb_website
			// 
			this.lb_website.AutoSize = true;
			this.lb_website.BackColor = System.Drawing.Color.White;
			this.lb_website.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lb_website.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_website.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
			this.lb_website.Location = new System.Drawing.Point(137, 354);
			this.lb_website.Name = "lb_website";
			this.lb_website.Size = new System.Drawing.Size(153, 16);
			this.lb_website.TabIndex = 38;
			this.lb_website.Text = "https://www.mywebsite.com";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.label4.Location = new System.Drawing.Point(36, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Phone";
			// 
			// tb_phone
			// 
			this.tb_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_phone.Enabled = false;
			this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tb_phone.Location = new System.Drawing.Point(80, 136);
			this.tb_phone.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.tb_phone.MaxLength = 20;
			this.tb_phone.Name = "tb_phone";
			this.tb_phone.Size = new System.Drawing.Size(433, 19);
			this.tb_phone.TabIndex = 4;
			this.tb_phone.Text = "Phone number";
			this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
			this.tb_phone.Enter += new System.EventHandler(this.tb_phone_Enter);
			this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_KeyPress);
			this.tb_phone.Leave += new System.EventHandler(this.tb_phone_Leave);
			// 
			// lb_occupation
			// 
			this.lb_occupation.AutoSize = true;
			this.lb_occupation.BackColor = System.Drawing.Color.White;
			this.lb_occupation.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lb_occupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
			this.lb_occupation.Location = new System.Drawing.Point(204, 222);
			this.lb_occupation.Name = "lb_occupation";
			this.lb_occupation.Size = new System.Drawing.Size(80, 20);
			this.lb_occupation.TabIndex = 41;
			this.lb_occupation.Text = "Occupation";
			// 
			// MyPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(626, 451);
			this.Controls.Add(this.lb_occupation);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_phone);
			this.Controls.Add(this.lb_website);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_Website);
			this.Controls.Add(this.lb_location);
			this.Controls.Add(this.lb_Phone);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_Name);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.tbOccupation);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tbAge);
			this.Controls.Add(this.tbAddres);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.Lboutput);
			this.Controls.Add(this.LbAge);
			this.Controls.Add(this.LBOccupation);
			this.Controls.Add(this.LbAddres);
			this.Controls.Add(this.LbName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(2000, 2000);
			this.MinimumSize = new System.Drawing.Size(491, 351);
			this.Name = "MyPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyPage";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyPage_KeyUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyPage_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyPage_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyPage_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ComboBox tbOccupation;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox tbAge;
		public System.Windows.Forms.TextBox tbAddres;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label Lboutput;
		private System.Windows.Forms.Label LbAge;
		private System.Windows.Forms.Label LBOccupation;
		private System.Windows.Forms.Label LbAddres;
		private System.Windows.Forms.Label LbName;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lb_Name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lb_Phone;
		private System.Windows.Forms.Label lb_location;
		private System.Windows.Forms.TextBox tb_Website;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb_website;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_phone;
		private System.Windows.Forms.Label lb_occupation;
	}
}