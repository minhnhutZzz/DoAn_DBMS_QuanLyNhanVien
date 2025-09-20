using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
   public static class GlobalState
    {
        public static int MaTK { get; set; }
        public static string TenTaiKhoan { get; set; }
        public static string VaiTro { get; set; }
        public static string ConnectionString { get; set; }
    }
}
