namespace WinQuickQR
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.grp_Input = new System.Windows.Forms.GroupBox();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.pb_QR = new System.Windows.Forms.PictureBox();
            this.tlp_Actions = new System.Windows.Forms.TableLayoutPanel();
            this.flp_Actions = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.btn_CopyToClipboard = new System.Windows.Forms.Button();
            this.ni_MainIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_NotificationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_NotificationMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NotificationMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_Input.SuspendLayout();
            this.grp_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).BeginInit();
            this.tlp_Actions.SuspendLayout();
            this.flp_Actions.SuspendLayout();
            this.cms_NotificationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Input
            // 
            this.grp_Input.Controls.Add(this.txt_Input);
            this.grp_Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Input.Location = new System.Drawing.Point(0, 0);
            this.grp_Input.Name = "grp_Input";
            this.grp_Input.Size = new System.Drawing.Size(355, 134);
            this.grp_Input.TabIndex = 0;
            this.grp_Input.TabStop = false;
            this.grp_Input.Text = "Input";
            // 
            // txt_Input
            // 
            this.txt_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Input.Location = new System.Drawing.Point(3, 16);
            this.txt_Input.Multiline = true;
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(349, 115);
            this.txt_Input.TabIndex = 0;
            this.txt_Input.TextChanged += new System.EventHandler(this.txt_Input_TextChanged);
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.pb_QR);
            this.grp_Output.Controls.Add(this.tlp_Actions);
            this.grp_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Output.Location = new System.Drawing.Point(0, 134);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(355, 240);
            this.grp_Output.TabIndex = 1;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "QR Code";
            // 
            // pb_QR
            // 
            this.pb_QR.BackColor = System.Drawing.Color.White;
            this.pb_QR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_QR.Location = new System.Drawing.Point(3, 16);
            this.pb_QR.Name = "pb_QR";
            this.pb_QR.Size = new System.Drawing.Size(349, 192);
            this.pb_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QR.TabIndex = 0;
            this.pb_QR.TabStop = false;
            // 
            // tlp_Actions
            // 
            this.tlp_Actions.AutoSize = true;
            this.tlp_Actions.ColumnCount = 3;
            this.tlp_Actions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Actions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Actions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Actions.Controls.Add(this.flp_Actions, 1, 0);
            this.tlp_Actions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp_Actions.Location = new System.Drawing.Point(3, 208);
            this.tlp_Actions.Name = "tlp_Actions";
            this.tlp_Actions.RowCount = 1;
            this.tlp_Actions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Actions.Size = new System.Drawing.Size(349, 29);
            this.tlp_Actions.TabIndex = 2;
            // 
            // flp_Actions
            // 
            this.flp_Actions.AutoSize = true;
            this.flp_Actions.Controls.Add(this.btn_SaveToFile);
            this.flp_Actions.Controls.Add(this.btn_CopyToClipboard);
            this.flp_Actions.Location = new System.Drawing.Point(93, 0);
            this.flp_Actions.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Actions.Name = "flp_Actions";
            this.flp_Actions.Size = new System.Drawing.Size(162, 29);
            this.flp_Actions.TabIndex = 1;
            this.flp_Actions.WrapContents = false;
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(3, 3);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveToFile.TabIndex = 1;
            this.btn_SaveToFile.Text = "Save Image";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // btn_CopyToClipboard
            // 
            this.btn_CopyToClipboard.Location = new System.Drawing.Point(84, 3);
            this.btn_CopyToClipboard.Name = "btn_CopyToClipboard";
            this.btn_CopyToClipboard.Size = new System.Drawing.Size(75, 23);
            this.btn_CopyToClipboard.TabIndex = 0;
            this.btn_CopyToClipboard.Text = "Copy Image";
            this.btn_CopyToClipboard.UseVisualStyleBackColor = true;
            this.btn_CopyToClipboard.Click += new System.EventHandler(this.btn_CopyToClipboard_Click);
            // 
            // ni_MainIcon
            // 
            this.ni_MainIcon.ContextMenuStrip = this.cms_NotificationMenu;
            this.ni_MainIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_MainIcon.Icon")));
            this.ni_MainIcon.Text = "WinQuickQR";
            this.ni_MainIcon.Visible = true;
            this.ni_MainIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_MainIcon_MouseDoubleClick);
            // 
            // cms_NotificationMenu
            // 
            this.cms_NotificationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_NotificationMenu_Open,
            this.mi_NotificationMenu_Exit});
            this.cms_NotificationMenu.Name = "cms_NotificationMenu";
            this.cms_NotificationMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // mi_NotificationMenu_Open
            // 
            this.mi_NotificationMenu_Open.Name = "mi_NotificationMenu_Open";
            this.mi_NotificationMenu_Open.Size = new System.Drawing.Size(180, 22);
            this.mi_NotificationMenu_Open.Text = "Open";
            this.mi_NotificationMenu_Open.Click += new System.EventHandler(this.mi_NotificationMenu_Open_Click);
            // 
            // mi_NotificationMenu_Exit
            // 
            this.mi_NotificationMenu_Exit.Name = "mi_NotificationMenu_Exit";
            this.mi_NotificationMenu_Exit.Size = new System.Drawing.Size(180, 22);
            this.mi_NotificationMenu_Exit.Text = "Exit";
            this.mi_NotificationMenu_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mi_NotificationMenu_Exit.Click += new System.EventHandler(this.mi_NotificationMenu_Exit_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 374);
            this.Controls.Add(this.grp_Output);
            this.Controls.Add(this.grp_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinQuickQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.grp_Input.ResumeLayout(false);
            this.grp_Input.PerformLayout();
            this.grp_Output.ResumeLayout(false);
            this.grp_Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QR)).EndInit();
            this.tlp_Actions.ResumeLayout(false);
            this.tlp_Actions.PerformLayout();
            this.flp_Actions.ResumeLayout(false);
            this.cms_NotificationMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Input;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.PictureBox pb_QR;
        private System.Windows.Forms.TableLayoutPanel tlp_Actions;
        private System.Windows.Forms.FlowLayoutPanel flp_Actions;
        private System.Windows.Forms.Button btn_SaveToFile;
        private System.Windows.Forms.Button btn_CopyToClipboard;
        private System.Windows.Forms.NotifyIcon ni_MainIcon;
        private System.Windows.Forms.ContextMenuStrip cms_NotificationMenu;
        private System.Windows.Forms.ToolStripMenuItem mi_NotificationMenu_Open;
        private System.Windows.Forms.ToolStripMenuItem mi_NotificationMenu_Exit;
    }
}

