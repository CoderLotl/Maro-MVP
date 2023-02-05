namespace Views
{
	partial class FrmDateSetter
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbBox_Hour;
		private System.Windows.Forms.ComboBox cmbBox_Day;
		private System.Windows.Forms.NumericUpDown nud_Year;
		private System.Windows.Forms.GroupBox grpBox_Edit;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Accept;
		
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Year = new System.Windows.Forms.Label();
            this.nud_Year = new System.Windows.Forms.NumericUpDown();
            this.cmbBox_Hour = new System.Windows.Forms.ComboBox();
            this.cmbBox_Day = new System.Windows.Forms.ComboBox();
            this.grpBox_Edit = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).BeginInit();
            this.grpBox_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lbl_Year);
            this.groupBox1.Controls.Add(this.nud_Year);
            this.groupBox1.Controls.Add(this.cmbBox_Hour);
            this.groupBox1.Controls.Add(this.cmbBox_Day);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(220, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(121, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Day";
            // 
            // Lbl_Year
            // 
            this.Lbl_Year.AutoSize = true;
            this.Lbl_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Year.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Lbl_Year.Location = new System.Drawing.Point(38, 31);
            this.Lbl_Year.Name = "Lbl_Year";
            this.Lbl_Year.Size = new System.Drawing.Size(43, 20);
            this.Lbl_Year.TabIndex = 7;
            this.Lbl_Year.Text = "Year";
            // 
            // nud_Year
            // 
            this.nud_Year.Location = new System.Drawing.Point(24, 53);
            this.nud_Year.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Year.Name = "nud_Year";
            this.nud_Year.Size = new System.Drawing.Size(72, 26);
            this.nud_Year.TabIndex = 3;
            this.nud_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBox_Hour
            // 
            this.cmbBox_Hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Hour.FormattingEnabled = true;
            this.cmbBox_Hour.Location = new System.Drawing.Point(208, 53);
            this.cmbBox_Hour.Name = "cmbBox_Hour";
            this.cmbBox_Hour.Size = new System.Drawing.Size(64, 28);
            this.cmbBox_Hour.TabIndex = 2;
            // 
            // cmbBox_Day
            // 
            this.cmbBox_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Day.FormattingEnabled = true;
            this.cmbBox_Day.Location = new System.Drawing.Point(112, 53);
            this.cmbBox_Day.Name = "cmbBox_Day";
            this.cmbBox_Day.Size = new System.Drawing.Size(64, 28);
            this.cmbBox_Day.TabIndex = 1;
            // 
            // grpBox_Edit
            // 
            this.grpBox_Edit.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Edit.Controls.Add(this.btn_Cancel);
            this.grpBox_Edit.Controls.Add(this.btn_Accept);
            this.grpBox_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Edit.Location = new System.Drawing.Point(352, 24);
            this.grpBox_Edit.Name = "grpBox_Edit";
            this.grpBox_Edit.Size = new System.Drawing.Size(144, 94);
            this.grpBox_Edit.TabIndex = 6;
            this.grpBox_Edit.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Black;
            this.btn_Cancel.BackgroundImage = global::Maro_MVP.Resources.reject;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Location = new System.Drawing.Point(6, 21);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Accept.BackgroundImage = global::Maro_MVP.Resources.accept;
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Accept.Location = new System.Drawing.Point(78, 21);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(60, 60);
            this.btn_Accept.TabIndex = 7;
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.Btn_AcceptClick);
            // 
            // FrmDateSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 147);
            this.Controls.Add(this.grpBox_Edit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDateSetter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Setter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).EndInit();
            this.grpBox_Edit.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private System.Windows.Forms.Label Lbl_Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
