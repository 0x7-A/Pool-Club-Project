using System;
using System.Net;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void DisplayMessageBox(object sender, PoolTableInfoEventArgs e)
        {
            MessageBox.Show($"Table: {e.TableName} | Time Consumed: {e.TimeConsumed} | Total Second: {e.TotalSecond} | Total Fees: {e.TotalFees:F2} ", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Control control in pPoolTable.Controls)
            {
                if (control is ucPoolTable poolTable)
                {
                    poolTable.onEndBuutonClick += DisplayMessageBox;
                   
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
