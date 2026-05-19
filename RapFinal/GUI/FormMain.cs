using System;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FormMain : Form
    {
        private UserDTO currentUser;

        public FormMain(UserDTO user)
        {
            currentUser = user;
            InitializeComponent();
            lblWelcome.Text = "Xin chào, " + currentUser.FullName + " !";
        }

        private void btnMovieList_Click(object sender, EventArgs e)
        {
            FormMovieList f = new FormMovieList(currentUser);
            f.ShowDialog();
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            FormMyTickets f = new FormMyTickets(currentUser);
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new FormLogin().Show();
                this.Close();
            }
        }
    }
}
