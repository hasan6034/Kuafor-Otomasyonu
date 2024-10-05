using Core.DTOs;

namespace Core.IRepositories
{
    public interface IGenelRepository
    {
        SonucDTO HataKaydet(int hataKodu, string hataMesaji, string metodAdi, int kulID);
    }
}
