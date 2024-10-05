using System.Data.SqlClient;
using System.Data;
using Core.DTOs;
using Dapper;
using Core.IRepositories;

namespace Repository.Repositories
{
    public class KullaniciRepository : IKullaniciRepository
    {
        #region ..: Consturactor :..
        private readonly string _connectionString;
        public KullaniciRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion

        public KullanicilarDTO KullaniciGiris(string kulAdi, string kulSifre)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    KulAdi = kulAdi,
                    KulSifre = kulSifre
                };

                return con.QuerySingleOrDefault<KullanicilarDTO>(GIRIS_KONTROL, parameters, commandType: CommandType.StoredProcedure);
            }
        }


        private readonly string GIRIS_KONTROL = "dbo.GirisKontrol";
    }
}
