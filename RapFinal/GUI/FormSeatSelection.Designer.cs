namespace GUI
{
    partial class FormSeatSelection
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblLegendBooked = new System.Windows.Forms.Label();
            this.lblLegendSelected = new System.Windows.Forms.Label();
            this.lblLegendEmpty = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.lblTitle.Location = new System.Drawing.Point(0, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎬  TÊN PHIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location = new System.Drawing.Point(0, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(564, 22);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Thông tin suất chiếu";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendBooked
            // 
            this.lblLegendBooked.AutoSize = true;
            this.lblLegendBooked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendBooked.ForeColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.lblLegendBooked.Location = new System.Drawing.Point(18, 72);
            this.lblLegendBooked.Name = "lblLegendBooked";
            this.lblLegendBooked.TabIndex = 2;
            this.lblLegendBooked.Text = "■ Đã đặt";
            // 
            // lblLegendSelected
            // 
            this.lblLegendSelected.AutoSize = true;
            this.lblLegendSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendSelected.ForeColor = System.Drawing.Color.FromArgb(30, 160, 80);
            this.lblLegendSelected.Location = new System.Drawing.Point(115, 72);
            this.lblLegendSelected.Name = "lblLegendSelected";
            this.lblLegendSelected.TabIndex = 3;
            this.lblLegendSelected.Text = "■ Đang chọn";
            // 
            // lblLegendEmpty
            // 
            this.lblLegendEmpty.AutoSize = true;
            this.lblLegendEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendEmpty.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblLegendEmpty.Location = new System.Drawing.Point(235, 72);
            this.lblLegendEmpty.Name = "lblLegendEmpty";
            this.lblLegendEmpty.TabIndex = 4;
            this.lblLegendEmpty.Text = "■ Trống";
            // 
            // lblScreen
            // 
            this.lblScreen.BackColor = System.Drawing.Color.DimGray;
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblScreen.ForeColor = System.Drawing.Color.White;
            this.lblScreen.Location = new System.Drawing.Point(15, 100);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(538, 22);
            this.lblScreen.TabIndex = 5;
            this.lblScreen.Text = "━━━━━━━━━━━━━  MÀN HÌNH  ━━━━━━━━━━━━━";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeats
            // 
            this.pnlSeats.AutoScroll = true;
            this.pnlSeats.BackColor = System.Drawing.Color.White;
            this.pnlSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeats.Location = new System.Drawing.Point(15, 128);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(538, 330);
            this.pnlSeats.TabIndex = 6;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(193, 472);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(182, 46);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "🎟   ĐẶT VÉ";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // FormSeatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(568, 535);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblLegendBooked);
            this.Controls.Add(this.lblLegendSelected);
            this.Controls.Add(this.lblLegendEmpty);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.pnlSeats);
            this.Controls.Add(this.btnBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSeatSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Ghế";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblLegendBooked;
        private System.Windows.Forms.Label lblLegendSelected;
        private System.Windows.Forms.Label lblLegendEmpty;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Button btnBook;
    }
}
