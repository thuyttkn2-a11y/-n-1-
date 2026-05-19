namespace GUI
{
    partial class FormMovieList
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
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.colMovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.lblTitle.Location = new System.Drawing.Point(0, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(764, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎬  DANH SÁCH PHIM ĐANG CHIẾU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMovies.ColumnHeadersHeight = 34;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMovieID,
                this.colMovieName,
                this.colGenre,
                this.colDuration,
                this.colDescription});
            this.dgvMovies.EnableHeadersVisualStyles = false;
            this.dgvMovies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvMovies.Location = new System.Drawing.Point(15, 62);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersVisible = false;
            this.dgvMovies.RowTemplate.Height = 30;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(738, 368);
            this.dgvMovies.TabIndex = 1;
            this.dgvMovies.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.dgvMovies.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMovies.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMovies.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 245);
            // 
            // colMovieID
            // 
            this.colMovieID.HeaderText = "ID";
            this.colMovieID.Name = "colMovieID";
            this.colMovieID.Visible = false;
            // 
            // colMovieName
            // 
            this.colMovieName.FillWeight = 28F;
            this.colMovieName.HeaderText = "Tên Phim";
            this.colMovieName.Name = "colMovieName";
            // 
            // colGenre
            // 
            this.colGenre.FillWeight = 16F;
            this.colGenre.HeaderText = "Thể Loại";
            this.colGenre.Name = "colGenre";
            // 
            // colDuration
            // 
            this.colDuration.FillWeight = 12F;
            this.colDuration.HeaderText = "Thời Lượng";
            this.colDuration.Name = "colDuration";
            // 
            // colDescription
            // 
            this.colDescription.FillWeight = 44F;
            this.colDescription.HeaderText = "Mô Tả";
            this.colDescription.Name = "colDescription";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(533, 442);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 38);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Chọn Phim  ▶";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(395, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕  Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(768, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Name = "FormMovieList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Phim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
    }
}
