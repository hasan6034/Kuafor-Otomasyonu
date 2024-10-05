using Core.DTOs;

namespace Core.IServices
{
    public interface IGenelService
    {
        SonucDTO HataKaydet(int hataKodu, string hataMesaji, string metodAdi, int kulID);
    }
}
