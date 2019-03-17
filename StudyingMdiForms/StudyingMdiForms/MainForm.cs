using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyingMdiForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            ShowForm( ref form1);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;

            TabPage deleteTabPage = null;

            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Text == form.Text)
                {
                    deleteTabPage = tabPage;
                    break;
                }
            }

            if (deleteTabPage != null)
                tabControl1.TabPages.Remove(deleteTabPage);
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            ShowForm(ref form2);

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            ShowForm(ref form3);

        }

        private void tabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            tabControl1.Visible = tabControl1.TabPages.Count > 0;
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            Form activeMdiChild = this.ActiveMdiChild;

            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (activeMdiChild.Text == tabPage.Text)
                {
                    tabControl1.SelectedTab = tabPage;
                    break;
                }
            }
        }

        private void tabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
            tabControl1.Visible = tabControl1.TabPages.Count > 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl1.SelectedTab;
            if (selectedTab == null)
            {
                return;
            }

            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == selectedTab.Text)
                {
                    mdiChild.BringToFront();
                    break;
                }
            }
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void döşemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        void ShowForm(ref Form form)
        {
            Form f = form;
            Form tempForm = null;

            foreach (Form child in this.MdiChildren)
            {
                if (child.Text == f.Text)
                {
                    tempForm = child;
                    break;
                }
            }
            
            if (tempForm != null)
            {
                tempForm.BringToFront();
            }
            else
            {
                f.MdiParent = this;
                f.Show();
                f.FormClosed += Form1_FormClosed;

                TabPage tabPage = new TabPage();
                tabPage.Text = f.Text;
                tabPage.Parent = tabControl1;
            }
            
        }
    }
}
