namespace StudyingMdiForms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.döşemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.form1ToolStripMenuItem.Text = "Form1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.form2ToolStripMenuItem.Text = "Form2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // form3ToolStripMenuItem
            // 
            this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            this.form3ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.form3ToolStripMenuItem.Text = "Form3";
            this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatayToolStripMenuItem,
            this.dikeyToolStripMenuItem,
            this.döşemeToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yatayToolStripMenuItem.Text = "Yatay";
            this.yatayToolStripMenuItem.Click += new System.EventHandler(this.yatayToolStripMenuItem_Click);
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            this.dikeyToolStripMenuItem.Click += new System.EventHandler(this.dikeyToolStripMenuItem_Click);
            // 
            // döşemeToolStripMenuItem
            // 
            this.döşemeToolStripMenuItem.Name = "döşemeToolStripMenuItem";
            this.döşemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.döşemeToolStripMenuItem.Text = "Döşeme";
            this.döşemeToolStripMenuItem.Click += new System.EventHandler(this.döşemeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 31);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ControlAdded);
            this.tabControl1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ControlRemoved);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 723);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem döşemeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

