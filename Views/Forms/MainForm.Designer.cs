/*
 * Created by SharpDevelop.
 * User: 107
 * Date: 11/9/2022
 * Time: 13:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Views
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btn_Characters;
        private System.Windows.Forms.Button btn_Mapper;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_Credits;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.btn_Characters = new System.Windows.Forms.Button();
        	this.btn_Mapper = new System.Windows.Forms.Button();
        	this.btn_Options = new System.Windows.Forms.Button();
        	this.btn_Exit = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.btn_Credits = new System.Windows.Forms.Button();
        	this.btn_Books = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.lbl_MaroDate = new System.Windows.Forms.Label();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btn_Characters
        	// 
        	this.btn_Characters.BackColor = System.Drawing.SystemColors.Control;
        	this.btn_Characters.BackgroundImage = global::Maro_MVP.Resources.glossy_background_hd_wallpaper_wallpaper_preview;
        	this.btn_Characters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.btn_Characters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Characters.Location = new System.Drawing.Point(9, 75);
        	this.btn_Characters.Name = "btn_Characters";
        	this.btn_Characters.Size = new System.Drawing.Size(141, 36);
        	this.btn_Characters.TabIndex = 0;
        	this.btn_Characters.Text = "Characters";
        	this.btn_Characters.UseVisualStyleBackColor = false;
        	this.btn_Characters.Click += new System.EventHandler(this.Btn_CharactersClick);
        	// 
        	// btn_Mapper
        	// 
        	this.btn_Mapper.BackColor = System.Drawing.SystemColors.Control;
        	this.btn_Mapper.BackgroundImage = global::Maro_MVP.Resources.glossy_background_hd_wallpaper_wallpaper_preview;
        	this.btn_Mapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.btn_Mapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Mapper.Location = new System.Drawing.Point(9, 144);
        	this.btn_Mapper.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
        	this.btn_Mapper.Name = "btn_Mapper";
        	this.btn_Mapper.Size = new System.Drawing.Size(141, 36);
        	this.btn_Mapper.TabIndex = 1;
        	this.btn_Mapper.Text = "Mapper";
        	this.btn_Mapper.UseVisualStyleBackColor = false;
        	this.btn_Mapper.Click += new System.EventHandler(this.Btn_MapperClick);
        	// 
        	// btn_Options
        	// 
        	this.btn_Options.BackColor = System.Drawing.SystemColors.Control;
        	this.btn_Options.BackgroundImage = global::Maro_MVP.Resources.glossy_background_hd_wallpaper_wallpaper_preview;
        	this.btn_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.btn_Options.Enabled = false;
        	this.btn_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Options.Location = new System.Drawing.Point(8, 360);
        	this.btn_Options.Name = "btn_Options";
        	this.btn_Options.Size = new System.Drawing.Size(141, 36);
        	this.btn_Options.TabIndex = 2;
        	this.btn_Options.Text = "Options";
        	this.btn_Options.UseVisualStyleBackColor = false;
        	this.btn_Options.Click += new System.EventHandler(this.Btn_OptionsClick);
        	// 
        	// btn_Exit
        	// 
        	this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
        	this.btn_Exit.BackgroundImage = global::Maro_MVP.Resources._6954909_navy_marble_blue_marble_blue_granite_marble_wallpaper_by_jenlats22;
        	this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Exit.Location = new System.Drawing.Point(8, 416);
        	this.btn_Exit.Name = "btn_Exit";
        	this.btn_Exit.Size = new System.Drawing.Size(141, 36);
        	this.btn_Exit.TabIndex = 3;
        	this.btn_Exit.Text = "Exit";
        	this.btn_Exit.UseVisualStyleBackColor = false;
        	this.btn_Exit.Click += new System.EventHandler(this.Btn_ExitClick);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.groupBox1.BackgroundImage = global::Maro_MVP.Resources.aaf8c99e04d0a36f6aaaed0baf9183c6;
        	this.groupBox1.Controls.Add(this.btn_Credits);
        	this.groupBox1.Controls.Add(this.btn_Books);
        	this.groupBox1.Controls.Add(this.btn_Characters);
        	this.groupBox1.Controls.Add(this.btn_Mapper);
        	this.groupBox1.Controls.Add(this.btn_Exit);
        	this.groupBox1.Controls.Add(this.btn_Options);
        	this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.groupBox1.Location = new System.Drawing.Point(12, 6);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(164, 634);
        	this.groupBox1.TabIndex = 5;
        	this.groupBox1.TabStop = false;
        	// 
        	// btn_Credits
        	// 
        	this.btn_Credits.BackColor = System.Drawing.SystemColors.Control;
        	this.btn_Credits.Enabled = false;
        	this.btn_Credits.Location = new System.Drawing.Point(8, 584);
        	this.btn_Credits.Name = "btn_Credits";
        	this.btn_Credits.Size = new System.Drawing.Size(141, 36);
        	this.btn_Credits.TabIndex = 5;
        	this.btn_Credits.Text = "Credits";
        	this.btn_Credits.UseVisualStyleBackColor = false;
        	// 
        	// btn_Books
        	// 
        	this.btn_Books.BackColor = System.Drawing.SystemColors.Control;
        	this.btn_Books.BackgroundImage = global::Maro_MVP.Resources.glossy_background_hd_wallpaper_wallpaper_preview;
        	this.btn_Books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.btn_Books.Enabled = false;
        	this.btn_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Books.Location = new System.Drawing.Point(9, 213);
        	this.btn_Books.Name = "btn_Books";
        	this.btn_Books.Size = new System.Drawing.Size(141, 36);
        	this.btn_Books.TabIndex = 4;
        	this.btn_Books.Text = "Books";
        	this.btn_Books.UseVisualStyleBackColor = false;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
        	this.label2.Location = new System.Drawing.Point(318, 597);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(175, 20);
        	this.label2.TabIndex = 7;
        	this.label2.Text = "<< ✩ V0.1b - ALPHA >>";
        	// 
        	// lbl_MaroDate
        	// 
        	this.lbl_MaroDate.BackColor = System.Drawing.SystemColors.ButtonFace;
        	this.lbl_MaroDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.lbl_MaroDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lbl_MaroDate.Location = new System.Drawing.Point(184, 24);
        	this.lbl_MaroDate.Name = "lbl_MaroDate";
        	this.lbl_MaroDate.Size = new System.Drawing.Size(499, 23);
        	this.lbl_MaroDate.TabIndex = 4;
        	this.lbl_MaroDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Black;
        	this.BackgroundImage = global::Maro_MVP.Resources.shattered_moon;
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        	this.ClientSize = new System.Drawing.Size(698, 652);
        	this.Controls.Add(this.lbl_MaroDate);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.groupBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Main";
        	this.groupBox1.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MaroDate;
    }
}
