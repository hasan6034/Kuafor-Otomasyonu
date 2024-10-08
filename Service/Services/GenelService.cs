﻿using Core.DTOs;
using Core.IRepositories;
using Core.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class GenelService : IGenelService
    {
        #region ..: Consturactor :..
        readonly IGenelRepository _genelRepository;
        public GenelService(IGenelRepository genelRepository)
        {
            _genelRepository = genelRepository;
        }

        #endregion

        public SonucDTO HataKaydet(int hataKodu, string hataMesaji, string metodAdi, int kulID)
        {
            return _genelRepository.HataKaydet(hataKodu, hataMesaji, metodAdi, kulID);
        }
        public IEnumerable<MenuGetirDTO> MenuGetir(int rolID)
        {
            return _genelRepository.MenuGetir(rolID);
        }
    }
}
