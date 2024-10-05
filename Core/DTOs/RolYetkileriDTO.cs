using System;

namespace Core.DTOs
{
    public class RolYetkileriDTO : Object
    {
        public int RolID { get; set; }
        public string RolAdi { get; set; }
        public int SayfaID { get; set; }
        public string SayfaAdi { get; set; }
        public string ModulAdi { get; set; }
        public int Okuma { get; set; }
        public int Yazma { get; set; }
        public int Duzenleme { get; set; }
        public int Silme { get; set; }

        public override string ToString()
        {
            return SayfaID + "," + Okuma + "," + Yazma + "," + Duzenleme + "," + Silme + "@";
        }
    }
}
