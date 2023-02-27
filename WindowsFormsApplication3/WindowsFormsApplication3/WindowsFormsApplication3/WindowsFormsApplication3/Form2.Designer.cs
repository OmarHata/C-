namespace WindowsFormsApplication3
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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByTotalAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByFnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRANGFEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsXmlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(616, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "VIEW DATA\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.saveAsXmlFileToolStripMenuItem,
            this.readFromXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByTotalAscendingToolStripMenuItem,
            this.sortByFnameToolStripMenuItem,
            this.passToolStripMenuItem,
            this.passedToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.getRANGFEToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.reverseToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.toolStripMenuItem2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sortByTotalAscendingToolStripMenuItem
            // 
            this.sortByTotalAscendingToolStripMenuItem.Name = "sortByTotalAscendingToolStripMenuItem";
            this.sortByTotalAscendingToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.sortByTotalAscendingToolStripMenuItem.Text = "Sort By Total Ascending";
            this.sortByTotalAscendingToolStripMenuItem.Click += new System.EventHandler(this.sortByTotalAscendingToolStripMenuItem_Click);
            // 
            // sortByFnameToolStripMenuItem
            // 
            this.sortByFnameToolStripMenuItem.Name = "sortByFnameToolStripMenuItem";
            this.sortByFnameToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.sortByFnameToolStripMenuItem.Text = "Sort By Fname";
            this.sortByFnameToolStripMenuItem.Click += new System.EventHandler(this.sortByFnameToolStripMenuItem_Click);
            // 
            // passToolStripMenuItem
            // 
            this.passToolStripMenuItem.Name = "passToolStripMenuItem";
            this.passToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.passToolStripMenuItem.Text = "Pass";
            this.passToolStripMenuItem.Click += new System.EventHandler(this.passToolStripMenuItem_Click);
            // 
            // passedToolStripMenuItem
            // 
            this.passedToolStripMenuItem.Name = "passedToolStripMenuItem";
            this.passedToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.passedToolStripMenuItem.Text = "% Passed";
            this.passedToolStripMenuItem.Click += new System.EventHandler(this.passedToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // getRANGFEToolStripMenuItem
            // 
            this.getRANGFEToolStripMenuItem.Name = "getRANGFEToolStripMenuItem";
            this.getRANGFEToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.getRANGFEToolStripMenuItem.Text = "GetRANGFE";
            this.getRANGFEToolStripMenuItem.Click += new System.EventHandler(this.getRANGFEToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.removeToolStripMenuItem.Text = "Remove ";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.reverseToolStripMenuItem.Text = "Reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascToolStripMenuItem,
            this.descToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // ascToolStripMenuItem
            // 
            this.ascToolStripMenuItem.Name = "ascToolStripMenuItem";
            this.ascToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.ascToolStripMenuItem.Text = "Asc";
            this.ascToolStripMenuItem.Click += new System.EventHandler(this.ascToolStripMenuItem_Click);
            // 
            // descToolStripMenuItem
            // 
            this.descToolStripMenuItem.Name = "descToolStripMenuItem";
            this.descToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.descToolStripMenuItem.Text = "Desc";
            this.descToolStripMenuItem.Click += new System.EventHandler(this.descToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(260, 26);
            this.toolStripMenuItem2.Text = "\\";
            // 
            // saveAsXmlFileToolStripMenuItem
            // 
            this.saveAsXmlFileToolStripMenuItem.Name = "saveAsXmlFileToolStripMenuItem";
            this.saveAsXmlFileToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.saveAsXmlFileToolStripMenuItem.Text = "Save as Xml File";
            this.saveAsXmlFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsXmlFileToolStripMenuItem_Click);
            // 
            // readFromXMLToolStripMenuItem
            // 
            this.readFromXMLToolStripMenuItem.Name = "readFromXMLToolStripMenuItem";
            this.readFromXMLToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.readFromXMLToolStripMenuItem.Text = "Read From XML";
            this.readFromXMLToolStripMenuItem.Click += new System.EventHandler(this.readFromXMLToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 511);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByTotalAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByFnameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getRANGFEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsXmlFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromXMLToolStripMenuItem;
    }
}