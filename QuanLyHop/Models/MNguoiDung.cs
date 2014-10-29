using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLyHop.Models
{
    public class MNguoiDung
    {
        public string Hoten { get; set; }
        public string Chucvu { get; set; }
        public string Username { get; set; }
    }
    public class NguoiDungDBContext : DbContext
    {
        public DbSet<MNguoiDung> DSNguoiDung { get; set; }
    }
}