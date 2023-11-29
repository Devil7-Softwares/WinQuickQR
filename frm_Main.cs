using QRCoder;
using System;
using System.Windows.Forms;

namespace WinQuickQR
{
    public partial class frm_Main : Form
    {
        private QRCodeGenerator qrGenerator = new QRCodeGenerator();

        public frm_Main()
        {
            InitializeComponent();
        }

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)Properties.Settings.Default.ECCLevel;

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(txt_Input.Text, eccLevel);
            QRCode qRCode = new QRCode(qrCodeData);

            pb_QR.Image = qRCode.GetGraphic(Properties.Settings.Default.PixelPerModule);
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                string clipboardText = Clipboard.GetText();

                if (!string.IsNullOrEmpty(clipboardText))
                {
                    txt_Input.Text = clipboardText;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to get clipboard text: {ex.Message}");
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
    }
}
