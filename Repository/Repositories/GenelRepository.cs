using Core.DTOs;
using Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Repositories
{
    public class GenelRepository : IGenelRepository
    {
        #region ..: Consturactor :..
        private readonly string _connectionString;
        public GenelRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion
        public SonucDTO HataKaydet(int hataKodu, string hataMesaji, string metodAdi, int kulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    HataKodu = hataKodu,
                    HataMesaji = hataMesaji,
                    MetodAdi = metodAdi,
                    KulID = kulID
                };

                return con.QuerySingleOrDefault<SonucDTO>(UYGULAMA_HATA_KAYDET, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<MenuGetirDTO> MenuGetir(int rolID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    RolID = rolID
                };

                return con.Query<MenuGetirDTO>(MENU_GETIR, parameters, commandType: CommandType.Text);
            }
        }

        private readonly string UYGULAMA_HATA_KAYDET = "log.UygulamaHataKaydet";
        private readonly string MENU_GETIR = "select * from dbo.tfMenuGetir(@RolID)";
    }
}
