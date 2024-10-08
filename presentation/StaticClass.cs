using Core.DTOs;
using System.Collections.Generic;

namespace Kuafor_Otomasyonu
{
    public class StaticClass
    {
        public static int KulID { get; set; }
        public static string KulAdi { get; set; }
        public static string AdSoyad { get; set; }
        public static int RoleID { get; set; }
        public static IEnumerable<RolYetkileriDTO> Yetkiler { get; set; }
    }
}
