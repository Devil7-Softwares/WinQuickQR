using QRCoder;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;
using static QRCoder.QRCodeGenerator;

namespace WinQuickQR
{
    public partial class frm_Main : Form
    {
        private QRCodeGenerator qrGenerator = new QRCodeGenerator();
        private SharpClipboard clipboard = new SharpClipboard();

        private Regex urlRegex = new Regex(@"^(http|https|ftp|ftps)\:\/\/[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(\/\S*)?$");

        public frm_Main()
        {
            InitializeComponent();
        }

        private Image GetQRCode(string input)
        {
            ECCLevel eccLevel = (ECCLevel)Properties.Settings.Default.ECCLevel;

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, eccLevel);
            QRCode qRCode = new QRCode(qrCodeData);

            return qRCode.GetGraphic(Properties.Settings.Default.PixelPerModule);
        }

        private void Clipboard_ClipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {
            if (e.ContentType == SharpClipboard.ContentTypes.Text)
            {
                string content = e.Content.ToString();

                if (!string.IsNullOrEmpty(content))
                {
                    txt_Input.Text = content;

                    if (!this.Visible)
                    {
                        if (Properties.Settings.Default.ShowQuickQRForURL && urlRegex.IsMatch(content))
                        {
                            frm_QuickQR quickQR = new frm_QuickQR(this, GetQRCode(content));
                            quickQR.Show();
                        }
                    }
                }
            }
        }

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            pb_QR.Image = GetQRCode(txt_Input.Text);
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();

                    if (!string.IsNullOrEmpty(clipboardText))
                    {
                        txt_Input.Text = clipboardText;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to get clipboard text: {ex.Message}");
            }

            clipboard.MonitorClipboard = Properties.Settings.Default.MonitorClipboard;
            clipboard.ClipboardChanged += Clipboard_ClipboardChanged;
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.CloseToSystemTray && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void btn_SaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save QR Code to File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_QR.Image.Save(saveFileDialog.FileName);
            }
        }

        private void btn_CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pb_QR.Image);

            MessageBox.Show("QR Code copied to clipboard.", "WinQuickQR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ni_MainIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void mi_NotificationMenu_Open_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void mi_NotificationMenu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
