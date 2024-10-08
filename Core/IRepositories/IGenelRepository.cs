using Core.DTOs;
using System.Collections.Generic;

namespace Core.IRepositories
{
    public interface IGenelRepository
    {
        SonucDTO HataKaydet(int hataKodu, string hataMesaji, string metodAdi, int kulID);
        IEnumerable<MenuGetirDTO> MenuGetir(int rolID);
    }
}
