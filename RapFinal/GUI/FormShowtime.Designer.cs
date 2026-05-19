namespace GUI
{
    partial class FormShowtime
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
            this.lblSub = new System.Windows.Forms.Label();
            this.dgvShowtimes = new System.Windows.Forms.DataGridView();
            this.colShowtimeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.lblTitle.Location = new System.Drawing.Point(0, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(702, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎬  TÊN PHIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.Gray;
            this.lblSub.Location = new System.Drawing.Point(0, 52);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(702, 24);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Chọn suất chiếu bạn muốn xem:";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvShowtimes
            // 
            this.dgvShowtimes.AllowUserToAddRows = false;
            this.dgvShowtimes.AllowUserToDeleteRows = false;
            this.dgvShowtimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowtimes.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowtimes.ColumnHeadersHeight = 34;
            this.dgvShowtimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colShowtimeID,
                this.colRoomID,
                this.colShowDate,
                this.colShowTime,
                this.colRoomName,
                this.colPrice});
            this.dgvShowtimes.EnableHeadersVisualStyles = false;
            this.dgvShowtimes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvShowtimes.Location = new System.Drawing.Point(15, 84);
            this.dgvShowtimes.MultiSelect = false;
            this.dgvShowtimes.Name = "dgvShowtimes";
            this.dgvShowtimes.ReadOnly = true;
            this.dgvShowtimes.RowHeadersVisible = false;
            this.dgvShowtimes.RowTemplate.Height = 30;
            this.dgvShowtimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowtimes.Size = new System.Drawing.Size(672, 305);
            this.dgvShowtimes.TabIndex = 2;
            this.dgvShowtimes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.dgvShowtimes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowtimes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvShowtimes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 245);
            // 
            // colShowtimeID
            // 
            this.colShowtimeID.HeaderText = "ID";
            this.colShowtimeID.Name = "colShowtimeID";
            this.colShowtimeID.Visible = false;
            // 
            // colRoomID
            // 
            this.colRoomID.HeaderText = "RoomID";
            this.colRoomID.Name = "colRoomID";
            this.colRoomID.Visible = false;
            // 
            // colShowDate
            // 
            this.colShowDate.FillWeight = 25F;
            this.colShowDate.HeaderText = "Ngày Chiếu";
            this.colShowDate.Name = "colShowDate";
            // 
            // colShowTime
            // 
            this.colShowTime.FillWeight = 18F;
            this.colShowTime.HeaderText = "Giờ Chiếu";
            this.colShowTime.Name = "colShowTime";
            // 
            // colRoomName
            // 
            this.colRoomName.FillWeight = 22F;
            this.colRoomName.HeaderText = "Phòng";
            this.colRoomName.Name = "colRoomName";
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 35F;
            this.colPrice.HeaderText = "Giá Vé";
            this.colPrice.Name = "colPrice";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(528, 404);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(155, 38);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Chọn Suất  ▶";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(18, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 38);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "◀  Quay Lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(702, 460);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.dgvShowtimes);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnBack);
            this.Name = "FormShowtime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Suất Chiếu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.DataGridView dgvShowtimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowtimeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBack;
    }
}
