namespace GUI
{
    partial class FormMain
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMovieList = new System.Windows.Forms.Button();
            this.btnMyTickets = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(0, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(444, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎬  RẠP CHIẾU PHIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGray;
            this.lblWelcome.Location = new System.Drawing.Point(0, 85);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(444, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMovieList
            // 
            this.btnMovieList.BackColor = System.Drawing.Color.FromArgb(200, 40, 40);
            this.btnMovieList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMovieList.ForeColor = System.Drawing.Color.White;
            this.btnMovieList.Location = new System.Drawing.Point(102, 148);
            this.btnMovieList.Name = "btnMovieList";
            this.btnMovieList.Size = new System.Drawing.Size(240, 55);
            this.btnMovieList.TabIndex = 2;
            this.btnMovieList.Text = "🎥   Danh Sách Phim";
            this.btnMovieList.UseVisualStyleBackColor = false;
            this.btnMovieList.Click += new System.EventHandler(this.btnMovieList_Click);
            // 
            // btnMyTickets
            // 
            this.btnMyTickets.BackColor = System.Drawing.Color.FromArgb(30, 110, 200);
            this.btnMyTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMyTickets.ForeColor = System.Drawing.Color.White;
            this.btnMyTickets.Location = new System.Drawing.Point(102, 222);
            this.btnMyTickets.Name = "btnMyTickets";
            this.btnMyTickets.Size = new System.Drawing.Size(240, 55);
            this.btnMyTickets.TabIndex = 3;
            this.btnMyTickets.Text = "🎟   Vé Đã Đặt";
            this.btnMyTickets.UseVisualStyleBackColor = false;
            this.btnMyTickets.Click += new System.EventHandler(this.btnMyTickets_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(157, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.ClientSize = new System.Drawing.Size(444, 365);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnMovieList);
            this.Controls.Add(this.btnMyTickets);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ - Rạp Chiếu Phim";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMovieList;
        private System.Windows.Forms.Button btnMyTickets;
        private System.Windows.Forms.Button btnLogout;
    }
}
