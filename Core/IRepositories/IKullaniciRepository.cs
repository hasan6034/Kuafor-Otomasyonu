using Core.DTOs;

namespace Core.IRepositories
{
    public interface IKullaniciRepository
    {
        KullanicilarDTO KullaniciGiris(string kulAdi, string kulSifre);
    }
}
