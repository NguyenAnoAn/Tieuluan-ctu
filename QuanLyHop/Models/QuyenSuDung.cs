﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyHop.Models
{
    public enum QuyenSuDung
    {
        TAOCUOCHOP = 0x1,
        TAONGUOIDUNG = 0x2,
        PHANQUYENNGUOIDUNG = 0x4,
        LAPKEHOACHHOP = 0x8,
        XEMCACCUOCHOP =0x10,
        BINHLUANCUOCHOP = 0x20,
        BINHLUANVOITENNGUOIKHAC=0x40,

    }
}