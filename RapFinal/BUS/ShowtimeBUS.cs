using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class ShowtimeBUS
    {
        private ShowtimeDAL dal = new ShowtimeDAL();
        public List<ShowtimeDTO> GetShowtimesByMovie(int movieID) { return dal.GetShowtimesByMovie(movieID); }
    }
}
