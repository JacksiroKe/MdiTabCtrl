using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdiTabCtrlSample
{
    public partial class Form1 : Form
    {
        private int tabcount;

        public Form1()
        {
            InitializeComponent();

            NewTab();
            NewTab();
            NewTab();
            tabControl1.TabPages[1].Select(); //select a tab page of choice
        }

        public void NewTab()
        {
            Form cform = new ChildForm(); //call an instance of a class you want to show in a tab
            tabcount = tabcount + 1;
            cform.Text = "This is Tab " + tabcount; //Declare text for this tab
            tabControl1.TabPages.Add(cform);
        }
    }
}
