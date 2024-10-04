using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuafor_Otomasyonu
{
    public partial class frmAnaEkran : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            tileControl_Menu.ShowGroupText = true;
        }
    }
}