using Core.DTOs;
using System.Collections.Generic;

namespace Core.IRepositories
{
    public interface ISubeRepository
    {
        IEnumerable<SubeDTO> SubeList(int subeID);
    }
}
