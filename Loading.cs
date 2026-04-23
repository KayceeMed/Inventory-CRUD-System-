using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page_Login
{
    public partial class Loading : Form
    {
        private System.Windows.Forms.Timer timer;
        public Loading()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // Duration in milliseconds (example: 15 seconds)
            timer.Tick += Timer_Tick;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //timer.Stop();
            //this.Close(); 

            timer.Stop();

            // Open your Form2 (inventory/dashboard)
            lblInventoryList mainForm = new lblInventoryList();
            mainForm.Show();

            this.Close();  // Close loading
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
