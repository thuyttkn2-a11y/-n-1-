using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormShowtime : Form
    {
        private ShowtimeBUS showtimeBUS = new ShowtimeBUS();
        private UserDTO     currentUser;
        private int         movieID;
        private string      movieName;

        public FormShowtime(UserDTO user, int movieID, string movieName)
        {
            currentUser    = user;
            this.movieID   = movieID;
            this.movieName = movieName;
            InitializeComponent();
            lblTitle.Text = "🎬  " + movieName.ToUpper();
            LoadShowtimes();
        }

        private void LoadShowtimes()
        {
            try
            {
                dgvShowtimes.Rows.Clear();
                List<ShowtimeDTO> list = showtimeBUS.GetShowtimesByMovie(movieID);
                foreach (ShowtimeDTO st in list)
                    dgvShowtimes.Rows.Add(
                        st.ShowtimeID,
                        st.RoomID,
                        st.ShowDate.ToString("dd/MM/yyyy"),
                        st.ShowTime.ToString(@"hh\:mm"),
                        st.RoomName,
                        string.Format("{0:N0} VNĐ", st.Price));

                if (list.Count == 0)
                    MessageBox.Show("Không có suất chiếu nào cho phim này.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvShowtimes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một suất chiếu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var row = dgvShowtimes.SelectedRows[0];
            new FormSeatSelection(
                currentUser,
                Convert.ToInt32(row.Cells["colShowtimeID"].Value),
                Convert.ToInt32(row.Cells["colRoomID"].Value),
                movieName,
                row.Cells["colShowDate"].Value.ToString(),
                row.Cells["colShowTime"].Value.ToString(),
                row.Cells["colRoomName"].Value.ToString(),
                row.Cells["colPrice"].Value.ToString()
            ).ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
