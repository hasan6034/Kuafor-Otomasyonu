using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOs;
using Core.IRepositories;
using Dapper;

namespace Repository.Repositories
{
    public class HizmetRepository : IHizmetRepository
    {
        #region ..: Consturactor :..
        private readonly string _connectionString;
        public HizmetRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion

        public IEnumerable<HizmetlerDTO> GetHizmetler(int hizmetID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    HizmetID = hizmetID
                };

                return con.Query<HizmetlerDTO>(HIZMET_LISTESI, parameters, commandType: CommandType.Text);
            }
        }

        public SonucDTO HizmetSAVE(int hizmetID, string hizmetAdi, double hizmetFiyati, int sayfaID, int olusturanKulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    HizmetID = hizmetID,
                    HizmetAdi = hizmetAdi,
                    HizmetFiyati = hizmetFiyati,
                    SayfaID = sayfaID,
                    OlusturanKulID = olusturanKulID
                };
                return con.QueryFirstOrDefault<SonucDTO>(HIZMET_SAVE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public SonucDTO HizmetDELETE(int hizmetID, int sayfaID, int olusturanKulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    HizmetID = hizmetID,
                    SayfaID = sayfaID,
                    OlusturanKulID = olusturanKulID
                };
                return con.QueryFirstOrDefault<SonucDTO>(HIZMET_DELETE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private readonly string HIZMET_LISTESI = "select * from tfHizmetler(@HizmetID)";
        private readonly string HIZMET_SAVE = "HizmetSAVE";
        private readonly string HIZMET_DELETE = "HizmetDELETE";
    }
}
