using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;
using Core.IRepositories;
using Core.IServices;

namespace Service.Services
{
    public class HizmetService : IHizmetService
    {
        #region ..: Consturactor :..
        readonly IHizmetRepository _hizmetRepository;
        public HizmetService(IHizmetRepository hizmetRepository)
        {
            _hizmetRepository = hizmetRepository;
        }

        #endregion

        public IEnumerable<HizmetlerDTO> GetHizmetler(int hizmetID)
        {
            return _hizmetRepository.GetHizmetler(hizmetID);
        }

        public SonucDTO HizmetSAVE(int hizmetID, string hizmetAdi, double hizmetFiyati, int sayfaID, int olusturanKulID)
        {
            return _hizmetRepository.HizmetSAVE(hizmetID, hizmetAdi, hizmetFiyati, sayfaID, olusturanKulID);
        }

        public SonucDTO HizmetDELETE(int hizmetID, int sayfaID, int olusturanKulID)
        {
            return _hizmetRepository.HizmetDELETE(hizmetID, sayfaID, olusturanKulID);
        }
    }
}
