using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HToolOne.Ddos;

namespace HToolOne
{
    public partial class MainFrame : Form
    {
        private PerformanceCounterCategory _performanceCounterCategory;
        private string _iface;
        private PerformanceCounter _tx;
        private PerformanceCounter _rx;
        private bool DdosAttackStatus;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello little hacker! \nThis tools created just for fun!\n\n Author - Alexander", "Hacker tools just for tests");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // search only Network Interfaces
            _performanceCounterCategory = new PerformanceCounterCategory("Network Interface");

            // add ifaces to ComboBox
            cbIface.Items.AddRange(_performanceCounterCategory?.GetInstanceNames());

        }

        // TODO : bytes, kilo, mega, giga
        private void cbIface_SelectedIndexChanged(object sender, EventArgs e)
        {
            _iface = ((ComboBox)sender).Text;

            if (_iface == null)
            {
                MessageBox.Show("Interfaces not set", "Error", MessageBoxButtons.OK);
                return;
            }

            _tx = new PerformanceCounter("Network Interface", "Bytes Sent/sec", _iface);
            _rx = new PerformanceCounter("Network Interface", "Bytes Received/sec", _iface);

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        labelTXValue.Text = (_tx.NextValue() / 1024) + " k";
                        labelRXValue.Text = (_rx.NextValue() / 1024) + " k";
                    });
                    Thread.Sleep(500);
                }
            });

        }

        private void ddos_btnCheckAddr_Click(object sender, EventArgs e)
        {
            string gettedIp = ddos_tbAddr.Text;
            Regex ip = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
            MatchCollection result = ip.Matches(gettedIp.Trim());

            if (result.Count < 1 || result.Count > 1)
            {
                ddos_rtbMain.AppendText($"\n***** Can't use this address - {gettedIp} *****\n");
                return;
            }

            ddos_rtbMain.AppendText($"\n***** Address - {gettedIp} is ok *****\n");
            ddos_tbAddr.ReadOnly = true;
            ddos_btnStartAttack.Enabled = true;
        }

        private void ddos_rtbMain_TextChanged(object sender, EventArgs e)
        {
            ddos_rtbMain.SelectionStart = ddos_rtbMain.Text.Length;
            ddos_rtbMain.ScrollToCaret();
        }

        private void ddos_btnStartAttack_Click(object sender, EventArgs e)
        {
            DdosAttackStatus = false;
            ddos_btnStartAttack.Enabled = false;
            ddos_rtbMain.AppendText($"\n***** Try to attack {ddos_tbAddr.Text} *****\n");
            Task.Factory.StartNew(() =>
            {
                while (!DdosAttackStatus)
                {
                    var ddos = new DdosAttack(ddos_tbAddr.Text);
                    this.Invoke((MethodInvoker)delegate
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            ddos_rtbMain.AppendText("\n" + ddos.Attack().Result);
                        }
                    });
                    Thread.Sleep(100);
                    GC.Collect();
                }
            });
        }

        private void ddos_btnStopAttack_Click(object sender, EventArgs e)
        {
            DdosAttackStatus = true;
            ddos_tbAddr.ReadOnly = false;
            ddos_btnStartAttack.Enabled = false;
        }

        private void ddos_btnClearAttackLog_Click(object sender, EventArgs e)
        {
            ddos_rtbMain.Clear();
        }
    }
}
