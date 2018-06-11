namespace QuanLyKhachSan
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tcbmenu = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnkh = new System.Windows.Forms.ToolStripMenuItem();
            this.btndichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.btndsdp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnthanhtoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnhelp = new System.Windows.Forms.ToolStripButton();
            this.btndangxuat = new System.Windows.Forms.ToolStripButton();
            this.lbltenandloai = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcbmenu
            // 
            this.tcbmenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcbmenu.Location = new System.Drawing.Point(0, 41);
            this.tcbmenu.Name = "tcbmenu";
            this.tcbmenu.SelectedIndex = 0;
            this.tcbmenu.Size = new System.Drawing.Size(1326, 822);
            this.tcbmenu.TabIndex = 0;
            this.tcbmenu.SelectedIndexChanged += new System.EventHandler(this.tcbmenu_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnhelp,
            this.btndangxuat,
            this.lbltenandloai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1326, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnkh,
            this.btndichvu,
            this.btndsdp,
            this.btnthanhtoan});
            this.toolStripDropDownButton1.Image = global::QuanLyKhachSan.Properties.Resources._1493874144_menu;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(99, 29);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // btnkh
            // 
            this.btnkh.Image = global::QuanLyKhachSan.Properties.Resources._1493872786_User_group;
            this.btnkh.Name = "btnkh";
            this.btnkh.Size = new System.Drawing.Size(270, 30);
            this.btnkh.Text = "Khách Hàng";
            this.btnkh.Click += new System.EventHandler(this.btnkh_Click);
            // 
            // btndichvu
            // 
            this.btndichvu.Image = global::QuanLyKhachSan.Properties.Resources.dichvu;
            this.btndichvu.Name = "btndichvu";
            this.btndichvu.Size = new System.Drawing.Size(270, 30);
            this.btndichvu.Text = "Dịch Vụ";
            this.btndichvu.Click += new System.EventHandler(this.btndichvu_Click);
            // 
            // btndsdp
            // 
            this.btndsdp.Image = global::QuanLyKhachSan.Properties.Resources.vatdung;
            this.btndsdp.Name = "btndsdp";
            this.btndsdp.Size = new System.Drawing.Size(270, 30);
            this.btndsdp.Text = "Danh Sách Đặt Phòng";
            this.btndsdp.Click += new System.EventHandler(this.btndsdp_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Image = global::QuanLyKhachSan.Properties.Resources.phong;
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(270, 30);
            this.btnthanhtoan.Text = "Phòng";
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.Image = global::QuanLyKhachSan.Properties.Resources._1493873182_help_browser;
            this.btnhelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(106, 29);
            this.btnhelp.Text = "&Trợ Giúp";
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.Image = global::QuanLyKhachSan.Properties.Resources._1493874057_logout;
            this.btndangxuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(124, 29);
            this.btndangxuat.Text = "&Đăng Xuất";
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // lbltenandloai
            // 
            this.lbltenandloai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbltenandloai.Name = "lbltenandloai";
            this.lbltenandloai.Size = new System.Drawing.Size(150, 29);
            this.lbltenandloai.Text = "Chào User Name ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tcbmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcbmenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton btnhelp;
        private System.Windows.Forms.ToolStripButton btndangxuat;
        private System.Windows.Forms.ToolStripLabel lbltenandloai;
        private System.Windows.Forms.ToolStripMenuItem btnkh;
        private System.Windows.Forms.ToolStripMenuItem btndichvu;
        private System.Windows.Forms.ToolStripMenuItem btndsdp;
        private System.Windows.Forms.ToolStripMenuItem btnthanhtoan;
    }
}

