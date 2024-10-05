using System.Data.SqlClient;
using System.Data;
using Core.DTOs;
using Dapper;
using Core.IRepositories;
using System.Collections.Generic;

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

        public IEnumerable<RolYetkileriDTO> RolYetkileriGetir(int rolID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    RolID = rolID
                };

                return con.Query<RolYetkileriDTO>(ROL_YETKILERI_GETIR, parameters, commandType: CommandType.Text);
            }
        }
        public IEnumerable<RollerDTO> RolGetir(int rolID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    RolID = rolID
                };

                return con.Query<RollerDTO>(ROL_GETIR, parameters, commandType: CommandType.Text);
            }
        }
        public SonucDTO RolYetkiSAVE(int rolID, string rolAdi, string yetkiler, int sayfaID, int kulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    RolID = rolID,
                    RolAdi = rolAdi,
                    Yetkiler = yetkiler,
                    SayfaID = sayfaID,
                    KulID = kulID
                };

                return con.QuerySingleOrDefault<SonucDTO>(ROL_SAVE, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public SonucDTO RolDELETE(int rolID, int sayfaID, int kulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    RolID = rolID,
                    SayfaID = sayfaID,
                    KulID = kulID
                };

                return con.QuerySingleOrDefault<SonucDTO>(ROL_DELETE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<KullanicilarDTO> KullaniciGetir(int kulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    KulID = kulID
                };

                return con.Query<KullanicilarDTO>(KULLANICI_GETIR, parameters, commandType: CommandType.Text);
            }

        }
        public SonucDTO KullaniciSAVE(int kulID, string kulAdi, int rolID, string adi, string soyadi,
                                                         string kulSifre, int durumID, int sayfaID, int olusturanKulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    KulID = kulID,
                    KulAdi = kulAdi,
                    RolID = rolID,
                    Adi = adi,
                    Soyadi = soyadi,
                    KulSifre = kulSifre,
                    DurumID = durumID,
                    SayfaID = sayfaID,
                    OlusturanKulID = olusturanKulID
                };

                return con.QuerySingleOrDefault<SonucDTO>(KULLANICI_SAVE, parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public SonucDTO KullaniciDELETE(int kulID, int sayfaID, int olusturanKulID)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    KulID = kulID,
                    SayfaID = sayfaID,
                    OlusturanKulID = olusturanKulID
                };

                return con.QuerySingleOrDefault<SonucDTO>(KULLANICI_DELETE, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private readonly string ROL_YETKILERI_GETIR = "select * from dbo.tfRolYetkileriByRolID(@RolID)";
        private readonly string ROL_GETIR = "select * from dbo.tfRoller(@RolID)";
        private readonly string ROL_DELETE = "dbo.RolDELETE";
        private readonly string ROL_SAVE = "dbo.RolSAVE";
        private readonly string KULLANICI_GETIR = "select * from dbo.tfKullanicilar(@KulID)";
        private readonly string KULLANICI_DELETE = "dbo.KullaniciDELETE";
        private readonly string KULLANICI_SAVE = "dbo.KullaniciSave";

        private readonly string GIRIS_KONTROL = "dbo.GirisKontrol";
    }
}
