namespace Maro_MVP.Views.Forms
{
    partial class FrmNewFamilyNode
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
            this.grpBox_Edit = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.grpBox_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Edit
            // 
            this.grpBox_Edit.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Edit.Controls.Add(this.btn_Cancel);
            this.grpBox_Edit.Controls.Add(this.btn_Accept);
            this.grpBox_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Edit.Location = new System.Drawing.Point(462, 79);
            this.grpBox_Edit.Name = "grpBox_Edit";
            this.grpBox_Edit.Size = new System.Drawing.Size(144, 94);
            this.grpBox_Edit.TabIndex = 7;
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
            // 
            // FrmNewFamilyNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 179);
            this.Controls.Add(this.grpBox_Edit);
            this.Name = "FrmNewFamilyNode";
            this.Text = "FrmNewFamilyNode";
            this.grpBox_Edit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Edit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Accept;
    }
}