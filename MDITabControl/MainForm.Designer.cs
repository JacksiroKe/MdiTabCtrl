namespace MDITabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ToolStripProfessionalRenderer toolStripProfessionalRenderer2 = new System.Windows.Forms.ToolStripProfessionalRenderer();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TabControl1 = new Jacksiro.MdiTab.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.tABSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTYLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStyle1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStyle2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStyle3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStyle4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStyle5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "8.ico");
            this.ImageList1.Images.SetKeyName(1, "1.ico");
            this.ImageList1.Images.SetKeyName(2, "2.ico");
            this.ImageList1.Images.SetKeyName(3, "3.ico");
            this.ImageList1.Images.SetKeyName(4, "4.ico");
            this.ImageList1.Images.SetKeyName(5, "5.ico");
            this.ImageList1.Images.SetKeyName(6, "6.ico");
            this.ImageList1.Images.SetKeyName(7, "7.ico");
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tABSToolStripMenuItem,
            this.sTYLESToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(659, 24);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Location = new System.Drawing.Point(0, 362);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(659, 22);
            this.StatusStrip1.TabIndex = 5;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // TabControl1
            // 
            this.TabControl1.BackHighColor = System.Drawing.Color.Transparent;
            this.TabControl1.BackLowColor = System.Drawing.Color.Transparent;
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.ForeColor = System.Drawing.Color.Maroon;
            this.TabControl1.ForeColorDisabled = System.Drawing.Color.IndianRed;
            this.TabControl1.Location = new System.Drawing.Point(0, 24);
            toolStripProfessionalRenderer2.RoundedEdges = true;
            this.TabControl1.MenuRenderer = toolStripProfessionalRenderer2;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Size = new System.Drawing.Size(659, 338);
            this.TabControl1.TabBackHighColor = System.Drawing.SystemColors.Control;
            this.TabControl1.TabBackLowColorDisabled = System.Drawing.SystemColors.Control;
            this.TabControl1.TabBorderEnhanceWeight = Jacksiro.MdiTab.TabControl.Weight.Soft;
            this.TabControl1.TabCloseButtonBackHighColor = System.Drawing.Color.Transparent;
            this.TabControl1.TabCloseButtonBackHighColorDisabled = System.Drawing.Color.Transparent;
            this.TabControl1.TabCloseButtonBackHighColorHot = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TabControl1.TabCloseButtonBackLowColor = System.Drawing.Color.Transparent;
            this.TabControl1.TabCloseButtonBackLowColorDisabled = System.Drawing.Color.Transparent;
            this.TabControl1.TabCloseButtonBackLowColorHot = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TabControl1.TabCloseButtonBorderColor = System.Drawing.SystemColors.ControlDark;
            this.TabControl1.TabCloseButtonBorderColorDisabled = System.Drawing.SystemColors.GrayText;
            this.TabControl1.TabCloseButtonBorderColorHot = System.Drawing.SystemColors.HotTrack;
            this.TabControl1.TabCloseButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.TabControl1.TabCloseButtonForeColorDisabled = System.Drawing.SystemColors.GrayText;
            this.TabControl1.TabCloseButtonForeColorHot = System.Drawing.SystemColors.ControlText;
            this.TabControl1.TabCloseButtonImage = null;
            this.TabControl1.TabCloseButtonImageDisabled = null;
            this.TabControl1.TabCloseButtonImageHot = null;
            this.TabControl1.TabIconSize = new System.Drawing.Size(24, 24);
            this.TabControl1.TabIndex = 6;
            this.TabControl1.TabOffset = 0;
            this.TabControl1.TabPlusButton = this.button1;
            this.TabControl1.TabPlusImage = null;
            this.TabControl1.TabPlusVisable = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "New Tab";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tABSToolStripMenuItem
            // 
            this.tABSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewTabToolStripMenuItem,
            this.untabToolStripMenuItem});
            this.tABSToolStripMenuItem.Name = "tABSToolStripMenuItem";
            this.tABSToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tABSToolStripMenuItem.Text = "&TABS";
            // 
            // addANewTabToolStripMenuItem
            // 
            this.addANewTabToolStripMenuItem.Name = "addANewTabToolStripMenuItem";
            this.addANewTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.addANewTabToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addANewTabToolStripMenuItem.Text = "New Tab";
            this.addANewTabToolStripMenuItem.Click += new System.EventHandler(this.addANewTabToolStripMenuItem_Click);
            // 
            // sTYLESToolStripMenuItem
            // 
            this.sTYLESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabStyle1ToolStripMenuItem,
            this.tabStyle2ToolStripMenuItem,
            this.tabStyle3ToolStripMenuItem,
            this.tabStyle4ToolStripMenuItem,
            this.tabStyle5ToolStripMenuItem});
            this.sTYLESToolStripMenuItem.Name = "sTYLESToolStripMenuItem";
            this.sTYLESToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.sTYLESToolStripMenuItem.Text = "TAB &STYLES";
            // 
            // untabToolStripMenuItem
            // 
            this.untabToolStripMenuItem.Name = "untabToolStripMenuItem";
            this.untabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.untabToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.untabToolStripMenuItem.Text = "Untab";
            this.untabToolStripMenuItem.Click += new System.EventHandler(this.untabToolStripMenuItem_Click_1);
            // 
            // tabStyle1ToolStripMenuItem
            // 
            this.tabStyle1ToolStripMenuItem.Name = "tabStyle1ToolStripMenuItem";
            this.tabStyle1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tabStyle1ToolStripMenuItem.Text = "Tab Style 1";
            // 
            // tabStyle2ToolStripMenuItem
            // 
            this.tabStyle2ToolStripMenuItem.Name = "tabStyle2ToolStripMenuItem";
            this.tabStyle2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tabStyle2ToolStripMenuItem.Text = "Tab Style 2";
            // 
            // tabStyle3ToolStripMenuItem
            // 
            this.tabStyle3ToolStripMenuItem.Name = "tabStyle3ToolStripMenuItem";
            this.tabStyle3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tabStyle3ToolStripMenuItem.Text = "Tab Style 3";
            // 
            // tabStyle4ToolStripMenuItem
            // 
            this.tabStyle4ToolStripMenuItem.Name = "tabStyle4ToolStripMenuItem";
            this.tabStyle4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tabStyle4ToolStripMenuItem.Text = "Tab Style 4";
            // 
            // tabStyle5ToolStripMenuItem
            // 
            this.tabStyle5ToolStripMenuItem.Name = "tabStyle5ToolStripMenuItem";
            this.tabStyle5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tabStyle5ToolStripMenuItem.Text = "Tab Style 5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MDI Tab Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        internal Jacksiro.MdiTab.TabControl TabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tABSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTYLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabStyle1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabStyle2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabStyle3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabStyle4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabStyle5ToolStripMenuItem;
    }
}

