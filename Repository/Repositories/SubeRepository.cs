using Core.DTOs;
using Core.IRepositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Repository.Repositories
{
    public class SubeRepository : ISubeRepository
    {
        #region ..: Consturactor :..
        private readonly string _connectionString;
        public SubeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion

        public IEnumerable<SubeDTO> SubeList(int subeID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    SubeID = subeID
                };

                return con.Query<SubeDTO>(SUBE_LISTESI, parameters, commandType: CommandType.Text);
            }
        }

        private readonly string SUBE_LISTESI = "select * from tfSubeler(@SubeID)";
    }
}
