using Core.DTOs;
using System.Collections.Generic;

namespace Core.IRepositories
{
    public interface ISubeRepository
    {
        IEnumerable<SubeDTO> SubeList(int subeID);
        SonucDTO SubeEkle(int subeID, string subeAdi, string telefon, string adres, int sayfaID, int olusturanKulID);
        SonucDTO SubeSil(int subeID, int sayfaID, int olusturanKulID);
    }
}
