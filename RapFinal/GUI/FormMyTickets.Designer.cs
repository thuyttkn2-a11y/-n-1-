namespace GUI
{
    partial class FormMyTickets
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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.colTicketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeatCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.lblTitle.Location = new System.Drawing.Point(0, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(864, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎟  VÉ ĐÃ ĐẶT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTickets.ColumnHeadersHeight = 34;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTicketID,
                this.colMovieName,
                this.colShowDate,
                this.colShowTime,
                this.colRoomName,
                this.colSeatCode,
                this.colPrice,
                this.colBookingDate});
            this.dgvTickets.EnableHeadersVisualStyles = false;
            this.dgvTickets.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTickets.Location = new System.Drawing.Point(15, 62);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.RowTemplate.Height = 30;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(840, 370);
            this.dgvTickets.TabIndex = 1;
            this.dgvTickets.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.dgvTickets.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTickets.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTickets.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            // 
            // colTicketID
            // 
            this.colTicketID.FillWeight = 7F;
            this.colTicketID.HeaderText = "Mã Vé";
            this.colTicketID.Name = "colTicketID";
            // 
            // colMovieName
            // 
            this.colMovieName.FillWeight = 22F;
            this.colMovieName.HeaderText = "Tên Phim";
            this.colMovieName.Name = "colMovieName";
            // 
            // colShowDate
            // 
            this.colShowDate.FillWeight = 11F;
            this.colShowDate.HeaderText = "Ngày Chiếu";
            this.colShowDate.Name = "colShowDate";
            // 
            // colShowTime
            // 
            this.colShowTime.FillWeight = 8F;
            this.colShowTime.HeaderText = "Giờ";
            this.colShowTime.Name = "colShowTime";
            // 
            // colRoomName
            // 
            this.colRoomName.FillWeight = 9F;
            this.colRoomName.HeaderText = "Phòng";
            this.colRoomName.Name = "colRoomName";
            // 
            // colSeatCode
            // 
            this.colSeatCode.FillWeight = 6F;
            this.colSeatCode.HeaderText = "Ghế";
            this.colSeatCode.Name = "colSeatCode";
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 13F;
            this.colPrice.HeaderText = "Giá Vé";
            this.colPrice.Name = "colPrice";
            // 
            // colBookingDate
            // 
            this.colBookingDate.FillWeight = 24F;
            this.colBookingDate.HeaderText = "Ngày Đặt";
            this.colBookingDate.Name = "colBookingDate";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(15, 444);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄  Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(715, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕  Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(870, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Name = "FormMyTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vé Đã Đặt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeatCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookingDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}
