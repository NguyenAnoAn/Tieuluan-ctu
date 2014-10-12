using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLyCongVan.Models
{
    public class MNguoiDung
    {

    }
    public class NguoiDungDBContext : DbContext
    {
        public DbSet<MNguoiDung> DSNguoiDung { get; set; }
    }
}