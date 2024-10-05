using Core.DTOs;
using Core.IRepositories;
using Core.IServices;

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
    }
}
