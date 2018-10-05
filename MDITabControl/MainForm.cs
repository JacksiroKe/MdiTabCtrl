using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITabControl
{
    public partial class MainForm : Form
    {
        int tabcount = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        //Method to generate tabs
        private void showNewTab()
        {
            Form cform; //Declare child Form
            cform = new ChildForm(); //call an instance of a class you want to show in a tab
            tabcount = tabcount + 1;
            cform.Text = "This is Tab " + tabcount; //Declare text for this tab
            TabControl1.TabPages.Add(cform);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            button1.SendToBack();
            showNewTab();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showNewTab();
        }

        //Method to remove selected tab
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl1.TabPages.Count > 0) {
                //TabControl1.TabPages.Remove(TabControl1.TabPages.);
            }
            
        }

        private void ChangePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AnimateIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AnimateIconToolStripMenuItem.Checked) {
                Timer1.Stop();
                AnimateIconToolStripMenuItem.Checked = false;
                AnimateIconToolStripMenuItem.Text = "Animate Icon";
            } else {
                Timer1.Start();
                AnimateIconToolStripMenuItem.Checked = true;
                AnimateIconToolStripMenuItem.Text = "Stop Animation";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void UntabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addANewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNewTab();
        }

        private void untabToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
