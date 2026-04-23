namespace Page_Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUS = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblUS = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.btnAP = new System.Windows.Forms.Button();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblSubHright2 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblMFEF = new System.Windows.Forms.Label();
            this.lblUni = new System.Windows.Forms.Label();
            this.lblSubH = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUS
            // 
            this.txtUS.Location = new System.Drawing.Point(519, 239);
            this.txtUS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUS.Name = "txtUS";
            this.txtUS.Size = new System.Drawing.Size(263, 22);
            this.txtUS.TabIndex = 4;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(519, 291);
            this.txtPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(263, 22);
            this.txtPW.TabIndex = 5;
            // 
            // lblUS
            // 
            this.lblUS.AutoSize = true;
            this.lblUS.BackColor = System.Drawing.Color.Transparent;
            this.lblUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblUS.Location = new System.Drawing.Point(516, 223);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(65, 15);
            this.lblUS.TabIndex = 6;
            this.lblUS.Text = "Username";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.Transparent;
            this.lblPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblPW.Location = new System.Drawing.Point(516, 275);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(61, 15);
            this.lblPW.TabIndex = 7;
            this.lblPW.Text = "Password";
            // 
            // btnAP
            // 
            this.btnAP.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAP.ForeColor = System.Drawing.Color.White;
            this.btnAP.Location = new System.Drawing.Point(519, 343);
            this.btnAP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(263, 40);
            this.btnAP.TabIndex = 8;
            this.btnAP.Text = "Sign-In →";
            this.btnAP.UseVisualStyleBackColor = false;
            this.btnAP.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.BackColor = System.Drawing.Color.Transparent;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSL.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblSL.Location = new System.Drawing.Point(512, 134);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(75, 25);
            this.lblSL.TabIndex = 11;
            this.lblSL.Text = "Sign-In";
            // 
            // lblSubHright2
            // 
            this.lblSubHright2.AutoSize = true;
            this.lblSubHright2.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHright2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblSubHright2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSubHright2.Location = new System.Drawing.Point(515, 164);
            this.lblSubHright2.Name = "lblSubHright2";
            this.lblSubHright2.Size = new System.Drawing.Size(248, 30);
            this.lblSubHright2.TabIndex = 12;
            this.lblSubHright2.Text = "Please enter your credentials to access your \r\ndashboard";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.ForeColor = System.Drawing.Color.Snow;
            this.lblH.Location = new System.Drawing.Point(11, 188);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(347, 98);
            this.lblH.TabIndex = 13;
            this.lblH.Text = "Institutional Trust\r\nOperational Efficiency";
            // 
            // lblMFEF
            // 
            this.lblMFEF.AutoSize = true;
            this.lblMFEF.BackColor = System.Drawing.Color.Transparent;
            this.lblMFEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMFEF.ForeColor = System.Drawing.Color.Snow;
            this.lblMFEF.Location = new System.Drawing.Point(104, 38);
            this.lblMFEF.Name = "lblMFEF";
            this.lblMFEF.Size = new System.Drawing.Size(0, 20);
            this.lblMFEF.TabIndex = 15;
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.BackColor = System.Drawing.Color.Transparent;
            this.lblUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUni.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblUni.Location = new System.Drawing.Point(595, 38);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(153, 20);
            this.lblUni.TabIndex = 16;
            this.lblUni.Text = "Bahay Kubo Mart";
            this.lblUni.Click += new System.EventHandler(this.lblUni_Click);
            // 
            // lblSubH
            // 
            this.lblSubH.AutoSize = true;
            this.lblSubH.BackColor = System.Drawing.Color.Transparent;
            this.lblSubH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSubH.ForeColor = System.Drawing.Color.Snow;
            this.lblSubH.Location = new System.Drawing.Point(22, 309);
            this.lblSubH.Name = "lblSubH";
            this.lblSubH.Size = new System.Drawing.Size(382, 40);
            this.lblSubH.TabIndex = 9;
            this.lblSubH.Text = "Enterprise-scale inventory management designed \r\nfor high performance logistics a" +
    "nd real-time\r\n";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Page_Login.Properties.Resources.bahay_kubo_icon;
            this.pictureBoxLogo.Location = new System.Drawing.Point(519, 10);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(70, 76);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(817, 520);
            this.Controls.Add(this.lblUni);
            this.Controls.Add(this.lblMFEF);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblSubHright2);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblSubH);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUS);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUS);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUS;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblUS;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblSubHright2;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblMFEF;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.Label lblSubH;
    }
}

