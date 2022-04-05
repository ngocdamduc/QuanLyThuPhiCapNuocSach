
namespace QuanLyThuPhiCapNuocsach
{
    partial class frmReportHD
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
            this.rptHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rptHD
            // 
            this.rptHD.ActiveViewIndex = -1;
            this.rptHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHD.Location = new System.Drawing.Point(0, 0);
            this.rptHD.Name = "rptHD";
            this.rptHD.Size = new System.Drawing.Size(1162, 699);
            this.rptHD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // frmReportHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptHD);
            this.Name = "frmReportHD";
            this.Text = "frmreportHD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptHD;
        private System.Windows.Forms.Label label1;
    }
}