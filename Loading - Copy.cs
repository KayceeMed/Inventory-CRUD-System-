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
            timer.Interval = 7000; // Duration in milliseconds (example: 7 seconds)
            timer.Tick += Timer_Tick;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close(); // Close the Loading form

   
        }
    }
}
