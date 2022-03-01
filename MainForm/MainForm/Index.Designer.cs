
namespace QuanLyThuPhiCapNuocsach
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.toolQLHD = new System.Windows.Forms.ToolStripButton();
            this.toolQLNV = new System.Windows.Forms.ToolStripButton();
            this.toolQLKH = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolQLCT = new System.Windows.Forms.ToolStripButton();
            this.lbHeading = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbnam = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbdongho = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctgiupdo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolQLHD
            // 
            this.toolQLHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolQLHD.ForeColor = System.Drawing.Color.Red;
            this.toolQLHD.Image = ((System.Drawing.Image)(resources.GetObject("toolQLHD.Image")));
            this.toolQLHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQLHD.Name = "toolQLHD";
            this.toolQLHD.Size = new System.Drawing.Size(163, 27);
            this.toolQLHD.Text = "Quản Lý Hóa Đơn";
            this.toolQLHD.Click += new System.EventHandler(this.toolQLHD_Click);
            // 
            // toolQLNV
            // 
            this.toolQLNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolQLNV.ForeColor = System.Drawing.Color.Red;
            this.toolQLNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQLNV.Name = "toolQLNV";
            this.toolQLNV.Size = new System.Drawing.Size(154, 27);
            this.toolQLNV.Text = "Quản Lý Nhân Viên";
            this.toolQLNV.Click += new System.EventHandler(this.toolQLNV_Click);
            // 
            // toolQLKH
            // 
            this.toolQLKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolQLKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolQLKH.ForeColor = System.Drawing.Color.Red;
            this.toolQLKH.Image = ((System.Drawing.Image)(resources.GetObject("toolQLKH.Image")));
            this.toolQLKH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQLKH.Name = "toolQLKH";
            this.toolQLKH.Size = new System.Drawing.Size(188, 27);
            this.toolQLKH.Text = "Quản Lý Khách Hàng";
            this.toolQLKH.Click += new System.EventHandler(this.toolQLKH_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolQLKH,
            this.toolQLNV,
            this.toolQLCT,
            this.toolQLHD});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1267, 30);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolQLCT
            // 
            this.toolQLCT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolQLCT.ForeColor = System.Drawing.Color.Red;
            this.toolQLCT.Image = ((System.Drawing.Image)(resources.GetObject("toolQLCT.Image")));
            this.toolQLCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQLCT.Name = "toolQLCT";
            this.toolQLCT.Size = new System.Drawing.Size(161, 27);
            this.toolQLCT.Text = "Quản Lý Công Tơ";
            this.toolQLCT.Click += new System.EventHandler(this.toolQLCT_Click);
            // 
            // lbHeading
            // 
            this.lbHeading.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHeading.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lbHeading.Location = new System.Drawing.Point(99, 9);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(617, 31);
            this.lbHeading.TabIndex = 14;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbnam
            // 
            this.lbnam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbnam.Name = "lbnam";
            this.lbnam.Size = new System.Drawing.Size(0, 19);
            // 
            // lbdongho
            // 
            this.lbdongho.AutoSize = false;
            this.lbdongho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdongho.ForeColor = System.Drawing.Color.Red;
            this.lbdongho.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lbdongho.Name = "lbdongho";
            this.lbdongho.Size = new System.Drawing.Size(109, 19);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbdongho,
            this.lbnam});
            this.statusStrip1.Location = new System.Drawing.Point(0, 713);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1267, 25);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1267, 49);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolExit
            // 
            this.toolExit.AutoSize = false;
            this.toolExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolExit.ForeColor = System.Drawing.Color.Blue;
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(60, 30);
            this.toolExit.Text = "Exit";
            this.toolExit.ToolTipText = "Exit";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // ctgiupdo
            // 
            this.ctgiupdo.Name = "ctgiupdo";
            this.ctgiupdo.Size = new System.Drawing.Size(133, 24);
            this.ctgiupdo.Text = "Trợ giúp";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctgiupdo,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 58);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 738);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Index";
            this.Text = "Quản Lý Thu Phí Cấp Nước Sạch";
            this.Load += new System.EventHandler(this.Index_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolQLHD;
        private System.Windows.Forms.ToolStripButton toolQLNV;
        private System.Windows.Forms.ToolStripButton toolQLKH;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolQLCT;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripStatusLabel lbnam;
        private System.Windows.Forms.ToolStripStatusLabel lbdongho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctgiupdo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
    }
}