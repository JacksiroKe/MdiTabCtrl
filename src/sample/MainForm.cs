using System.Windows.Forms;

namespace MdiTabCtrlSample
{
    public partial class MainForm : Form
    {
        private int tabcount;

        public MainForm()
        {
            InitializeComponent();

            NewEmptyTab();
            NewEmptyTab();
            NewBrowserTab();
            //tabControl1.TabPages[1].Select(); //select a tab page of choice
        }

        public void NewBrowserTab()
        {
            Form cform = new BrowserForm();
            cform.Text = "This is a Browser Tab"; //Declare text for this tab
            tabControl1.TabPages.Add(cform);
        }

        public void NewEmptyTab()
        {
            Form cform = new BasicForm(); //call an instance of a class you want to show in a tab
            tabcount = tabcount + 1;
            cform.Text = "This is an Empty Tab " + tabcount; //Declare text for this tab
            tabControl1.TabPages.Add(cform);
        }
    }
}
