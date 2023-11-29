using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinQuickQR
{
    public partial class frm_QuickQR : Form
    {
        Timer timer = new Timer();
        Form form = null;

        public frm_QuickQR()
        {
            InitializeComponent();
        }

        public frm_QuickQR(Form form, Image qrImage)
        {
            InitializeComponent();

            pb_QR.Image = qrImage;
            this.form = form;
        }

        private void frm_QuickQR_Load(object sender, EventArgs e)
        {
            // Auto align to bottom right
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);


            if (Properties.Settings.Default.QuickQRTimeout > 0)
            {
                timer.Interval = Properties.Settings.Default.QuickQRTimeout * 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_QuickQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_QR_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.WindowState = FormWindowState.Normal;
                form.Show();
                this.Close();
            }
        }
    }
}
