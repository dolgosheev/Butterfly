﻿
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
            this.ddos_btnCheckAddr = new System.Windows.Forms.Button();
            this.ddos_rtbMain = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ddos_tbAddr = new System.Windows.Forms.TextBox();
            this.ddos_btnStartAttack = new System.Windows.Forms.Button();
            this.ddos_btnStopAttack = new System.Windows.Forms.Button();
            this.ddos_btnClearAttackLog = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1705, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 34);
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
            this.tabPage1.Controls.Add(this.ddos_btnClearAttackLog);
            this.tabPage1.Controls.Add(this.ddos_btnStopAttack);
            this.tabPage1.Controls.Add(this.ddos_btnStartAttack);
            this.tabPage1.Controls.Add(this.ddos_tbAddr);
            this.tabPage1.Controls.Add(this.ddos_btnCheckAddr);
            this.tabPage1.Controls.Add(this.ddos_rtbMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1355, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DDoS Attack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ddos_btnCheckAddr
            // 
            this.ddos_btnCheckAddr.Location = new System.Drawing.Point(15, 92);
            this.ddos_btnCheckAddr.Name = "ddos_btnCheckAddr";
            this.ddos_btnCheckAddr.Size = new System.Drawing.Size(482, 79);
            this.ddos_btnCheckAddr.TabIndex = 1;
            this.ddos_btnCheckAddr.Text = "Check address";
            this.ddos_btnCheckAddr.UseVisualStyleBackColor = true;
            this.ddos_btnCheckAddr.Click += new System.EventHandler(this.ddos_btnCheckAddr_Click);
            // 
            // ddos_rtbMain
            // 
            this.ddos_rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ddos_rtbMain.Location = new System.Drawing.Point(508, 20);
            this.ddos_rtbMain.Name = "ddos_rtbMain";
            this.ddos_rtbMain.ReadOnly = true;
            this.ddos_rtbMain.Size = new System.Drawing.Size(826, 586);
            this.ddos_rtbMain.TabIndex = 0;
            this.ddos_rtbMain.Text = "";
            this.ddos_rtbMain.TextChanged += new System.EventHandler(this.ddos_rtbMain_TextChanged);
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
            // ddos_tbAddr
            // 
            this.ddos_tbAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddos_tbAddr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ddos_tbAddr.Location = new System.Drawing.Point(17, 22);
            this.ddos_tbAddr.Name = "ddos_tbAddr";
            this.ddos_tbAddr.ShortcutsEnabled = false;
            this.ddos_tbAddr.Size = new System.Drawing.Size(480, 53);
            this.ddos_tbAddr.TabIndex = 2;
            this.ddos_tbAddr.Text = "2.59.40.12";
            this.ddos_tbAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ddos_btnStartAttack
            // 
            this.ddos_btnStartAttack.Enabled = false;
            this.ddos_btnStartAttack.Location = new System.Drawing.Point(15, 185);
            this.ddos_btnStartAttack.Name = "ddos_btnStartAttack";
            this.ddos_btnStartAttack.Size = new System.Drawing.Size(482, 79);
            this.ddos_btnStartAttack.TabIndex = 3;
            this.ddos_btnStartAttack.Text = "Start attack";
            this.ddos_btnStartAttack.UseVisualStyleBackColor = true;
            this.ddos_btnStartAttack.Click += new System.EventHandler(this.ddos_btnStartAttack_Click);
            // 
            // ddos_btnStopAttack
            // 
            this.ddos_btnStopAttack.Location = new System.Drawing.Point(15, 278);
            this.ddos_btnStopAttack.Name = "ddos_btnStopAttack";
            this.ddos_btnStopAttack.Size = new System.Drawing.Size(482, 79);
            this.ddos_btnStopAttack.TabIndex = 4;
            this.ddos_btnStopAttack.Text = "Stop attack";
            this.ddos_btnStopAttack.UseVisualStyleBackColor = true;
            this.ddos_btnStopAttack.Click += new System.EventHandler(this.ddos_btnStopAttack_Click);
            // 
            // ddos_btnClearAttackLog
            // 
            this.ddos_btnClearAttackLog.Location = new System.Drawing.Point(16, 523);
            this.ddos_btnClearAttackLog.Name = "ddos_btnClearAttackLog";
            this.ddos_btnClearAttackLog.Size = new System.Drawing.Size(482, 79);
            this.ddos_btnClearAttackLog.TabIndex = 5;
            this.ddos_btnClearAttackLog.Text = "Clear Attack Log";
            this.ddos_btnClearAttackLog.UseVisualStyleBackColor = true;
            this.ddos_btnClearAttackLog.Click += new System.EventHandler(this.ddos_btnClearAttackLog_Click);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        internal System.Windows.Forms.RichTextBox ddos_rtbMain;
        private System.Windows.Forms.Button ddos_btnCheckAddr;
        private System.Windows.Forms.TextBox ddos_tbAddr;
        private System.Windows.Forms.Button ddos_btnStopAttack;
        private System.Windows.Forms.Button ddos_btnStartAttack;
        private System.Windows.Forms.Button ddos_btnClearAttackLog;
    }
}

