using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormMyTickets : Form
    {
        private TicketBUS ticketBUS = new TicketBUS();
        private UserDTO   currentUser;

        public FormMyTickets(UserDTO user)
        {
            currentUser = user;
            InitializeComponent();
            lblTitle.Text = "🎟  VÉ ĐÃ ĐẶT CỦA " + currentUser.FullName.ToUpper();
            LoadTickets();
        }

        private void LoadTickets()
        {
            try
            {
                dgvTickets.Rows.Clear();
                List<TicketDTO> tickets = ticketBUS.GetTicketsByUser(currentUser.UserID);
                foreach (TicketDTO t in tickets)
                    dgvTickets.Rows.Add(
                        t.TicketID,
                        t.MovieName,
                        t.ShowDate.ToString("dd/MM/yyyy"),
                        t.ShowTime.ToString(@"hh\:mm"),
                        t.RoomName,
                        t.SeatCode,
                        string.Format("{0:N0} VNĐ", t.Price),
                        t.BookingDate.ToString("dd/MM/yyyy HH:mm"));

                if (tickets.Count == 0)
                    MessageBox.Show("Bạn chưa đặt vé nào.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
