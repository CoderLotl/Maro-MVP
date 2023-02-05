namespace Views
{
    partial class FrmCharactersMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCharactersMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CalcAgeAll = new System.Windows.Forms.Button();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_AddCharacter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBox_Data = new System.Windows.Forms.GroupBox();
            this.lbl_LoadedValue = new System.Windows.Forms.Label();
            this.lbl_Loaded = new System.Windows.Forms.Label();
            this.lbl_CharactersCount = new System.Windows.Forms.Label();
            this.lbl_Characters = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_MaroDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImage = global::Maro_MVP.Resources.aaf8c99e04d0a36f6aaaed0baf9183c6;
            this.groupBox1.Controls.Add(this.btn_CalcAgeAll);
            this.groupBox1.Controls.Add(this.btn_ClearList);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Load);
            this.groupBox1.Controls.Add(this.btn_AddCharacter);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 690);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btn_CalcAgeAll
            // 
            this.btn_CalcAgeAll.BackColor = System.Drawing.Color.Red;
            this.btn_CalcAgeAll.BackgroundImage = global::Maro_MVP.Resources.glossy_background_hd_wallpaper_wallpaper_preview;
            this.btn_CalcAgeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CalcAgeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcAgeAll.Location = new System.Drawing.Point(8, 376);
            this.btn_CalcAgeAll.Name = "btn_CalcAgeAll";
            this.btn_CalcAgeAll.Size = new System.Drawing.Size(152, 44);
            this.btn_CalcAgeAll.TabIndex = 3;
            this.btn_CalcAgeAll.Text = "Auto-calc Characters Age";
            this.btn_CalcAgeAll.UseVisualStyleBackColor = false;
            this.btn_CalcAgeAll.Click += new System.EventHandler(this.Btn_CalcAgeAllClick);
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.BackColor = System.Drawing.Color.Red;
            this.btn_ClearList.BackgroundImage = global::Maro_MVP.Resources.images;
            this.btn_ClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ClearList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ClearList.Location = new System.Drawing.Point(8, 256);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(152, 48);
            this.btn_ClearList.TabIndex = 2;
            this.btn_ClearList.Text = "Clear List";
            this.btn_ClearList.UseVisualStyleBackColor = false;
            this.btn_ClearList.Click += new System.EventHandler(this.Btn_ClearListClick);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Red;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(8, 200);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(152, 48);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save List";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_SaveClick);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Red;
            this.btn_Load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Load.BackgroundImage")));
            this.btn_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Load.Location = new System.Drawing.Point(8, 144);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(152, 48);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load List";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.Btn_LoadClick);
            // 
            // btn_AddCharacter
            // 
            this.btn_AddCharacter.BackColor = System.Drawing.Color.Red;
            this.btn_AddCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddCharacter.BackgroundImage")));
            this.btn_AddCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddCharacter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AddCharacter.FlatAppearance.BorderSize = 3;
            this.btn_AddCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCharacter.Location = new System.Drawing.Point(6, 89);
            this.btn_AddCharacter.Name = "btn_AddCharacter";
            this.btn_AddCharacter.Size = new System.Drawing.Size(152, 44);
            this.btn_AddCharacter.TabIndex = 0;
            this.btn_AddCharacter.Text = "Add a new Character";
            this.btn_AddCharacter.UseVisualStyleBackColor = false;
            this.btn_AddCharacter.Click += new System.EventHandler(this.btn_AddCharacter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(196, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 367);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
            // 
            // grpBox_Data
            // 
            this.grpBox_Data.Controls.Add(this.lbl_LoadedValue);
            this.grpBox_Data.Controls.Add(this.lbl_Loaded);
            this.grpBox_Data.Controls.Add(this.lbl_CharactersCount);
            this.grpBox_Data.Controls.Add(this.lbl_Characters);
            this.grpBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Data.Location = new System.Drawing.Point(205, 12);
            this.grpBox_Data.Name = "grpBox_Data";
            this.grpBox_Data.Size = new System.Drawing.Size(499, 100);
            this.grpBox_Data.TabIndex = 9;
            this.grpBox_Data.TabStop = false;
            // 
            // lbl_LoadedValue
            // 
            this.lbl_LoadedValue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_LoadedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LoadedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoadedValue.Location = new System.Drawing.Point(112, 62);
            this.lbl_LoadedValue.Name = "lbl_LoadedValue";
            this.lbl_LoadedValue.Size = new System.Drawing.Size(100, 23);
            this.lbl_LoadedValue.TabIndex = 3;
            this.lbl_LoadedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_LoadedValue.Visible = false;
            // 
            // lbl_Loaded
            // 
            this.lbl_Loaded.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Loaded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Loaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Loaded.Location = new System.Drawing.Point(6, 62);
            this.lbl_Loaded.Name = "lbl_Loaded";
            this.lbl_Loaded.Size = new System.Drawing.Size(100, 23);
            this.lbl_Loaded.TabIndex = 2;
            this.lbl_Loaded.Text = "Loaded File:";
            this.lbl_Loaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Loaded.Visible = false;
            // 
            // lbl_CharactersCount
            // 
            this.lbl_CharactersCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CharactersCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CharactersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CharactersCount.Location = new System.Drawing.Point(249, 25);
            this.lbl_CharactersCount.Name = "lbl_CharactersCount";
            this.lbl_CharactersCount.Size = new System.Drawing.Size(100, 23);
            this.lbl_CharactersCount.TabIndex = 1;
            this.lbl_CharactersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Characters
            // 
            this.lbl_Characters.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Characters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Characters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Characters.Location = new System.Drawing.Point(6, 25);
            this.lbl_Characters.Name = "lbl_Characters";
            this.lbl_Characters.Size = new System.Drawing.Size(237, 23);
            this.lbl_Characters.TabIndex = 0;
            this.lbl_Characters.Text = "My Characters Count:";
            this.lbl_Characters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Maro_MVP.Resources.Untitled;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(129, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1105, 370);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_MaroDate
            // 
            this.lbl_MaroDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MaroDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaroDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaroDate.Location = new System.Drawing.Point(723, 89);
            this.lbl_MaroDate.Name = "lbl_MaroDate";
            this.lbl_MaroDate.Size = new System.Drawing.Size(499, 23);
            this.lbl_MaroDate.TabIndex = 11;
            this.lbl_MaroDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCharactersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1265, 746);
            this.Controls.Add(this.lbl_MaroDate);
            this.Controls.Add(this.grpBox_Data);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCharactersMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Characters Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCharactersMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmCharactersMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCharactersMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddCharacter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpBox_Data;
        private System.Windows.Forms.Label lbl_LoadedValue;
        private System.Windows.Forms.Label lbl_Loaded;
        private System.Windows.Forms.Label lbl_CharactersCount;
        private System.Windows.Forms.Label lbl_Characters;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_ClearList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_MaroDate;
        private System.Windows.Forms.Button btn_CalcAgeAll;
    }
}