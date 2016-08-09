using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfStokTakibi.Model;

namespace wfStokTakibi
{
    public partial class frmmustericariekstre : Form
    {
        public frmmustericariekstre()
        {
            InitializeComponent();
        }
        CariHareket ch = new CariHareket();
        Cari c = new Cari();
        DataTable dt = new DataTable();
        private void frmmustericariekstre_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            dtilktarih.Value = DateTime.Now.AddMonths(1);
            rbTumFirmalar.Checked = true;

        }

        private void rbAlicilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "Alıcı";
            dt = c.carilergetirbycaritipi(Genel.caritipi);
            dgvcariler.DataSource = dt;
        }

        private void rbSaticilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "Satıcı";

            dt = c.carilergetirbycaritipi(Genel.caritipi);
            dgvcariler.DataSource = dt;
        }

        private void rbTumFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.caritipi = "";

            dt = c.carilergetirbycaritipi(Genel.caritipi);
            dgvcariler.DataSource = dt;
        }

        private void dgvcariler_DoubleClick(object sender, EventArgs e)
        {
            Genel.carino =Convert.ToInt32(dgvcariler.SelectedRows[0].Cells["CariNo"].Value);
            dgvcariekstre.DataSource = ch.carilergetirbytarihlerarasiandcari(Genel.carino);
        }
    }
}
