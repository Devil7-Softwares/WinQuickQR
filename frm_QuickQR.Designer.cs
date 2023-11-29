namespace WinQuickQR
{
    partial class frm_QuickQR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuickQR));
            this.tlp_MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pb_QR = new System.Windows.Forms.PictureBox();
            this.tp_Main = new System.Windows.Forms.ToolTip(this.components);
            this.tlp_MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_MainLayout
            // 
            this.tlp_MainLayout.AutoSize = true;
            this.tlp_MainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_MainLayout.ColumnCount = 2;
            this.tlp_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_MainLayout.Controls.Add(this.btn_Close, 1, 0);
            this.tlp_MainLayout.Controls.Add(this.pb_QR, 0, 1);
            this.tlp_MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_MainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlp_MainLayout.Name = "tlp_MainLayout";
            this.tlp_MainLayout.RowCount = 2;
            this.tlp_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_MainLayout.Size = new System.Drawing.Size(164, 164);
            this.tlp_MainLayout.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::WinQuickQR.Properties.Resources.cancel;
            this.btn_Close.Location = new System.Drawing.Point(137, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(22, 22);
            this.btn_Close.TabIndex = 0;
            this.tp_Main.SetToolTip(this.btn_Close, "Close");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pb_QR
            // 
            this.pb_QR.Location = new System.Drawing.Point(3, 31);
            this.pb_QR.Name = "pb_QR";
            this.pb_QR.Size = new System.Drawing.Size(128, 128);
            this.pb_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QR.TabIndex = 1;
            this.pb_QR.TabStop = false;
            this.pb_QR.Click += new System.EventHandler(this.pb_QR_Click);
            // 
            // frm_QuickQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(164, 164);
            this.Controls.Add(this.tlp_MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_QuickQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WinQuickQR";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QuickQR_FormClosing);
            this.Load += new System.EventHandler(this.frm_QuickQR_Load);
            this.tlp_MainLayout.ResumeLayout(false);
            this.tlp_MainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_MainLayout;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pb_QR;
        private System.Windows.Forms.ToolTip tp_Main;
    }
}