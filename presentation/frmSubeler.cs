using Core.DTOs;
using Core.IServices;
using DevExpress.XtraEditors;
using Repository.Repositories;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuafor_Otomasyonu
{
    public partial class frmSubeler : DevExpress.XtraEditors.XtraForm
    {
        public frmSubeler()
        {
            InitializeComponent();
        }

        #region ..: Declare :..

        private readonly ISubeService _subeService = new SubeService(
           new SubeRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        private readonly IGenelService _genelService = new GenelService(
           new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        #endregion

        private void frmSubeler_Load(object sender, EventArgs e)
        {
            gridControl_SubeListesi.DataSource = _subeService.SubeList(-1);
            tileView_SubeListesi.FocusedRowHandle = 0;
            tileView_SubeListesi.SelectRow(0);
        }

        private void simpleButton_Kaydet_Click(object sender, EventArgs e)
        {

        }
    }
}