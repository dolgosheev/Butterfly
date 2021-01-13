
namespace HToolOne
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTX = new System.Windows.Forms.LinkLabel();
            this.labelTXValue = new System.Windows.Forms.Label();
            this.labelRXValue = new System.Windows.Forms.Label();
            this.labelRX = new System.Windows.Forms.LinkLabel();
            this.cbIface = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.менюToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelTX
            // 
            this.labelTX.AutoSize = true;
            this.labelTX.Location = new System.Drawing.Point(16, 726);
            this.labelTX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTX.Name = "labelTX";
            this.labelTX.Size = new System.Drawing.Size(88, 17);
            this.labelTX.TabIndex = 2;
            this.labelTX.TabStop = true;
            this.labelTX.Text = "Tx packages";
            // 
            // labelTXValue
            // 
            this.labelTXValue.AutoSize = true;
            this.labelTXValue.Location = new System.Drawing.Point(113, 726);
            this.labelTXValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTXValue.Name = "labelTXValue";
            this.labelTXValue.Size = new System.Drawing.Size(54, 17);
            this.labelTXValue.TabIndex = 3;
            this.labelTXValue.Text = "0 bytes";
            // 
            // labelRXValue
            // 
            this.labelRXValue.AutoSize = true;
            this.labelRXValue.Location = new System.Drawing.Point(113, 751);
            this.labelRXValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRXValue.Name = "labelRXValue";
            this.labelRXValue.Size = new System.Drawing.Size(54, 17);
            this.labelRXValue.TabIndex = 5;
            this.labelRXValue.Text = "0 bytes";
            // 
            // labelRX
            // 
            this.labelRX.AutoSize = true;
            this.labelRX.Location = new System.Drawing.Point(16, 751);
            this.labelRX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRX.Name = "labelRX";
            this.labelRX.Size = new System.Drawing.Size(89, 17);
            this.labelRX.TabIndex = 4;
            this.labelRX.TabStop = true;
            this.labelRX.Text = "Rx packages";
            // 
            // cbIface
            // 
            this.cbIface.FormattingEnabled = true;
            this.cbIface.Location = new System.Drawing.Point(12, 694);
            this.cbIface.Name = "cbIface";
            this.cbIface.Size = new System.Drawing.Size(262, 24);
            this.cbIface.TabIndex = 7;
            this.cbIface.Text = "select interface...";
            this.cbIface.SelectedIndexChanged += new System.EventHandler(this.cbIface_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1363, 654);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1355, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DDoS Attack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1355, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PortScanner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1355, 625);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MyComp Inspect";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1355, 625);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "OVPN Helper";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 784);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbIface);
            this.Controls.Add(this.labelRXValue);
            this.Controls.Add(this.labelRX);
            this.Controls.Add(this.labelTXValue);
            this.Controls.Add(this.labelTX);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrame";
            this.Text = "Butterfly";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel labelTX;
        private System.Windows.Forms.Label labelTXValue;
        private System.Windows.Forms.Label labelRXValue;
        private System.Windows.Forms.LinkLabel labelRX;
        private System.Windows.Forms.ComboBox cbIface;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

