using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormMovieList : Form
    {
        private MovieBUS movieBUS = new MovieBUS();
        private UserDTO  currentUser;

        public FormMovieList(UserDTO user)
        {
            currentUser = user;
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                dgvMovies.Rows.Clear();
                List<MovieDTO> movies = movieBUS.GetAllMovies();
                foreach (MovieDTO m in movies)
                    dgvMovies.Rows.Add(m.MovieID, m.MovieName, m.Genre, m.Duration + " phút", m.Description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một bộ phim!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int    movieID   = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["colMovieID"].Value);
            string movieName = dgvMovies.SelectedRows[0].Cells["colMovieName"].Value.ToString();
            new FormShowtime(currentUser, movieID, movieName).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
