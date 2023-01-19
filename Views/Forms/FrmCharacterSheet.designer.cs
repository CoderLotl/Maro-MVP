namespace Views
{
	partial class FrmCharacterSheet
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtBox_Name;
		private System.Windows.Forms.RichTextBox rchTxtBox_Description;
		private System.Windows.Forms.GroupBox grpBox_Name;
		private System.Windows.Forms.GroupBox grpBox_Age;
		private System.Windows.Forms.TextBox txtBox_Age;
		
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
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.rchTxtBox_Description = new System.Windows.Forms.RichTextBox();
            this.grpBox_Name = new System.Windows.Forms.GroupBox();
            this.grpBox_Age = new System.Windows.Forms.GroupBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.grpBox_Edit = new System.Windows.Forms.GroupBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.nud_Age = new System.Windows.Forms.NumericUpDown();
            this.cmbBox_Race = new System.Windows.Forms.ComboBox();
            this.grpBox_Race = new System.Windows.Forms.GroupBox();
            this.grpBox_Gender = new System.Windows.Forms.GroupBox();
            this.cmbBox_Gender = new System.Windows.Forms.ComboBox();
            this.grpBox_Condition = new System.Windows.Forms.GroupBox();
            this.cmbBox_Condition = new System.Windows.Forms.ComboBox();
            this.grpBox_SpCondition = new System.Windows.Forms.GroupBox();
            this.cmbBox_SpCondition = new System.Windows.Forms.ComboBox();
            this.grpBox_Description = new System.Windows.Forms.GroupBox();
            this.btn_Underline = new System.Windows.Forms.Button();
            this.btn_Italic = new System.Windows.Forms.Button();
            this.btn_Bold = new System.Windows.Forms.Button();
            this.grpBox_Alive = new System.Windows.Forms.GroupBox();
            this.cmbBox_IsAlive = new System.Windows.Forms.ComboBox();
            this.lbl_Characer = new System.Windows.Forms.Label();
            this.grpBox_FamilyTies = new System.Windows.Forms.GroupBox();
            this.grpBox_FamilyNode = new System.Windows.Forms.GroupBox();
            this.lbl_FamilyNode = new System.Windows.Forms.Label();
            this.btn_AddFamilyTie = new System.Windows.Forms.Button();
            this.cmbBox_Characters = new System.Windows.Forms.ComboBox();
            this.btn_RmvFamilyTie = new System.Windows.Forms.Button();
            this.tv_Family = new System.Windows.Forms.TreeView();
            this.grpBox_SkillTracker = new System.Windows.Forms.GroupBox();
            this.tabControl_Skills = new System.Windows.Forms.TabControl();
            this.tab_Strength = new System.Windows.Forms.TabPage();
            this.nud_Smithing = new System.Windows.Forms.NumericUpDown();
            this.nud_Harvesting = new System.Windows.Forms.NumericUpDown();
            this.nud_Mining = new System.Windows.Forms.NumericUpDown();
            this.nud_Melee = new System.Windows.Forms.NumericUpDown();
            this.nud_Strength = new System.Windows.Forms.NumericUpDown();
            this.pBar_Melee = new Framework.Controls.XpProgressBar();
            this.pBar_Smithing = new Framework.Controls.XpProgressBar();
            this.pBar_Harvesting = new Framework.Controls.XpProgressBar();
            this.pBar_Mining = new Framework.Controls.XpProgressBar();
            this.pBar_Strength = new Framework.Controls.XpProgressBar();
            this.tab_Dexterity = new System.Windows.Forms.TabPage();
            this.nud_Cooking = new System.Windows.Forms.NumericUpDown();
            this.nud_Tailoring = new System.Windows.Forms.NumericUpDown();
            this.nud_Ranching = new System.Windows.Forms.NumericUpDown();
            this.nud_Marksman = new System.Windows.Forms.NumericUpDown();
            this.nud_Dexterity = new System.Windows.Forms.NumericUpDown();
            this.pBar_Marksman = new Framework.Controls.XpProgressBar();
            this.pBar_Cooking = new Framework.Controls.XpProgressBar();
            this.pBar_Tailoring = new Framework.Controls.XpProgressBar();
            this.pBar_Ranching = new Framework.Controls.XpProgressBar();
            this.pBar_Dexterity = new Framework.Controls.XpProgressBar();
            this.tab_Knowledge = new System.Windows.Forms.TabPage();
            this.nud_Manufacturing = new System.Windows.Forms.NumericUpDown();
            this.nud_Guile = new System.Windows.Forms.NumericUpDown();
            this.nud_Engineering = new System.Windows.Forms.NumericUpDown();
            this.nud_Alchemy = new System.Windows.Forms.NumericUpDown();
            this.nud_Knowledge = new System.Windows.Forms.NumericUpDown();
            this.pBar_Alchemy = new Framework.Controls.XpProgressBar();
            this.pBar_Manufacturing = new Framework.Controls.XpProgressBar();
            this.pBar_Guile = new Framework.Controls.XpProgressBar();
            this.pBar_Engineering = new Framework.Controls.XpProgressBar();
            this.pBar_Knowledge = new Framework.Controls.XpProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picBox_Banner = new System.Windows.Forms.PictureBox();
            this.picBox_Race = new System.Windows.Forms.PictureBox();
            this.picBox_Gender = new System.Windows.Forms.PictureBox();
            this.picBox_Condition = new System.Windows.Forms.PictureBox();
            this.picBox_SpCondition = new System.Windows.Forms.PictureBox();
            this.grpBox_Birthday = new System.Windows.Forms.GroupBox();
            this.btn_EditBirthday = new System.Windows.Forms.Button();
            this.txtBox_Birthday = new System.Windows.Forms.TextBox();
            this.grpBox_DeathDay = new System.Windows.Forms.GroupBox();
            this.btn_EditDeathday = new System.Windows.Forms.Button();
            this.txtBox_Deathday = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LoadPicture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DiscardPicture = new System.Windows.Forms.Button();
            this.grpBox_Name.SuspendLayout();
            this.grpBox_Age.SuspendLayout();
            this.grpBox_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).BeginInit();
            this.grpBox_Race.SuspendLayout();
            this.grpBox_Gender.SuspendLayout();
            this.grpBox_Condition.SuspendLayout();
            this.grpBox_SpCondition.SuspendLayout();
            this.grpBox_Description.SuspendLayout();
            this.grpBox_Alive.SuspendLayout();
            this.grpBox_FamilyTies.SuspendLayout();
            this.grpBox_FamilyNode.SuspendLayout();
            this.grpBox_SkillTracker.SuspendLayout();
            this.tabControl_Skills.SuspendLayout();
            this.tab_Strength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Smithing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Harvesting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Mining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Melee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Strength)).BeginInit();
            this.tab_Dexterity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tailoring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ranching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Marksman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dexterity)).BeginInit();
            this.tab_Knowledge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Manufacturing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Guile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Engineering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alchemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Knowledge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Race)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Condition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_SpCondition)).BeginInit();
            this.grpBox_Birthday.SuspendLayout();
            this.grpBox_DeathDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Enabled = false;
            this.txtBox_Name.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(200, 27);
            this.txtBox_Name.TabIndex = 0;
            this.txtBox_Name.TextChanged += new System.EventHandler(this.txtBox_Name_TextChanged);
            // 
            // rchTxtBox_Description
            // 
            this.rchTxtBox_Description.BackColor = System.Drawing.Color.Wheat;
            this.rchTxtBox_Description.Enabled = false;
            this.rchTxtBox_Description.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBox_Description.Location = new System.Drawing.Point(16, 48);
            this.rchTxtBox_Description.Name = "rchTxtBox_Description";
            this.rchTxtBox_Description.Size = new System.Drawing.Size(448, 192);
            this.rchTxtBox_Description.TabIndex = 1;
            this.rchTxtBox_Description.Text = "";
            this.rchTxtBox_Description.TextChanged += new System.EventHandler(this.rchTxtBox_Description_TextChanged);
            // 
            // grpBox_Name
            // 
            this.grpBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Name.Controls.Add(this.txtBox_Name);
            this.grpBox_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Name.Location = new System.Drawing.Point(104, 130);
            this.grpBox_Name.Name = "grpBox_Name";
            this.grpBox_Name.Size = new System.Drawing.Size(224, 64);
            this.grpBox_Name.TabIndex = 3;
            this.grpBox_Name.TabStop = false;
            this.grpBox_Name.Text = "Name";
            // 
            // grpBox_Age
            // 
            this.grpBox_Age.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Age.Controls.Add(this.txtBox_Age);
            this.grpBox_Age.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Age.Location = new System.Drawing.Point(344, 290);
            this.grpBox_Age.Name = "grpBox_Age";
            this.grpBox_Age.Size = new System.Drawing.Size(72, 64);
            this.grpBox_Age.TabIndex = 4;
            this.grpBox_Age.TabStop = false;
            this.grpBox_Age.Text = "Age";
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Enabled = false;
            this.txtBox_Age.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.ReadOnly = true;
            this.txtBox_Age.Size = new System.Drawing.Size(48, 27);
            this.txtBox_Age.TabIndex = 0;
            // 
            // grpBox_Edit
            // 
            this.grpBox_Edit.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Edit.Controls.Add(this.btn_Undo);
            this.grpBox_Edit.Controls.Add(this.btn_Cancel);
            this.grpBox_Edit.Controls.Add(this.btn_Accept);
            this.grpBox_Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Edit.Location = new System.Drawing.Point(994, 780);
            this.grpBox_Edit.Name = "grpBox_Edit";
            this.grpBox_Edit.Size = new System.Drawing.Size(222, 94);
            this.grpBox_Edit.TabIndex = 5;
            this.grpBox_Edit.TabStop = false;
            this.grpBox_Edit.Text = "Edit";
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.SlateGray;            
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Undo.Location = new System.Drawing.Point(22, 19);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(60, 60);
            this.btn_Undo.TabIndex = 9;
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.Btn_Undo_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Black;            
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Location = new System.Drawing.Point(154, 19);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.OliveDrab;            
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Accept.Location = new System.Drawing.Point(86, 19);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(60, 60);
            this.btn_Accept.TabIndex = 7;
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // nud_Age
            // 
            this.nud_Age.Enabled = false;
            this.nud_Age.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Age.Location = new System.Drawing.Point(422, 314);
            this.nud_Age.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Age.Name = "nud_Age";
            this.nud_Age.Size = new System.Drawing.Size(44, 27);
            this.nud_Age.TabIndex = 6;
            this.nud_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Age.Visible = false;
            this.nud_Age.ValueChanged += new System.EventHandler(this.nud_Age_ValueChanged);
            // 
            // cmbBox_Race
            // 
            this.cmbBox_Race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Race.Enabled = false;
            this.cmbBox_Race.FormattingEnabled = true;
            this.cmbBox_Race.Location = new System.Drawing.Point(8, 24);
            this.cmbBox_Race.Name = "cmbBox_Race";
            this.cmbBox_Race.Size = new System.Drawing.Size(200, 29);
            this.cmbBox_Race.TabIndex = 7;
            this.cmbBox_Race.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Race_SelectedIndexChanged);
            // 
            // grpBox_Race
            // 
            this.grpBox_Race.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Race.Controls.Add(this.cmbBox_Race);
            this.grpBox_Race.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Race.Location = new System.Drawing.Point(104, 210);
            this.grpBox_Race.Name = "grpBox_Race";
            this.grpBox_Race.Size = new System.Drawing.Size(224, 64);
            this.grpBox_Race.TabIndex = 8;
            this.grpBox_Race.TabStop = false;
            this.grpBox_Race.Text = "Race";
            // 
            // grpBox_Gender
            // 
            this.grpBox_Gender.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Gender.Controls.Add(this.cmbBox_Gender);
            this.grpBox_Gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Gender.Location = new System.Drawing.Point(344, 370);
            this.grpBox_Gender.Name = "grpBox_Gender";
            this.grpBox_Gender.Size = new System.Drawing.Size(216, 64);
            this.grpBox_Gender.TabIndex = 9;
            this.grpBox_Gender.TabStop = false;
            this.grpBox_Gender.Text = "Gender";
            // 
            // cmbBox_Gender
            // 
            this.cmbBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Gender.Enabled = false;
            this.cmbBox_Gender.FormattingEnabled = true;
            this.cmbBox_Gender.Location = new System.Drawing.Point(8, 24);
            this.cmbBox_Gender.Name = "cmbBox_Gender";
            this.cmbBox_Gender.Size = new System.Drawing.Size(200, 29);
            this.cmbBox_Gender.TabIndex = 7;
            this.cmbBox_Gender.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Gender_SelectedIndexChanged);
            // 
            // grpBox_Condition
            // 
            this.grpBox_Condition.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Condition.Controls.Add(this.cmbBox_Condition);
            this.grpBox_Condition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Condition.Location = new System.Drawing.Point(104, 290);
            this.grpBox_Condition.Name = "grpBox_Condition";
            this.grpBox_Condition.Size = new System.Drawing.Size(224, 64);
            this.grpBox_Condition.TabIndex = 10;
            this.grpBox_Condition.TabStop = false;
            this.grpBox_Condition.Text = "Condition";
            // 
            // cmbBox_Condition
            // 
            this.cmbBox_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Condition.Enabled = false;
            this.cmbBox_Condition.FormattingEnabled = true;
            this.cmbBox_Condition.Location = new System.Drawing.Point(8, 24);
            this.cmbBox_Condition.Name = "cmbBox_Condition";
            this.cmbBox_Condition.Size = new System.Drawing.Size(200, 29);
            this.cmbBox_Condition.TabIndex = 7;
            this.cmbBox_Condition.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Condition_SelectedIndexChanged);
            // 
            // grpBox_SpCondition
            // 
            this.grpBox_SpCondition.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_SpCondition.Controls.Add(this.cmbBox_SpCondition);
            this.grpBox_SpCondition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_SpCondition.Location = new System.Drawing.Point(344, 450);
            this.grpBox_SpCondition.Name = "grpBox_SpCondition";
            this.grpBox_SpCondition.Size = new System.Drawing.Size(216, 64);
            this.grpBox_SpCondition.TabIndex = 11;
            this.grpBox_SpCondition.TabStop = false;
            this.grpBox_SpCondition.Text = "Special Condition";
            // 
            // cmbBox_SpCondition
            // 
            this.cmbBox_SpCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_SpCondition.Enabled = false;
            this.cmbBox_SpCondition.FormattingEnabled = true;
            this.cmbBox_SpCondition.Location = new System.Drawing.Point(8, 24);
            this.cmbBox_SpCondition.Name = "cmbBox_SpCondition";
            this.cmbBox_SpCondition.Size = new System.Drawing.Size(200, 29);
            this.cmbBox_SpCondition.TabIndex = 7;
            this.cmbBox_SpCondition.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SpCondition_SelectedIndexChanged);
            // 
            // grpBox_Description
            // 
            this.grpBox_Description.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Description.Controls.Add(this.btn_Underline);
            this.grpBox_Description.Controls.Add(this.btn_Italic);
            this.grpBox_Description.Controls.Add(this.btn_Bold);
            this.grpBox_Description.Controls.Add(this.rchTxtBox_Description);
            this.grpBox_Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Description.Location = new System.Drawing.Point(736, 526);
            this.grpBox_Description.Name = "grpBox_Description";
            this.grpBox_Description.Size = new System.Drawing.Size(480, 248);
            this.grpBox_Description.TabIndex = 12;
            this.grpBox_Description.TabStop = false;
            this.grpBox_Description.Text = "Description and Notes";
            // 
            // btn_Underline
            // 
            this.btn_Underline.Enabled = false;
            this.btn_Underline.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Underline.Location = new System.Drawing.Point(112, 24);
            this.btn_Underline.Name = "btn_Underline";
            this.btn_Underline.Size = new System.Drawing.Size(40, 23);
            this.btn_Underline.TabIndex = 4;
            this.btn_Underline.Text = "U";
            this.btn_Underline.UseVisualStyleBackColor = true;
            this.btn_Underline.Click += new System.EventHandler(this.Btn_UnderlineClick);
            // 
            // btn_Italic
            // 
            this.btn_Italic.Enabled = false;
            this.btn_Italic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Italic.Location = new System.Drawing.Point(64, 24);
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.Size = new System.Drawing.Size(40, 23);
            this.btn_Italic.TabIndex = 3;
            this.btn_Italic.Text = "I";
            this.btn_Italic.UseVisualStyleBackColor = true;
            this.btn_Italic.Click += new System.EventHandler(this.Btn_ItalicClick);
            // 
            // btn_Bold
            // 
            this.btn_Bold.Enabled = false;
            this.btn_Bold.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bold.Location = new System.Drawing.Point(16, 24);
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(40, 23);
            this.btn_Bold.TabIndex = 2;
            this.btn_Bold.Text = "B";
            this.btn_Bold.UseVisualStyleBackColor = true;
            this.btn_Bold.Click += new System.EventHandler(this.Btn_BoldClick);
            // 
            // grpBox_Alive
            // 
            this.grpBox_Alive.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Alive.Controls.Add(this.cmbBox_IsAlive);
            this.grpBox_Alive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Alive.Location = new System.Drawing.Point(472, 290);
            this.grpBox_Alive.Name = "grpBox_Alive";
            this.grpBox_Alive.Size = new System.Drawing.Size(88, 64);
            this.grpBox_Alive.TabIndex = 13;
            this.grpBox_Alive.TabStop = false;
            this.grpBox_Alive.Text = "Is alive?";
            // 
            // cmbBox_IsAlive
            // 
            this.cmbBox_IsAlive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_IsAlive.Enabled = false;
            this.cmbBox_IsAlive.FormattingEnabled = true;
            this.cmbBox_IsAlive.Location = new System.Drawing.Point(8, 24);
            this.cmbBox_IsAlive.Name = "cmbBox_IsAlive";
            this.cmbBox_IsAlive.Size = new System.Drawing.Size(72, 29);
            this.cmbBox_IsAlive.TabIndex = 7;
            this.cmbBox_IsAlive.SelectedIndexChanged += new System.EventHandler(this.CmbBox_IsAliveSelectedIndexChanged);
            // 
            // lbl_Characer
            // 
            this.lbl_Characer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Characer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Characer.Location = new System.Drawing.Point(104, 98);
            this.lbl_Characer.Name = "lbl_Characer";
            this.lbl_Characer.Size = new System.Drawing.Size(354, 32);
            this.lbl_Characer.TabIndex = 14;
            this.lbl_Characer.Text = "Character Sheet";
            // 
            // grpBox_FamilyTies
            // 
            this.grpBox_FamilyTies.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_FamilyTies.Controls.Add(this.grpBox_FamilyNode);
            this.grpBox_FamilyTies.Controls.Add(this.btn_AddFamilyTie);
            this.grpBox_FamilyTies.Controls.Add(this.cmbBox_Characters);
            this.grpBox_FamilyTies.Controls.Add(this.btn_RmvFamilyTie);
            this.grpBox_FamilyTies.Controls.Add(this.tv_Family);
            this.grpBox_FamilyTies.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_FamilyTies.Location = new System.Drawing.Point(736, 77);
            this.grpBox_FamilyTies.Name = "grpBox_FamilyTies";
            this.grpBox_FamilyTies.Size = new System.Drawing.Size(480, 432);
            this.grpBox_FamilyTies.TabIndex = 15;
            this.grpBox_FamilyTies.TabStop = false;
            this.grpBox_FamilyTies.Text = "Family Ties";
            // 
            // grpBox_FamilyNode
            // 
            this.grpBox_FamilyNode.Controls.Add(this.lbl_FamilyNode);
            this.grpBox_FamilyNode.Location = new System.Drawing.Point(16, 328);
            this.grpBox_FamilyNode.Name = "grpBox_FamilyNode";
            this.grpBox_FamilyNode.Size = new System.Drawing.Size(296, 61);
            this.grpBox_FamilyNode.TabIndex = 4;
            this.grpBox_FamilyNode.TabStop = false;
            this.grpBox_FamilyNode.Text = "Selected Family Tie";
            // 
            // lbl_FamilyNode
            // 
            this.lbl_FamilyNode.AutoSize = true;
            this.lbl_FamilyNode.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FamilyNode.Location = new System.Drawing.Point(20, 28);
            this.lbl_FamilyNode.Name = "lbl_FamilyNode";
            this.lbl_FamilyNode.Size = new System.Drawing.Size(59, 21);
            this.lbl_FamilyNode.TabIndex = 0;
            this.lbl_FamilyNode.Text = "label1";
            // 
            // btn_AddFamilyTie
            // 
            this.btn_AddFamilyTie.Enabled = false;
            this.btn_AddFamilyTie.Location = new System.Drawing.Point(375, 351);
            this.btn_AddFamilyTie.Name = "btn_AddFamilyTie";
            this.btn_AddFamilyTie.Size = new System.Drawing.Size(89, 30);
            this.btn_AddFamilyTie.TabIndex = 3;
            this.btn_AddFamilyTie.Text = "Add";
            this.btn_AddFamilyTie.UseVisualStyleBackColor = true;
            this.btn_AddFamilyTie.Click += new System.EventHandler(this.btn_AddFamilyTie_Click);
            // 
            // cmbBox_Characters
            // 
            this.cmbBox_Characters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Characters.Enabled = false;
            this.cmbBox_Characters.FormattingEnabled = true;
            this.cmbBox_Characters.Location = new System.Drawing.Point(16, 396);
            this.cmbBox_Characters.Name = "cmbBox_Characters";
            this.cmbBox_Characters.Size = new System.Drawing.Size(296, 29);
            this.cmbBox_Characters.TabIndex = 2;
            // 
            // btn_RmvFamilyTie
            // 
            this.btn_RmvFamilyTie.Enabled = false;
            this.btn_RmvFamilyTie.Location = new System.Drawing.Point(375, 396);
            this.btn_RmvFamilyTie.Name = "btn_RmvFamilyTie";
            this.btn_RmvFamilyTie.Size = new System.Drawing.Size(89, 30);
            this.btn_RmvFamilyTie.TabIndex = 1;
            this.btn_RmvFamilyTie.Text = "Remove";
            this.btn_RmvFamilyTie.UseVisualStyleBackColor = true;
            this.btn_RmvFamilyTie.Click += new System.EventHandler(this.btn_RmvFamilyTie_Click);
            // 
            // tv_Family
            // 
            this.tv_Family.BackColor = System.Drawing.Color.LightGray;
            this.tv_Family.Location = new System.Drawing.Point(16, 32);
            this.tv_Family.Name = "tv_Family";
            this.tv_Family.Size = new System.Drawing.Size(448, 280);
            this.tv_Family.TabIndex = 0;
            this.tv_Family.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tv_Family_NodeMouseHover);
            this.tv_Family.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Family_NodeMouseClick);
            this.tv_Family.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Family_NodeMouseDoubleClick);
            // 
            // grpBox_SkillTracker
            // 
            this.grpBox_SkillTracker.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_SkillTracker.Controls.Add(this.tabControl_Skills);
            this.grpBox_SkillTracker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_SkillTracker.Location = new System.Drawing.Point(104, 530);
            this.grpBox_SkillTracker.Name = "grpBox_SkillTracker";
            this.grpBox_SkillTracker.Size = new System.Drawing.Size(448, 368);
            this.grpBox_SkillTracker.TabIndex = 16;
            this.grpBox_SkillTracker.TabStop = false;
            this.grpBox_SkillTracker.Text = "Stats and Skills";
            // 
            // tabControl_Skills
            // 
            this.tabControl_Skills.Controls.Add(this.tab_Strength);
            this.tabControl_Skills.Controls.Add(this.tab_Dexterity);
            this.tabControl_Skills.Controls.Add(this.tab_Knowledge);
            this.tabControl_Skills.Location = new System.Drawing.Point(8, 24);
            this.tabControl_Skills.Name = "tabControl_Skills";
            this.tabControl_Skills.SelectedIndex = 0;
            this.tabControl_Skills.Size = new System.Drawing.Size(432, 328);
            this.tabControl_Skills.TabIndex = 0;
            // 
            // tab_Strength
            // 
            this.tab_Strength.BackColor = System.Drawing.Color.IndianRed;
            this.tab_Strength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Strength.Controls.Add(this.nud_Smithing);
            this.tab_Strength.Controls.Add(this.nud_Harvesting);
            this.tab_Strength.Controls.Add(this.nud_Mining);
            this.tab_Strength.Controls.Add(this.nud_Melee);
            this.tab_Strength.Controls.Add(this.nud_Strength);
            this.tab_Strength.Controls.Add(this.pBar_Melee);
            this.tab_Strength.Controls.Add(this.pBar_Smithing);
            this.tab_Strength.Controls.Add(this.pBar_Harvesting);
            this.tab_Strength.Controls.Add(this.pBar_Mining);
            this.tab_Strength.Controls.Add(this.pBar_Strength);
            this.tab_Strength.Location = new System.Drawing.Point(4, 30);
            this.tab_Strength.Name = "tab_Strength";
            this.tab_Strength.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Strength.Size = new System.Drawing.Size(424, 294);
            this.tab_Strength.TabIndex = 0;
            this.tab_Strength.Text = "Strength";
            // 
            // nud_Smithing
            // 
            this.nud_Smithing.Enabled = false;
            this.nud_Smithing.Location = new System.Drawing.Point(312, 248);
            this.nud_Smithing.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Smithing.Name = "nud_Smithing";
            this.nud_Smithing.Size = new System.Drawing.Size(64, 27);
            this.nud_Smithing.TabIndex = 10;
            this.nud_Smithing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Smithing.ValueChanged += new System.EventHandler(this.Nud_SmithingValueChanged);
            // 
            // nud_Harvesting
            // 
            this.nud_Harvesting.Enabled = false;
            this.nud_Harvesting.Location = new System.Drawing.Point(312, 192);
            this.nud_Harvesting.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Harvesting.Name = "nud_Harvesting";
            this.nud_Harvesting.Size = new System.Drawing.Size(64, 27);
            this.nud_Harvesting.TabIndex = 9;
            this.nud_Harvesting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Harvesting.ValueChanged += new System.EventHandler(this.Nud_HarvestingValueChanged);
            // 
            // nud_Mining
            // 
            this.nud_Mining.Enabled = false;
            this.nud_Mining.Location = new System.Drawing.Point(312, 136);
            this.nud_Mining.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Mining.Name = "nud_Mining";
            this.nud_Mining.Size = new System.Drawing.Size(64, 27);
            this.nud_Mining.TabIndex = 8;
            this.nud_Mining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Mining.ValueChanged += new System.EventHandler(this.Nud_MiningValueChanged);
            // 
            // nud_Melee
            // 
            this.nud_Melee.Enabled = false;
            this.nud_Melee.Location = new System.Drawing.Point(312, 80);
            this.nud_Melee.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Melee.Name = "nud_Melee";
            this.nud_Melee.Size = new System.Drawing.Size(64, 27);
            this.nud_Melee.TabIndex = 7;
            this.nud_Melee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Melee.ValueChanged += new System.EventHandler(this.Nud_MeleeValueChanged);
            // 
            // nud_Strength
            // 
            this.nud_Strength.Enabled = false;
            this.nud_Strength.Location = new System.Drawing.Point(312, 24);
            this.nud_Strength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Strength.Name = "nud_Strength";
            this.nud_Strength.Size = new System.Drawing.Size(64, 27);
            this.nud_Strength.TabIndex = 6;
            this.nud_Strength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Strength.ValueChanged += new System.EventHandler(this.Nud_StrengthValueChanged);
            // 
            // pBar_Melee
            // 
            this.pBar_Melee.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Melee.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Melee.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Melee.ColorText = System.Drawing.Color.Black;
            this.pBar_Melee.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Melee.Location = new System.Drawing.Point(16, 72);
            this.pBar_Melee.Name = "pBar_Melee";
            this.pBar_Melee.Position = 0;
            this.pBar_Melee.PositionMax = 100;
            this.pBar_Melee.PositionMin = 0;
            this.pBar_Melee.Size = new System.Drawing.Size(234, 29);
            this.pBar_Melee.SteepDistance = ((byte)(0));
            this.pBar_Melee.TabIndex = 5;
            this.pBar_Melee.Text = "Melee";
            this.pBar_Melee.TextShadow = false;
            // 
            // pBar_Smithing
            // 
            this.pBar_Smithing.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Smithing.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Smithing.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Smithing.ColorText = System.Drawing.Color.Black;
            this.pBar_Smithing.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Smithing.Location = new System.Drawing.Point(16, 240);
            this.pBar_Smithing.Name = "pBar_Smithing";
            this.pBar_Smithing.Position = 0;
            this.pBar_Smithing.PositionMax = 100;
            this.pBar_Smithing.PositionMin = 0;
            this.pBar_Smithing.Size = new System.Drawing.Size(234, 29);
            this.pBar_Smithing.SteepDistance = ((byte)(0));
            this.pBar_Smithing.TabIndex = 4;
            this.pBar_Smithing.Text = "Smithing";
            this.pBar_Smithing.TextShadow = false;
            // 
            // pBar_Harvesting
            // 
            this.pBar_Harvesting.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Harvesting.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Harvesting.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Harvesting.ColorText = System.Drawing.Color.Black;
            this.pBar_Harvesting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Harvesting.Location = new System.Drawing.Point(16, 184);
            this.pBar_Harvesting.Name = "pBar_Harvesting";
            this.pBar_Harvesting.Position = 0;
            this.pBar_Harvesting.PositionMax = 100;
            this.pBar_Harvesting.PositionMin = 0;
            this.pBar_Harvesting.Size = new System.Drawing.Size(234, 29);
            this.pBar_Harvesting.SteepDistance = ((byte)(0));
            this.pBar_Harvesting.TabIndex = 3;
            this.pBar_Harvesting.Text = "Harvesting";
            this.pBar_Harvesting.TextShadow = false;
            // 
            // pBar_Mining
            // 
            this.pBar_Mining.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Mining.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Mining.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Mining.ColorText = System.Drawing.Color.Black;
            this.pBar_Mining.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Mining.Location = new System.Drawing.Point(16, 128);
            this.pBar_Mining.Name = "pBar_Mining";
            this.pBar_Mining.Position = 0;
            this.pBar_Mining.PositionMax = 100;
            this.pBar_Mining.PositionMin = 0;
            this.pBar_Mining.Size = new System.Drawing.Size(234, 29);
            this.pBar_Mining.SteepDistance = ((byte)(0));
            this.pBar_Mining.TabIndex = 2;
            this.pBar_Mining.Text = "Mining";
            this.pBar_Mining.TextShadow = false;
            // 
            // pBar_Strength
            // 
            this.pBar_Strength.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Strength.ColorBarBorder = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(240)))), ((int)(((byte)(170)))));
            this.pBar_Strength.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(10)))));
            this.pBar_Strength.ColorText = System.Drawing.Color.Black;
            this.pBar_Strength.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Strength.Location = new System.Drawing.Point(16, 16);
            this.pBar_Strength.Name = "pBar_Strength";
            this.pBar_Strength.Position = 0;
            this.pBar_Strength.PositionMax = 100;
            this.pBar_Strength.PositionMin = 0;
            this.pBar_Strength.Size = new System.Drawing.Size(234, 29);
            this.pBar_Strength.SteepDistance = ((byte)(0));
            this.pBar_Strength.TabIndex = 0;
            this.pBar_Strength.Text = "Strength";
            this.pBar_Strength.TextShadow = false;
            // 
            // tab_Dexterity
            // 
            this.tab_Dexterity.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tab_Dexterity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Dexterity.Controls.Add(this.nud_Cooking);
            this.tab_Dexterity.Controls.Add(this.nud_Tailoring);
            this.tab_Dexterity.Controls.Add(this.nud_Ranching);
            this.tab_Dexterity.Controls.Add(this.nud_Marksman);
            this.tab_Dexterity.Controls.Add(this.nud_Dexterity);
            this.tab_Dexterity.Controls.Add(this.pBar_Marksman);
            this.tab_Dexterity.Controls.Add(this.pBar_Cooking);
            this.tab_Dexterity.Controls.Add(this.pBar_Tailoring);
            this.tab_Dexterity.Controls.Add(this.pBar_Ranching);
            this.tab_Dexterity.Controls.Add(this.pBar_Dexterity);
            this.tab_Dexterity.Location = new System.Drawing.Point(4, 30);
            this.tab_Dexterity.Name = "tab_Dexterity";
            this.tab_Dexterity.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Dexterity.Size = new System.Drawing.Size(424, 294);
            this.tab_Dexterity.TabIndex = 1;
            this.tab_Dexterity.Text = "Dexterity";
            // 
            // nud_Cooking
            // 
            this.nud_Cooking.Enabled = false;
            this.nud_Cooking.Location = new System.Drawing.Point(312, 248);
            this.nud_Cooking.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Cooking.Name = "nud_Cooking";
            this.nud_Cooking.Size = new System.Drawing.Size(64, 27);
            this.nud_Cooking.TabIndex = 10;
            this.nud_Cooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Cooking.ValueChanged += new System.EventHandler(this.Nud_CookingValueChanged);
            // 
            // nud_Tailoring
            // 
            this.nud_Tailoring.Enabled = false;
            this.nud_Tailoring.Location = new System.Drawing.Point(312, 192);
            this.nud_Tailoring.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Tailoring.Name = "nud_Tailoring";
            this.nud_Tailoring.Size = new System.Drawing.Size(64, 27);
            this.nud_Tailoring.TabIndex = 9;
            this.nud_Tailoring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Tailoring.ValueChanged += new System.EventHandler(this.Nud_TailoringValueChanged);
            // 
            // nud_Ranching
            // 
            this.nud_Ranching.Enabled = false;
            this.nud_Ranching.Location = new System.Drawing.Point(312, 136);
            this.nud_Ranching.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Ranching.Name = "nud_Ranching";
            this.nud_Ranching.Size = new System.Drawing.Size(64, 27);
            this.nud_Ranching.TabIndex = 8;
            this.nud_Ranching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Ranching.ValueChanged += new System.EventHandler(this.Nud_RanchingValueChanged);
            // 
            // nud_Marksman
            // 
            this.nud_Marksman.Enabled = false;
            this.nud_Marksman.Location = new System.Drawing.Point(312, 80);
            this.nud_Marksman.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Marksman.Name = "nud_Marksman";
            this.nud_Marksman.Size = new System.Drawing.Size(64, 27);
            this.nud_Marksman.TabIndex = 7;
            this.nud_Marksman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Marksman.ValueChanged += new System.EventHandler(this.Nud_MarksmanValueChanged);
            // 
            // nud_Dexterity
            // 
            this.nud_Dexterity.Enabled = false;
            this.nud_Dexterity.Location = new System.Drawing.Point(312, 24);
            this.nud_Dexterity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Dexterity.Name = "nud_Dexterity";
            this.nud_Dexterity.Size = new System.Drawing.Size(64, 27);
            this.nud_Dexterity.TabIndex = 6;
            this.nud_Dexterity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Dexterity.ValueChanged += new System.EventHandler(this.Nud_DexterityValueChanged);
            // 
            // pBar_Marksman
            // 
            this.pBar_Marksman.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Marksman.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Marksman.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Marksman.ColorText = System.Drawing.Color.Black;
            this.pBar_Marksman.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Marksman.Location = new System.Drawing.Point(16, 72);
            this.pBar_Marksman.Name = "pBar_Marksman";
            this.pBar_Marksman.Position = 0;
            this.pBar_Marksman.PositionMax = 100;
            this.pBar_Marksman.PositionMin = 0;
            this.pBar_Marksman.Size = new System.Drawing.Size(234, 29);
            this.pBar_Marksman.SteepDistance = ((byte)(0));
            this.pBar_Marksman.TabIndex = 5;
            this.pBar_Marksman.Text = "Marksman";
            this.pBar_Marksman.TextShadow = false;
            // 
            // pBar_Cooking
            // 
            this.pBar_Cooking.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Cooking.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Cooking.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Cooking.ColorText = System.Drawing.Color.Black;
            this.pBar_Cooking.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Cooking.Location = new System.Drawing.Point(16, 240);
            this.pBar_Cooking.Name = "pBar_Cooking";
            this.pBar_Cooking.Position = 0;
            this.pBar_Cooking.PositionMax = 100;
            this.pBar_Cooking.PositionMin = 0;
            this.pBar_Cooking.Size = new System.Drawing.Size(234, 29);
            this.pBar_Cooking.SteepDistance = ((byte)(0));
            this.pBar_Cooking.TabIndex = 4;
            this.pBar_Cooking.Text = "Cooking";
            this.pBar_Cooking.TextShadow = false;
            // 
            // pBar_Tailoring
            // 
            this.pBar_Tailoring.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Tailoring.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Tailoring.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Tailoring.ColorText = System.Drawing.Color.Black;
            this.pBar_Tailoring.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Tailoring.Location = new System.Drawing.Point(16, 184);
            this.pBar_Tailoring.Name = "pBar_Tailoring";
            this.pBar_Tailoring.Position = 0;
            this.pBar_Tailoring.PositionMax = 100;
            this.pBar_Tailoring.PositionMin = 0;
            this.pBar_Tailoring.Size = new System.Drawing.Size(234, 29);
            this.pBar_Tailoring.SteepDistance = ((byte)(0));
            this.pBar_Tailoring.TabIndex = 3;
            this.pBar_Tailoring.Text = "Tailoring";
            this.pBar_Tailoring.TextShadow = false;
            // 
            // pBar_Ranching
            // 
            this.pBar_Ranching.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Ranching.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Ranching.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Ranching.ColorText = System.Drawing.Color.Black;
            this.pBar_Ranching.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Ranching.Location = new System.Drawing.Point(16, 128);
            this.pBar_Ranching.Name = "pBar_Ranching";
            this.pBar_Ranching.Position = 0;
            this.pBar_Ranching.PositionMax = 100;
            this.pBar_Ranching.PositionMin = 0;
            this.pBar_Ranching.Size = new System.Drawing.Size(234, 29);
            this.pBar_Ranching.SteepDistance = ((byte)(0));
            this.pBar_Ranching.TabIndex = 2;
            this.pBar_Ranching.Text = "Ranching";
            this.pBar_Ranching.TextShadow = false;
            // 
            // pBar_Dexterity
            // 
            this.pBar_Dexterity.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Dexterity.ColorBarBorder = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(240)))), ((int)(((byte)(170)))));
            this.pBar_Dexterity.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(10)))));
            this.pBar_Dexterity.ColorText = System.Drawing.Color.Black;
            this.pBar_Dexterity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Dexterity.Location = new System.Drawing.Point(16, 16);
            this.pBar_Dexterity.Name = "pBar_Dexterity";
            this.pBar_Dexterity.Position = 0;
            this.pBar_Dexterity.PositionMax = 100;
            this.pBar_Dexterity.PositionMin = 0;
            this.pBar_Dexterity.Size = new System.Drawing.Size(234, 29);
            this.pBar_Dexterity.SteepDistance = ((byte)(0));
            this.pBar_Dexterity.TabIndex = 0;
            this.pBar_Dexterity.Text = "Dexterity";
            this.pBar_Dexterity.TextShadow = false;
            // 
            // tab_Knowledge
            // 
            this.tab_Knowledge.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tab_Knowledge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Knowledge.Controls.Add(this.nud_Manufacturing);
            this.tab_Knowledge.Controls.Add(this.nud_Guile);
            this.tab_Knowledge.Controls.Add(this.nud_Engineering);
            this.tab_Knowledge.Controls.Add(this.nud_Alchemy);
            this.tab_Knowledge.Controls.Add(this.nud_Knowledge);
            this.tab_Knowledge.Controls.Add(this.pBar_Alchemy);
            this.tab_Knowledge.Controls.Add(this.pBar_Manufacturing);
            this.tab_Knowledge.Controls.Add(this.pBar_Guile);
            this.tab_Knowledge.Controls.Add(this.pBar_Engineering);
            this.tab_Knowledge.Controls.Add(this.pBar_Knowledge);
            this.tab_Knowledge.Location = new System.Drawing.Point(4, 30);
            this.tab_Knowledge.Name = "tab_Knowledge";
            this.tab_Knowledge.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Knowledge.Size = new System.Drawing.Size(424, 294);
            this.tab_Knowledge.TabIndex = 3;
            this.tab_Knowledge.Text = "Knowledge";
            // 
            // nud_Manufacturing
            // 
            this.nud_Manufacturing.Enabled = false;
            this.nud_Manufacturing.Location = new System.Drawing.Point(312, 248);
            this.nud_Manufacturing.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Manufacturing.Name = "nud_Manufacturing";
            this.nud_Manufacturing.Size = new System.Drawing.Size(64, 27);
            this.nud_Manufacturing.TabIndex = 10;
            this.nud_Manufacturing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Manufacturing.ValueChanged += new System.EventHandler(this.nud_Manufacturing_ValueChanged);
            // 
            // nud_Guile
            // 
            this.nud_Guile.Enabled = false;
            this.nud_Guile.Location = new System.Drawing.Point(312, 192);
            this.nud_Guile.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Guile.Name = "nud_Guile";
            this.nud_Guile.Size = new System.Drawing.Size(64, 27);
            this.nud_Guile.TabIndex = 9;
            this.nud_Guile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Guile.ValueChanged += new System.EventHandler(this.nud_Guile_ValueChanged);
            // 
            // nud_Engineering
            // 
            this.nud_Engineering.Enabled = false;
            this.nud_Engineering.Location = new System.Drawing.Point(312, 136);
            this.nud_Engineering.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Engineering.Name = "nud_Engineering";
            this.nud_Engineering.Size = new System.Drawing.Size(64, 27);
            this.nud_Engineering.TabIndex = 8;
            this.nud_Engineering.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Engineering.ValueChanged += new System.EventHandler(this.nud_Engineering_ValueChanged);
            // 
            // nud_Alchemy
            // 
            this.nud_Alchemy.Enabled = false;
            this.nud_Alchemy.Location = new System.Drawing.Point(312, 80);
            this.nud_Alchemy.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Alchemy.Name = "nud_Alchemy";
            this.nud_Alchemy.Size = new System.Drawing.Size(64, 27);
            this.nud_Alchemy.TabIndex = 7;
            this.nud_Alchemy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Alchemy.ValueChanged += new System.EventHandler(this.nud_Alchemy_ValueChanged);
            // 
            // nud_Knowledge
            // 
            this.nud_Knowledge.Enabled = false;
            this.nud_Knowledge.Location = new System.Drawing.Point(312, 24);
            this.nud_Knowledge.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Knowledge.Name = "nud_Knowledge";
            this.nud_Knowledge.Size = new System.Drawing.Size(64, 27);
            this.nud_Knowledge.TabIndex = 6;
            this.nud_Knowledge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Knowledge.ValueChanged += new System.EventHandler(this.nud_Knowledge_ValueChanged);
            // 
            // pBar_Alchemy
            // 
            this.pBar_Alchemy.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Alchemy.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Alchemy.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Alchemy.ColorText = System.Drawing.Color.Black;
            this.pBar_Alchemy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Alchemy.Location = new System.Drawing.Point(16, 72);
            this.pBar_Alchemy.Name = "pBar_Alchemy";
            this.pBar_Alchemy.Position = 0;
            this.pBar_Alchemy.PositionMax = 100;
            this.pBar_Alchemy.PositionMin = 0;
            this.pBar_Alchemy.Size = new System.Drawing.Size(234, 29);
            this.pBar_Alchemy.SteepDistance = ((byte)(0));
            this.pBar_Alchemy.TabIndex = 5;
            this.pBar_Alchemy.Text = "Alchemy";
            this.pBar_Alchemy.TextShadow = false;
            // 
            // pBar_Manufacturing
            // 
            this.pBar_Manufacturing.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Manufacturing.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Manufacturing.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Manufacturing.ColorText = System.Drawing.Color.Black;
            this.pBar_Manufacturing.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Manufacturing.Location = new System.Drawing.Point(16, 240);
            this.pBar_Manufacturing.Name = "pBar_Manufacturing";
            this.pBar_Manufacturing.Position = 0;
            this.pBar_Manufacturing.PositionMax = 100;
            this.pBar_Manufacturing.PositionMin = 0;
            this.pBar_Manufacturing.Size = new System.Drawing.Size(234, 29);
            this.pBar_Manufacturing.SteepDistance = ((byte)(0));
            this.pBar_Manufacturing.TabIndex = 4;
            this.pBar_Manufacturing.Text = "Manufacturing";
            this.pBar_Manufacturing.TextShadow = false;
            // 
            // pBar_Guile
            // 
            this.pBar_Guile.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Guile.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Guile.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Guile.ColorText = System.Drawing.Color.Black;
            this.pBar_Guile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Guile.Location = new System.Drawing.Point(16, 184);
            this.pBar_Guile.Name = "pBar_Guile";
            this.pBar_Guile.Position = 0;
            this.pBar_Guile.PositionMax = 100;
            this.pBar_Guile.PositionMin = 0;
            this.pBar_Guile.Size = new System.Drawing.Size(234, 29);
            this.pBar_Guile.SteepDistance = ((byte)(0));
            this.pBar_Guile.TabIndex = 3;
            this.pBar_Guile.Text = "Guile";
            this.pBar_Guile.TextShadow = false;
            // 
            // pBar_Engineering
            // 
            this.pBar_Engineering.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Engineering.ColorBarBorder = System.Drawing.Color.PaleTurquoise;
            this.pBar_Engineering.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBar_Engineering.ColorText = System.Drawing.Color.Black;
            this.pBar_Engineering.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Engineering.Location = new System.Drawing.Point(16, 128);
            this.pBar_Engineering.Name = "pBar_Engineering";
            this.pBar_Engineering.Position = 0;
            this.pBar_Engineering.PositionMax = 100;
            this.pBar_Engineering.PositionMin = 0;
            this.pBar_Engineering.Size = new System.Drawing.Size(234, 29);
            this.pBar_Engineering.SteepDistance = ((byte)(0));
            this.pBar_Engineering.TabIndex = 2;
            this.pBar_Engineering.Text = "Engineering";
            this.pBar_Engineering.TextShadow = false;
            // 
            // pBar_Knowledge
            // 
            this.pBar_Knowledge.ColorBackGround = System.Drawing.Color.White;
            this.pBar_Knowledge.ColorBarBorder = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(240)))), ((int)(((byte)(170)))));
            this.pBar_Knowledge.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(10)))));
            this.pBar_Knowledge.ColorText = System.Drawing.Color.Black;
            this.pBar_Knowledge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar_Knowledge.Location = new System.Drawing.Point(16, 16);
            this.pBar_Knowledge.Name = "pBar_Knowledge";
            this.pBar_Knowledge.Position = 0;
            this.pBar_Knowledge.PositionMax = 100;
            this.pBar_Knowledge.PositionMin = 0;
            this.pBar_Knowledge.Size = new System.Drawing.Size(234, 29);
            this.pBar_Knowledge.SteepDistance = ((byte)(0));
            this.pBar_Knowledge.TabIndex = 0;
            this.pBar_Knowledge.Text = "Knowledge";
            this.pBar_Knowledge.TextShadow = false;
            // 
            // picBox_Banner
            // 
            this.picBox_Banner.BackColor = System.Drawing.Color.Transparent;            
            this.picBox_Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Banner.Location = new System.Drawing.Point(574, 38);
            this.picBox_Banner.Name = "picBox_Banner";
            this.picBox_Banner.Size = new System.Drawing.Size(156, 529);
            this.picBox_Banner.TabIndex = 17;
            this.picBox_Banner.TabStop = false;
            // 
            // picBox_Race
            // 
            this.picBox_Race.BackColor = System.Drawing.Color.Gray;
            this.picBox_Race.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Race.Location = new System.Drawing.Point(615, 74);
            this.picBox_Race.Name = "picBox_Race";
            this.picBox_Race.Size = new System.Drawing.Size(70, 70);
            this.picBox_Race.TabIndex = 18;
            this.picBox_Race.TabStop = false;
            // 
            // picBox_Gender
            // 
            this.picBox_Gender.BackColor = System.Drawing.Color.Gray;
            this.picBox_Gender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Gender.Location = new System.Drawing.Point(615, 159);
            this.picBox_Gender.Name = "picBox_Gender";
            this.picBox_Gender.Size = new System.Drawing.Size(70, 70);
            this.picBox_Gender.TabIndex = 19;
            this.picBox_Gender.TabStop = false;
            // 
            // picBox_Condition
            // 
            this.picBox_Condition.BackColor = System.Drawing.Color.Gray;
            this.picBox_Condition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Condition.Location = new System.Drawing.Point(615, 246);
            this.picBox_Condition.Name = "picBox_Condition";
            this.picBox_Condition.Size = new System.Drawing.Size(70, 70);
            this.picBox_Condition.TabIndex = 20;
            this.picBox_Condition.TabStop = false;
            // 
            // picBox_SpCondition
            // 
            this.picBox_SpCondition.BackColor = System.Drawing.Color.Gray;
            this.picBox_SpCondition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_SpCondition.Location = new System.Drawing.Point(615, 333);
            this.picBox_SpCondition.Name = "picBox_SpCondition";
            this.picBox_SpCondition.Size = new System.Drawing.Size(70, 70);
            this.picBox_SpCondition.TabIndex = 21;
            this.picBox_SpCondition.TabStop = false;
            // 
            // grpBox_Birthday
            // 
            this.grpBox_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Birthday.Controls.Add(this.btn_EditBirthday);
            this.grpBox_Birthday.Controls.Add(this.txtBox_Birthday);
            this.grpBox_Birthday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Birthday.Location = new System.Drawing.Point(104, 370);
            this.grpBox_Birthday.Name = "grpBox_Birthday";
            this.grpBox_Birthday.Size = new System.Drawing.Size(224, 64);
            this.grpBox_Birthday.TabIndex = 22;
            this.grpBox_Birthday.TabStop = false;
            this.grpBox_Birthday.Text = "Birthday";
            // 
            // btn_EditBirthday
            //             
            this.btn_EditBirthday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditBirthday.Location = new System.Drawing.Point(176, 24);
            this.btn_EditBirthday.Name = "btn_EditBirthday";
            this.btn_EditBirthday.Size = new System.Drawing.Size(30, 30);
            this.btn_EditBirthday.TabIndex = 2;
            this.btn_EditBirthday.UseVisualStyleBackColor = true;
            this.btn_EditBirthday.Click += new System.EventHandler(this.Btn_EditBirthdayClick);
            // 
            // txtBox_Birthday
            // 
            this.txtBox_Birthday.Enabled = false;
            this.txtBox_Birthday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Birthday.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Birthday.Name = "txtBox_Birthday";
            this.txtBox_Birthday.Size = new System.Drawing.Size(128, 27);
            this.txtBox_Birthday.TabIndex = 1;
            this.txtBox_Birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBox_DeathDay
            // 
            this.grpBox_DeathDay.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_DeathDay.Controls.Add(this.btn_EditDeathday);
            this.grpBox_DeathDay.Controls.Add(this.txtBox_Deathday);
            this.grpBox_DeathDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_DeathDay.Location = new System.Drawing.Point(104, 450);
            this.grpBox_DeathDay.Name = "grpBox_DeathDay";
            this.grpBox_DeathDay.Size = new System.Drawing.Size(224, 64);
            this.grpBox_DeathDay.TabIndex = 23;
            this.grpBox_DeathDay.TabStop = false;
            this.grpBox_DeathDay.Text = "Deathday";
            // 
            // btn_EditDeathday
            //             
            this.btn_EditDeathday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditDeathday.Location = new System.Drawing.Point(176, 24);
            this.btn_EditDeathday.Name = "btn_EditDeathday";
            this.btn_EditDeathday.Size = new System.Drawing.Size(30, 30);
            this.btn_EditDeathday.TabIndex = 3;
            this.btn_EditDeathday.UseVisualStyleBackColor = true;
            this.btn_EditDeathday.Click += new System.EventHandler(this.Btn_EditDeathdayClick);
            // 
            // txtBox_Deathday
            // 
            this.txtBox_Deathday.Enabled = false;
            this.txtBox_Deathday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Deathday.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Deathday.Name = "txtBox_Deathday";
            this.txtBox_Deathday.Size = new System.Drawing.Size(128, 27);
            this.txtBox_Deathday.TabIndex = 1;
            this.txtBox_Deathday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(38, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LoadPictore
            //             
            this.btn_LoadPicture.Location = new System.Drawing.Point(8, 30);
            this.btn_LoadPicture.Name = "btn_LoadPictore";
            this.btn_LoadPicture.Size = new System.Drawing.Size(23, 23);
            this.btn_LoadPicture.TabIndex = 25;
            this.btn_LoadPicture.UseVisualStyleBackColor = true;
            this.btn_LoadPicture.Click += new System.EventHandler(this.btn_LoadPictore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_DiscardPicture);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_LoadPicture);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(360, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Picture";
            // 
            // btn_DiscardPicture
            //             
            this.btn_DiscardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DiscardPicture.Location = new System.Drawing.Point(8, 59);
            this.btn_DiscardPicture.Name = "btn_DiscardPicture";
            this.btn_DiscardPicture.Size = new System.Drawing.Size(23, 23);
            this.btn_DiscardPicture.TabIndex = 26;
            this.btn_DiscardPicture.UseVisualStyleBackColor = true;
            this.btn_DiscardPicture.Click += new System.EventHandler(this.btn_DiscardPicture_Click);
            // 
            // FrmCharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;            
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 994);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_DeathDay);
            this.Controls.Add(this.grpBox_Birthday);
            this.Controls.Add(this.picBox_SpCondition);
            this.Controls.Add(this.picBox_Condition);
            this.Controls.Add(this.picBox_Gender);
            this.Controls.Add(this.picBox_Race);
            this.Controls.Add(this.picBox_Banner);
            this.Controls.Add(this.grpBox_SkillTracker);
            this.Controls.Add(this.grpBox_FamilyTies);
            this.Controls.Add(this.lbl_Characer);
            this.Controls.Add(this.grpBox_Alive);
            this.Controls.Add(this.grpBox_Description);
            this.Controls.Add(this.grpBox_SpCondition);
            this.Controls.Add(this.grpBox_Condition);
            this.Controls.Add(this.grpBox_Gender);
            this.Controls.Add(this.grpBox_Race);
            this.Controls.Add(this.nud_Age);
            this.Controls.Add(this.grpBox_Edit);
            this.Controls.Add(this.grpBox_Age);
            this.Controls.Add(this.grpBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCharacterSheet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmViewCharFormClosing);
            this.Load += new System.EventHandler(this.FrmViewCharLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmViewCharKeyDown);
            this.grpBox_Name.ResumeLayout(false);
            this.grpBox_Name.PerformLayout();
            this.grpBox_Age.ResumeLayout(false);
            this.grpBox_Age.PerformLayout();
            this.grpBox_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).EndInit();
            this.grpBox_Race.ResumeLayout(false);
            this.grpBox_Gender.ResumeLayout(false);
            this.grpBox_Condition.ResumeLayout(false);
            this.grpBox_SpCondition.ResumeLayout(false);
            this.grpBox_Description.ResumeLayout(false);
            this.grpBox_Alive.ResumeLayout(false);
            this.grpBox_FamilyTies.ResumeLayout(false);
            this.grpBox_FamilyNode.ResumeLayout(false);
            this.grpBox_FamilyNode.PerformLayout();
            this.grpBox_SkillTracker.ResumeLayout(false);
            this.tabControl_Skills.ResumeLayout(false);
            this.tab_Strength.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Smithing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Harvesting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Mining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Melee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Strength)).EndInit();
            this.tab_Dexterity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tailoring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ranching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Marksman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dexterity)).EndInit();
            this.tab_Knowledge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Manufacturing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Guile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Engineering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alchemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Knowledge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Race)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Condition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_SpCondition)).EndInit();
            this.grpBox_Birthday.ResumeLayout(false);
            this.grpBox_Birthday.PerformLayout();
            this.grpBox_DeathDay.ResumeLayout(false);
            this.grpBox_DeathDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private System.Windows.Forms.GroupBox grpBox_Edit;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.NumericUpDown nud_Age;
        private System.Windows.Forms.ComboBox cmbBox_Race;
        private System.Windows.Forms.GroupBox grpBox_Race;
        private System.Windows.Forms.GroupBox grpBox_Gender;
        private System.Windows.Forms.ComboBox cmbBox_Gender;
        private System.Windows.Forms.GroupBox grpBox_Condition;
        private System.Windows.Forms.ComboBox cmbBox_Condition;
        private System.Windows.Forms.GroupBox grpBox_SpCondition;
        private System.Windows.Forms.ComboBox cmbBox_SpCondition;
        private System.Windows.Forms.GroupBox grpBox_Description;
        private System.Windows.Forms.GroupBox grpBox_Alive;
        private System.Windows.Forms.ComboBox cmbBox_IsAlive;
        private System.Windows.Forms.Button btn_Bold;
        private System.Windows.Forms.Button btn_Italic;
        private System.Windows.Forms.Button btn_Underline;
        private System.Windows.Forms.Label lbl_Characer;
        private System.Windows.Forms.GroupBox grpBox_FamilyTies;
        private System.Windows.Forms.GroupBox grpBox_SkillTracker;
        private System.Windows.Forms.TabControl tabControl_Skills;
        private System.Windows.Forms.TabPage tab_Strength;
        private System.Windows.Forms.TabPage tab_Dexterity;
        private Framework.Controls.XpProgressBar pBar_Strength;
        private Framework.Controls.XpProgressBar pBar_Smithing;
        private Framework.Controls.XpProgressBar pBar_Harvesting;
        private Framework.Controls.XpProgressBar pBar_Mining;
        private Framework.Controls.XpProgressBar pBar_Melee;
        private System.Windows.Forms.NumericUpDown nud_Strength;
        private System.Windows.Forms.NumericUpDown nud_Smithing;
        private System.Windows.Forms.NumericUpDown nud_Harvesting;
        private System.Windows.Forms.NumericUpDown nud_Mining;
        private System.Windows.Forms.NumericUpDown nud_Melee;
        private System.Windows.Forms.NumericUpDown nud_Cooking;
        private System.Windows.Forms.NumericUpDown nud_Tailoring;
        private System.Windows.Forms.NumericUpDown nud_Ranching;
        private System.Windows.Forms.NumericUpDown nud_Marksman;
        private System.Windows.Forms.NumericUpDown nud_Dexterity;
        private Framework.Controls.XpProgressBar pBar_Marksman;
        private Framework.Controls.XpProgressBar pBar_Cooking;
        private Framework.Controls.XpProgressBar pBar_Tailoring;
        private Framework.Controls.XpProgressBar pBar_Ranching;
        private Framework.Controls.XpProgressBar pBar_Dexterity;
        private System.Windows.Forms.TabPage tab_Knowledge;
        private System.Windows.Forms.NumericUpDown nud_Manufacturing;
        private System.Windows.Forms.NumericUpDown nud_Guile;
        private System.Windows.Forms.NumericUpDown nud_Engineering;
        private System.Windows.Forms.NumericUpDown nud_Alchemy;
        private System.Windows.Forms.NumericUpDown nud_Knowledge;
        private Framework.Controls.XpProgressBar pBar_Alchemy;
        private Framework.Controls.XpProgressBar pBar_Manufacturing;
        private Framework.Controls.XpProgressBar pBar_Guile;
        private Framework.Controls.XpProgressBar pBar_Engineering;
        private Framework.Controls.XpProgressBar pBar_Knowledge;
        private System.Windows.Forms.TreeView tv_Family;
        private System.Windows.Forms.Button btn_RmvFamilyTie;
        private System.Windows.Forms.ComboBox cmbBox_Characters;
        private System.Windows.Forms.Button btn_AddFamilyTie;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picBox_Banner;
        private System.Windows.Forms.PictureBox picBox_Race;
        private System.Windows.Forms.PictureBox picBox_Gender;
        private System.Windows.Forms.PictureBox picBox_Condition;
        private System.Windows.Forms.PictureBox picBox_SpCondition;
        private System.Windows.Forms.GroupBox grpBox_FamilyNode;
        private System.Windows.Forms.Label lbl_FamilyNode;
        private System.Windows.Forms.GroupBox grpBox_Birthday;
        private System.Windows.Forms.TextBox txtBox_Deathday;
        private System.Windows.Forms.TextBox txtBox_Birthday;
        private System.Windows.Forms.GroupBox grpBox_DeathDay;
        private System.Windows.Forms.Button btn_EditBirthday;
        private System.Windows.Forms.Button btn_EditDeathday;
		private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LoadPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DiscardPicture;
    }
}
