using Core.DTOs;
using System.Collections.Generic;

namespace Core.IRepositories
{
    public interface IKullaniciRepository
    {
        KullanicilarDTO KullaniciGiris(string kulAdi, string kulSifre);
        IEnumerable<RolYetkileriDTO> RolYetkileriGetir(int rolID);
        IEnumerable<RollerDTO> RolGetir(int rolID);
        SonucDTO RolYetkiSAVE(int rolID, string rolAdi, string yetkiler, int sayfaID, int kulID);
        SonucDTO RolDELETE(int rolID, int sayfaID, int kulID);
    }
}
