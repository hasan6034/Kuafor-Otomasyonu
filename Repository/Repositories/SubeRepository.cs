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

        public SonucDTO SubeEkle(int subeID, string subeAdi, string telefon, string adres, int sayfaID, int olusturanKulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    SubeID = subeID,
                    SubeAdi = subeAdi,
                    Telefon = telefon,
                    Adres = adres,
                    SayfaID = sayfaID,
                    OlusturanKulID = olusturanKulID
                };
                return con.QuerySingle<SonucDTO>(SUBE_EKLE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public SonucDTO SubeSil(int subeID, int sayfaID, int olusturanKulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    SubeID = subeID,
                    SayfaID = sayfaID,
                    OlusturanKulID = olusturanKulID
                };
                return con.QuerySingle<SonucDTO>(SUBE_SIL, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private readonly string SUBE_LISTESI = "select * from tfSubeler(@SubeID)";
        private readonly string SUBE_EKLE = "SubeSAVE"; // Stored Procedure for adding a branch
        private readonly string SUBE_SIL = "SubeDELETE"; // Stored Procedure for deleting a branch
    }
}
