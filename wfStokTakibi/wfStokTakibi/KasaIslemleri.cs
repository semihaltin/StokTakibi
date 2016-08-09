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
    public partial class KasaIslemleri : Form
    {
        public KasaIslemleri()
        {
            InitializeComponent();
        }

        private void KasaIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {
            //İşlem tarihine kadar olan devirler gösterilmeli...
            Kasa k = new Kasa();
            k.KasaDevirleriGetir(txtTarih.Text, txtDevirGiren, txtDevirCikan, txtDevirBakiye);
            //İşlem tarihindeki kasa hareketleri listelenmeli...
            k.KasaHareketleriGetir(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTuru.Text = cbIslemTurleri.SelectedItem.ToString();
            //CariSorgulamadan firma seçtirilir.
            if (txtIslemTuru.Text == "Ödeme")
            {
                Genel.caritipi = "Satıcı";
            }
            else if (txtIslemTuru.Text == "Tahsilat")
            {
                Genel.caritipi = "Alıcı";
            }
            CariSorgulama frm = new CariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtCariNo.Text = Genel.carino.ToString();
            txtCariUnvan.Text = Genel.cariunvan;
            txtBelge.Focus();
            //Giren-Cikan readonly özelliklerini ayarla.
            if (cbIslemTurleri.SelectedItem.ToString() == "Tahsilat")
            {
                txtGiren.ReadOnly = false;
                txtCikan.ReadOnly = true;
            }
            else if (cbIslemTurleri.SelectedItem.ToString() == "Ödeme")
            {
                txtGiren.ReadOnly = true;
                txtCikan.ReadOnly = false;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtID.Clear();
            txtIslemTarihi.Text = txtTarih.Text;
            txtIslemTuru.Clear();
            txtCariUnvan.Clear();
            txtCariNo.Clear();
            txtBelge.Clear();
            txtGiren.Text = "0";
            txtCikan.Text = "0";
            txtIslemTuru.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIslemTuru.Text.Trim() != "" && txtCariUnvan.Text.Trim() != "")
            {
                if (txtGiren.Text == "0" && txtCikan.Text == "0")
                {
                    MessageBox.Show("Tutar girmelisiniz!");
                    txtGiren.Focus();
                }
                else
                {
                    Kasa k = new Kasa();
                    k.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
                    k.IslemTuru = txtIslemTuru.Text;
                    k.CariNo = Convert.ToInt32(txtCariNo.Text);
                    k.Belge = txtBelge.Text;
                    k.Giren = Convert.ToDouble(txtGiren.Text);
                    k.Cikan = Convert.ToDouble(txtCikan.Text);
                    int kayitno = k.KasaHareketEkle(k);
                    if (kayitno > 0)
                    {
                        MessageBox.Show("Kasa hareketi eklendi.");
                        k.KasaHareketleriGetir(txtTarih.Text, lvHareketler, txtToplamGiren, txtToplamCikan, txtBakiye);
                        //CariHareket eklenecek.


                    }
                }
            }
            else { MessageBox.Show("İşlem Türü, Cari Ünvan seçili olmalıdır."); }
        }
    }
}
