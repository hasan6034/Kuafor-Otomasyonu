using Core.DTOs;
using System.Collections.Generic;

namespace Core.IServices
{
    public interface IKullaniciService
    {
        KullanicilarDTO KullaniciGiris(string kulAdi, string kulSifre);
        IEnumerable<RolYetkileriDTO> RolYetkileriGetir(int rolID);
        IEnumerable<RollerDTO> RolGetir(int rolID);
        SonucDTO RolYetkiSAVE(int rolID, string rolAdi, string yetkiler, int sayfaID, int kulID);
        SonucDTO RolDELETE(int rolID, int sayfaID, int kulID);
        IEnumerable<KullanicilarDTO> KullaniciGetir(int kulID);
        SonucDTO KullaniciSAVE(KullanicilarDTO kullanici, int sayfaID, int olusturanKulID);
        SonucDTO KullaniciDELETE(int kulID, int sayfaID, int olusturanKulID);
    }
}
