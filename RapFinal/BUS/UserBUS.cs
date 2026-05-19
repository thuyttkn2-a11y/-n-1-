using System;
using DAL;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        private UserDAL userDAL = new UserDAL();
        public UserDTO Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
            return userDAL.Login(username, password);
        }
    }
}
