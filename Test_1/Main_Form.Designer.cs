namespace Combo_Programs
{
   partial class Main_F
   {
	  /// <summary>
	  /// Обязательная переменная конструктора.
	  /// </summary>
	  private System.ComponentModel.IContainer components = null;

	  /// <summary>
	  /// Освободить все используемые ресурсы.
	  /// </summary>
	  /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
	  protected override void Dispose(bool disposing) {
		 if (disposing && (components != null))
		 {
			components.Dispose();
		 }
		 base.Dispose(disposing);
	  }

	  #region Код, автоматически созданный конструктором форм Windows

	  /// <summary>
	  /// Требуемый метод для поддержки конструктора — не изменяйте 
	  /// содержимое этого метода с помощью редактора кода.
	  /// </summary>
	  private void InitializeComponent() {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.CB_List = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btn_Exit.Location = new System.Drawing.Point(265, 98);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 40);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_List
            // 
            this.CB_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CB_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_List.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CB_List.Items.AddRange(new object[] {
            "Калькулятор",
            "Моя Страничка",
            "Текстовый редактор",
            "Система счисления",
            "Будильник",
            "Менеджер покупок"});
            this.CB_List.Location = new System.Drawing.Point(12, 29);
            this.CB_List.Name = "CB_List";
            this.CB_List.Size = new System.Drawing.Size(333, 27);
            this.CB_List.TabIndex = 1;
            this.CB_List.Click += new System.EventHandler(this.CB_List_MouseEnter);
            this.CB_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CB_List_MouseEnter);
            this.CB_List.MouseEnter += new System.EventHandler(this.CB_List_MouseEnter);
            this.CB_List.MouseLeave += new System.EventHandler(this.CB_List_MouseLeave);
            this.CB_List.MouseHover += new System.EventHandler(this.CB_List_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список программ :";
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btn_OK.Location = new System.Drawing.Point(12, 98);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(247, 40);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Main_F
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(357, 150);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_List);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 250);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "Main_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сборник программ";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_F_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_F_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_F_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_F_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

	  }

		#endregion

		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.ComboBox CB_List;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_OK;
	}
}

