using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormSeatSelection : Form
    {
        private SeatBUS   seatBUS   = new SeatBUS();
        private TicketBUS ticketBUS = new TicketBUS();

        private UserDTO currentUser;
        private int     showtimeID, roomID;
        private string  movieName, showDate, showTime, roomName, price;

        private SeatDTO selectedSeat   = null;
        private Button  selectedButton = null;

        public FormSeatSelection(UserDTO user, int showtimeID, int roomID,
            string movieName, string showDate, string showTime, string roomName, string price)
        {
            currentUser     = user;
            this.showtimeID = showtimeID;
            this.roomID     = roomID;
            this.movieName  = movieName;
            this.showDate   = showDate;
            this.showTime   = showTime;
            this.roomName   = roomName;
            this.price      = price;

            InitializeComponent();

            lblTitle.Text = "🎬  " + movieName.ToUpper();
            lblInfo.Text  = "📅 " + showDate + "   ⏰ " + showTime +
                            "   🏠 " + roomName + "   💰 " + price;
            LoadSeats();
        }

        private void LoadSeats()
        {
            pnlSeats.Controls.Clear();
            selectedSeat   = null;
            selectedButton = null;

            try
            {
                List<SeatDTO> seats = seatBUS.GetSeatsByShowtime(roomID, showtimeID);

                int col = 0, row = 0;
                int btnW = 64, btnH = 48, maxCols = 5;

                foreach (SeatDTO seat in seats)
                {
                    Button btn = new Button
                    {
                        Text      = seat.SeatCode,
                        Size      = new Size(btnW, btnH),
                        Location  = new Point(18 + col * (btnW + 10), 14 + row * (btnH + 10)),
                        Font      = new Font("Segoe UI", 9, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Cursor    = Cursors.Hand,
                        Tag       = seat
                    };
                    btn.FlatAppearance.BorderSize = 0;

                    if (seat.IsBooked)
                    {
                        btn.BackColor = Color.FromArgb(200, 50, 50);
                        btn.ForeColor = Color.White;
                        btn.Enabled   = false;
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(200, 200, 200);
                        btn.ForeColor = Color.Black;
                        btn.Click    += SeatButton_Click;
                    }

                    pnlSeats.Controls.Add(btn);
                    col++;
                    if (col >= maxCols) { col = 0; row++; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button  clickedBtn  = (Button)sender;
            SeatDTO clickedSeat = (SeatDTO)clickedBtn.Tag;

            if (selectedButton != null && selectedButton != clickedBtn)
            {
                selectedButton.BackColor = Color.FromArgb(200, 200, 200);
                selectedButton.ForeColor = Color.Black;
            }

            if (selectedButton == clickedBtn)
            {
                clickedBtn.BackColor = Color.FromArgb(200, 200, 200);
                clickedBtn.ForeColor = Color.Black;
                selectedSeat   = null;
                selectedButton = null;
                return;
            }

            clickedBtn.BackColor = Color.FromArgb(30, 160, 80);
            clickedBtn.ForeColor = Color.White;
            selectedSeat   = clickedSeat;
            selectedButton = clickedBtn;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (selectedSeat == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế trước khi đặt vé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string msg = "Xác nhận đặt vé?\n\n" +
                         "Phim  : " + movieName             + "\n" +
                         "Ngày  : " + showDate              + "\n" +
                         "Giờ   : " + showTime              + "\n" +
                         "Phòng : " + roomName              + "\n" +
                         "Ghế   : " + selectedSeat.SeatCode + "\n" +
                         "Giá   : " + price;

            if (MessageBox.Show(msg, "Xác Nhận Đặt Vé",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ticketBUS.BookTicket(currentUser.UserID, showtimeID, selectedSeat.SeatID);
                    MessageBox.Show("🎉  Đặt vé thành công!\nCảm ơn bạn đã sử dụng dịch vụ.",
                        "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSeats();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
