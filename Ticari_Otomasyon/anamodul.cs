using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class anamodul : Form
    {
        musteriler musteriler;
        urunler urunler;
        personeller personeller;
        anasayfa anasayfa;
        uyelik uyelik;


        public string gelenveri = "";
        public anamodul()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new anasayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }
        }

        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(urunler == null || urunler.IsDisposed)
            {
                urunler = new urunler();
                urunler.MdiParent = this;
                urunler.Show();
            }
        }

        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteriler == null || musteriler.IsDisposed)
            {
                musteriler = new musteriler();
                musteriler.MdiParent = this;
                musteriler.Show();
            }
        }


        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personeller == null || personeller.IsDisposed)
            {
                personeller = new personeller();
                personeller.MdiParent = this;
                personeller.Show();
            }
        }

     
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new anasayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }
        }

    
        private void btnUyelik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (uyelik == null || uyelik.IsDisposed)
            {
                uyelik = new uyelik();

                uyelik.MdiParent = this;
                uyelik.Show();
            }
        }
    }
}
