using Page_Login.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Page_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            lblH.Parent = pictureBox1;
            lblSubH.Parent = pictureBox1;
            lblMFEF.Parent = pictureBox1;

            //lblUni.Parent = pictureBox1;
            pictureBoxLogo.BackColor = Color.Transparent;


            lblMFEF.Font = new Font("Poppins", 10, FontStyle.Regular);
            lblSubH.Font = new Font("Poppins", 10, FontStyle.Regular);


            lblUni.Font = new Font("Poppins", 10, FontStyle.Bold);
            //lblSubHright1.Font = new Font("Poppins", 8, FontStyle.Regular);
            lblSL.Font = new Font("Poppins", 12, FontStyle.Regular);
            lblSubHright2.Font = new Font("Poppins", 7, FontStyle.Regular);


            lblUS.Font = new Font("Poppins", 7, FontStyle.Regular);
            lblPW.Font = new Font("Poppins", 7, FontStyle.Regular);


        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUS.Text) && string.IsNullOrEmpty(txtPW.Text))
            {
                MessageBox.Show("Please enter both Username & Password!");
            }

            else if (string.IsNullOrEmpty(txtUS.Text))
            {
                MessageBox.Show("Please enter your Username!");
            }

            else if (string.IsNullOrEmpty(txtPW.Text))
            {
                MessageBox.Show("Please enter your Password!");
            }

            else
            {
                if (txtUS.Text == "B2025-0444" && txtPW.Text == "6767")
                {
                    Loading form = new Loading();
                    form.Show();
                    this.Hide(); // Optional: hides the login form
                }

                else if (txtUS.Text == "B2025-0444" && txtPW.Text != "6767")
                {
                    MessageBox.Show("Correct Username, but the Password is wrong!");
                }

                else if (txtPW.Text != "B2025-0444" && txtPW.Text == "6767")
                {
                    MessageBox.Show("Correct Password, but the Username is wrong!");
                }

                else
                {
                    MessageBox.Show("The Username & Password you entered is incorrect.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblUni_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
