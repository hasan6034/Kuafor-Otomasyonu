using Core.DTOs;
using System.Collections.Generic;

namespace Core.IServices
{
    public interface IGenelService
    {
        SonucDTO HataKaydet(int hataKodu, string hataMesaji, string metodAdi, int kulID);
        IEnumerable<MenuGetirDTO> MenuGetir(int rolID);
    }
}
