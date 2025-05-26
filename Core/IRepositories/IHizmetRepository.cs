using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;

namespace Core.IRepositories
{
    public interface IHizmetRepository
    {
        IEnumerable<HizmetlerDTO> GetHizmetler(int hizmetID);
        SonucDTO HizmetSAVE(int hizmetID, string hizmetAdi, double hizmetFiyati, int sayfaID, int olusturanKulID);
        SonucDTO HizmetDELETE(int hizmetID, int sayfaID, int olusturanKulID);
    }
}
