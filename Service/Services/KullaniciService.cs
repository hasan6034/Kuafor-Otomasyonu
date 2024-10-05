using Core.DTOs;
using Core.IRepositories;
using Core.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class KullaniciService : IKullaniciService
    {
        #region ..: Consturactor :..
        IKullaniciRepository _kullaniciRepository;
        public KullaniciService(IKullaniciRepository kullaniciRepository)
        {
            _kullaniciRepository = kullaniciRepository;
        }

        #endregion

        public KullanicilarDTO KullaniciGiris(string kulAdi, string kulSifre)
        {
            return _kullaniciRepository.KullaniciGiris(kulAdi, kulSifre);
        }

        public IEnumerable<RolYetkileriDTO> RolYetkileriGetir(int rolID)
        {
            return _kullaniciRepository.RolYetkileriGetir(rolID);
        }
        public IEnumerable<RollerDTO> RolGetir(int rolID)
        {
            return _kullaniciRepository.RolGetir(rolID);
        }
        public SonucDTO RolYetkiSAVE(int rolID, string rolAdi, string yetkiler, int sayfaID, int kulID)
        {
            return _kullaniciRepository.RolYetkiSAVE(rolID, rolAdi, yetkiler, sayfaID, kulID);
        }
        public SonucDTO RolDELETE(int rolID, int sayfaID, int kulID)
        {
            return _kullaniciRepository.RolDELETE(rolID, sayfaID, kulID);
        }
        public IEnumerable<KullanicilarDTO> KullaniciGetir(int kulID)
        {
            return _kullaniciRepository.KullaniciGetir(kulID);
        }
        public SonucDTO KullaniciSAVE(KullanicilarDTO kullanici, int sayfaID, int olusturanKulID)
        {
            return _kullaniciRepository.KullaniciSAVE(kullanici.KulID, kullanici.KulAdi, kullanici.RolID, kullanici.Adi, kullanici.Soyadi,
                                                                kullanici.KulSifre, kullanici.DurumID, sayfaID, olusturanKulID);
        }
        public SonucDTO KullaniciDELETE(int kulID, int sayfaID, int olusturanKulID)
        {
            return _kullaniciRepository.KullaniciDELETE(kulID, sayfaID, olusturanKulID);
        }

    }
}
