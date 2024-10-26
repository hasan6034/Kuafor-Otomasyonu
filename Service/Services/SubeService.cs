using Core.DTOs;
using Core.IRepositories;
using Core.IServices;
using System.Collections.Generic;

namespace Service.Services
{
    public class SubeService : ISubeService
    {
        #region ..: Consturactor :..
        readonly ISubeRepository _subeRepository;
        public SubeService(ISubeRepository subeRepository)
        {
            _subeRepository = subeRepository;
        }

        #endregion

        public IEnumerable<SubeDTO> SubeList(int subeID)
        {
            return _subeRepository.SubeList(subeID);
        }

    }
}
