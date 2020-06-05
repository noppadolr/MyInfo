namespace MyInfo
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
            this.textBoxCommand5 = new Janus.Windows.Ribbon.TextBoxCommand();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLblJHCIS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLblServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuSendData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheckData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJhcisConSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSeverConSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHDCConSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCommand5
            // 
            this.textBoxCommand5.Key = "textBoxCommand4";
            this.textBoxCommand5.Name = "textBoxCommand4";
            // 
            // 
            // 
            this.textBoxCommand5.TextBox.Location = new System.Drawing.Point(120, 83);
            this.textBoxCommand5.TextBox.Name = "";
            this.textBoxCommand5.TextBox.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLblJHCIS,
            this.toolStripStatusLabel1,
            this.StatusLblServer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLblJHCIS
            // 
            this.StatusLblJHCIS.Name = "StatusLblJHCIS";
            this.StatusLblJHCIS.Size = new System.Drawing.Size(31, 17);
            this.StatusLblJHCIS.Text = "jhcis";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // StatusLblServer
            // 
            this.StatusLblServer.Name = "StatusLblServer";
            this.StatusLblServer.Size = new System.Drawing.Size(38, 17);
            this.StatusLblServer.Text = "server";
            // 
            // MenuSendData
            // 
            this.MenuSendData.Name = "MenuSendData";
            this.MenuSendData.Size = new System.Drawing.Size(56, 59);
            this.MenuSendData.Text = "ส่งข้อมูล";
            this.MenuSendData.Click += new System.EventHandler(this.MenuSendData_Click);
            // 
            // MenuReport
            // 
            this.MenuReport.Name = "MenuReport";
            this.MenuReport.Size = new System.Drawing.Size(52, 59);
            this.MenuReport.Text = "รายงาน";
            // 
            // menuCheckData
            // 
            this.menuCheckData.Name = "menuCheckData";
            this.menuCheckData.Size = new System.Drawing.Size(87, 59);
            this.menuCheckData.Text = "ตรวจสอบข้อมูล";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSetting,
            this.MenuSendData,
            this.MenuReport,
            this.menuCheckData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 63);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuSetting
            // 
            this.MenuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnJhcisConSetting,
            this.btnSeverConSetting,
            this.btnHDCConSetting});
            this.MenuSetting.Image = global::MyInfo.Properties.Resources.icons8_settings_40;
            this.MenuSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuSetting.Name = "MenuSetting";
            this.MenuSetting.Size = new System.Drawing.Size(52, 59);
            this.MenuSetting.Text = "ตั้งค่า";
            this.MenuSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnJhcisConSetting
            // 
            this.btnJhcisConSetting.Name = "btnJhcisConSetting";
            this.btnJhcisConSetting.Size = new System.Drawing.Size(186, 22);
            this.btnJhcisConSetting.Text = "ตั้งค่าเชื่อมต่อ JHCIS";
            // 
            // btnSeverConSetting
            // 
            this.btnSeverConSetting.Name = "btnSeverConSetting";
            this.btnSeverConSetting.Size = new System.Drawing.Size(186, 22);
            this.btnSeverConSetting.Text = "ตั้งค่าการเชื่อมต่อ Server";
            // 
            // btnHDCConSetting
            // 
            this.btnHDCConSetting.Name = "btnHDCConSetting";
            this.btnHDCConSetting.Size = new System.Drawing.Size(186, 22);
            this.btnHDCConSetting.Text = "ตั้งค่าการเชื่อมต่อ HDC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Janus.Windows.Ribbon.TextBoxCommand textBoxCommand5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLblJHCIS;
        private System.Windows.Forms.ToolStripStatusLabel StatusLblServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem MenuSetting;
        private System.Windows.Forms.ToolStripMenuItem MenuSendData;
        private System.Windows.Forms.ToolStripMenuItem MenuReport;
        private System.Windows.Forms.ToolStripMenuItem menuCheckData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnJhcisConSetting;
        private System.Windows.Forms.ToolStripMenuItem btnSeverConSetting;
        private System.Windows.Forms.ToolStripMenuItem btnHDCConSetting;
    }
}

