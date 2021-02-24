namespace ProjectsManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.textBox_ProjectPath = new System.Windows.Forms.TextBox();
            this.button_Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_CreatePrpject = new System.Windows.Forms.Button();
            this.listView_Projects = new System.Windows.Forms.ListView();
            this.contextMenuStrip_RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ProjectPath
            // 
            this.textBox_ProjectPath.Location = new System.Drawing.Point(63, 12);
            this.textBox_ProjectPath.Name = "textBox_ProjectPath";
            this.textBox_ProjectPath.ReadOnly = true;
            this.textBox_ProjectPath.Size = new System.Drawing.Size(655, 21);
            this.textBox_ProjectPath.TabIndex = 0;
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(724, 12);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(93, 23);
            this.button_Browse.TabIndex = 1;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Location = new System.Drawing.Point(63, 39);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.Size = new System.Drawing.Size(655, 21);
            this.textBox_ProjectName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // button_CreatePrpject
            // 
            this.button_CreatePrpject.Location = new System.Drawing.Point(724, 37);
            this.button_CreatePrpject.Name = "button_CreatePrpject";
            this.button_CreatePrpject.Size = new System.Drawing.Size(93, 23);
            this.button_CreatePrpject.TabIndex = 1;
            this.button_CreatePrpject.Text = "Create";
            this.button_CreatePrpject.UseVisualStyleBackColor = true;
            this.button_CreatePrpject.Click += new System.EventHandler(this.button_CreateProject_Click);
            // 
            // listView_Projects
            // 
            this.listView_Projects.ContextMenuStrip = this.contextMenuStrip_RightClick;
            this.listView_Projects.FullRowSelect = true;
            this.listView_Projects.GridLines = true;
            this.listView_Projects.Location = new System.Drawing.Point(18, 66);
            this.listView_Projects.Name = "listView_Projects";
            this.listView_Projects.Size = new System.Drawing.Size(799, 340);
            this.listView_Projects.TabIndex = 3;
            this.listView_Projects.UseCompatibleStateImageBehavior = false;
            this.listView_Projects.View = System.Windows.Forms.View.Details;
            this.listView_Projects.SelectedIndexChanged += new System.EventHandler(this.listView_Projects_SelectedIndexChanged);
            // 
            // contextMenuStrip_RightClick
            // 
            this.contextMenuStrip_RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_RightClick.Name = "contextMenuStrip_RightClick";
            this.contextMenuStrip_RightClick.Size = new System.Drawing.Size(114, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 418);
            this.Controls.Add(this.listView_Projects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CreatePrpject);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.textBox_ProjectName);
            this.Controls.Add(this.textBox_ProjectPath);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectsManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip_RightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ProjectPath;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CreatePrpject;
        private System.Windows.Forms.ListView listView_Projects;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_RightClick;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

