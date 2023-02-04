/*
 * Created by SharpDevelop.
 * User: 107
 * Date: 12/11/2022
 * Time: 02:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Views
{
	partial class FrmMapperMain
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
		private System.Windows.Forms.Button btn_InsertColumn;
		private System.Windows.Forms.Button btn_InsertRow;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_ClearMap;
		private System.Windows.Forms.CheckBox chkBox_TileDetails;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RemoveRow = new System.Windows.Forms.Button();
            this.btn_RemoveColumn = new System.Windows.Forms.Button();
            this.chkBox_TileDetails = new System.Windows.Forms.CheckBox();
            this.btn_ClearMap = new System.Windows.Forms.Button();
            this.btn_InsertRow = new System.Windows.Forms.Button();
            this.btn_InsertColumn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveFileToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveFileToolStripMenuItem.Text = "File";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newMapToolStripMenuItem.Text = "New Map...";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.NewMapToolStripMenuItemClick);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.loadFileToolStripMenuItem.Text = "Load File...";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.LoadFileToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem1
            // 
            this.saveFileToolStripMenuItem1.Name = "saveFileToolStripMenuItem1";
            this.saveFileToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.saveFileToolStripMenuItem1.Text = "Save File As...";
            this.saveFileToolStripMenuItem1.Click += new System.EventHandler(this.SaveFileToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMapToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generateMapToolStripMenuItem
            // 
            this.generateMapToolStripMenuItem.Name = "generateMapToolStripMenuItem";
            this.generateMapToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.generateMapToolStripMenuItem.Text = "Generate Map";
            this.generateMapToolStripMenuItem.Click += new System.EventHandler(this.GenerateMapToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.helpToolStripMenuItem.Text = "Controls";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_RemoveRow);
            this.panel1.Controls.Add(this.btn_RemoveColumn);
            this.panel1.Controls.Add(this.chkBox_TileDetails);
            this.panel1.Controls.Add(this.btn_ClearMap);
            this.panel1.Controls.Add(this.btn_InsertRow);
            this.panel1.Controls.Add(this.btn_InsertColumn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 592);
            this.panel1.TabIndex = 1;
            // 
            // btn_RemoveRow
            // 
            this.btn_RemoveRow.Location = new System.Drawing.Point(16, 408);
            this.btn_RemoveRow.Name = "btn_RemoveRow";
            this.btn_RemoveRow.Size = new System.Drawing.Size(75, 56);
            this.btn_RemoveRow.TabIndex = 7;
            this.btn_RemoveRow.Text = "Remove Row";
            this.btn_RemoveRow.UseVisualStyleBackColor = true;
            this.btn_RemoveRow.Click += new System.EventHandler(this.Btn_RemoveRowClick);
            // 
            // btn_RemoveColumn
            // 
            this.btn_RemoveColumn.Location = new System.Drawing.Point(16, 344);
            this.btn_RemoveColumn.Name = "btn_RemoveColumn";
            this.btn_RemoveColumn.Size = new System.Drawing.Size(75, 56);
            this.btn_RemoveColumn.TabIndex = 6;
            this.btn_RemoveColumn.Text = "Remove Column";
            this.btn_RemoveColumn.UseVisualStyleBackColor = true;
            this.btn_RemoveColumn.Click += new System.EventHandler(this.Btn_RemoveColumnClick);
            // 
            // chkBox_TileDetails
            // 
            this.chkBox_TileDetails.Location = new System.Drawing.Point(16, 288);
            this.chkBox_TileDetails.Name = "chkBox_TileDetails";
            this.chkBox_TileDetails.Size = new System.Drawing.Size(80, 48);
            this.chkBox_TileDetails.TabIndex = 4;
            this.chkBox_TileDetails.Text = "Open Tile with Details";
            this.chkBox_TileDetails.UseVisualStyleBackColor = true;
            // 
            // btn_ClearMap
            // 
            this.btn_ClearMap.Location = new System.Drawing.Point(16, 32);
            this.btn_ClearMap.Name = "btn_ClearMap";
            this.btn_ClearMap.Size = new System.Drawing.Size(75, 56);
            this.btn_ClearMap.TabIndex = 3;
            this.btn_ClearMap.Text = "Clear Map";
            this.btn_ClearMap.UseVisualStyleBackColor = true;
            this.btn_ClearMap.Click += new System.EventHandler(this.Btn_ClearMapClick);
            // 
            // btn_InsertRow
            // 
            this.btn_InsertRow.Location = new System.Drawing.Point(16, 216);
            this.btn_InsertRow.Name = "btn_InsertRow";
            this.btn_InsertRow.Size = new System.Drawing.Size(75, 56);
            this.btn_InsertRow.TabIndex = 2;
            this.btn_InsertRow.Text = "Insert Row";
            this.btn_InsertRow.UseVisualStyleBackColor = true;
            this.btn_InsertRow.Click += new System.EventHandler(this.Btn_InsertRowClick);
            // 
            // btn_InsertColumn
            // 
            this.btn_InsertColumn.Location = new System.Drawing.Point(16, 152);
            this.btn_InsertColumn.Name = "btn_InsertColumn";
            this.btn_InsertColumn.Size = new System.Drawing.Size(75, 56);
            this.btn_InsertColumn.TabIndex = 1;
            this.btn_InsertColumn.Text = "Insert Column";
            this.btn_InsertColumn.UseVisualStyleBackColor = true;
            this.btn_InsertColumn.Click += new System.EventHandler(this.Btn_InsertColumnClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(104, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(896, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(261, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 640);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(16, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 512);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 48);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(211, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "2D MoonNewt Mapper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateMapToolStripMenuItem;
        private System.Windows.Forms.Button btn_RemoveRow;
        private System.Windows.Forms.Button btn_RemoveColumn;
    }
}
