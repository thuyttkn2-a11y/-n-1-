using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class MovieBUS
    {
        private MovieDAL dal = new MovieDAL();
        public List<MovieDTO> GetAllMovies() { return dal.GetAllMovies(); }
    }
}
