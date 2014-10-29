using QuanLyHop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyHop.Helpers
{
    public class KiemTraQuyen
    {
        /// <summary>
        /// kiem tra quyền người dùng được lưu trữ trong biến UInt32 có được cấp các quyền được hệ thống hay không.
        /// </summary>
        /// <param name="quyen">Biến lưu trữ quyền của người dùng </param>
        /// <param name="cocacquyen">danh sách các quyền cần kiểm tra </param>
        /// <returns></returns>
        public static bool KiemTraCoQuyen(UInt32 quyen,params QuyenSuDung[] cocacquyen)
        {
            bool ret = true;
            foreach (QuyenSuDung sq in cocacquyen)
            {
                ret &= ((quyen & (UInt32)sq) == (UInt32)sq);
                if (!ret)
                    break;
            }
            return ret;
        }
        public static UInt32 ADMIN { get { return 0xffffffff; } }
    }
}