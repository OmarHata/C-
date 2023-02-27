namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByTotalAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByFirstNameAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByTotalAscendingToolStripMenuItem,
            this.sortByFirstNameAscendingToolStripMenuItem,
            this.passToolStripMenuItem,
            this.maToolStripMenuItem,
            this.maxToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sortByTotalAscendingToolStripMenuItem
            // 
            this.sortByTotalAscendingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByTotalAscendingToolStripMenuItem.Name = "sortByTotalAscendingToolStripMenuItem";
            this.sortByTotalAscendingToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.sortByTotalAscendingToolStripMenuItem.Text = "Sort By Total Ascending";
            this.sortByTotalAscendingToolStripMenuItem.Click += new System.EventHandler(this.sortByTotalAscendingToolStripMenuItem_Click);
            // 
            // sortByFirstNameAscendingToolStripMenuItem
            // 
            this.sortByFirstNameAscendingToolStripMenuItem.Name = "sortByFirstNameAscendingToolStripMenuItem";
            this.sortByFirstNameAscendingToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.sortByFirstNameAscendingToolStripMenuItem.Text = "Sort By First Name Ascending";
            this.sortByFirstNameAscendingToolStripMenuItem.Click += new System.EventHandler(this.sortByFirstNameAscendingToolStripMenuItem_Click);
            // 
            // passToolStripMenuItem
            // 
            this.passToolStripMenuItem.Name = "passToolStripMenuItem";
            this.passToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.passToolStripMenuItem.Text = "Pass";
            this.passToolStripMenuItem.Click += new System.EventHandler(this.passToolStripMenuItem_Click);
            // 
            // maToolStripMenuItem
            // 
            this.maToolStripMenuItem.Name = "maToolStripMenuItem";
            this.maToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.maToolStripMenuItem.Text = "% Passed";
            this.maToolStripMenuItem.Click += new System.EventHandler(this.maToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByTotalAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByFirstNameAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
    }
}