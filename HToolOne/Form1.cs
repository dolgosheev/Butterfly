using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HToolOne
{
    public partial class MainFrame : Form
    {
        private PerformanceCounterCategory _performanceCounterCategory;
        private string _iface;
        private PerformanceCounter _tx;
        private PerformanceCounter _rx;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hacker tools", "Pilot version");
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
    }
}
