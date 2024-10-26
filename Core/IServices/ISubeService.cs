using Core.DTOs;
using System.Collections.Generic;

namespace Core.IServices
{
    public interface ISubeService
    {
        IEnumerable<SubeDTO> SubeList(int subeID);

    }
}
