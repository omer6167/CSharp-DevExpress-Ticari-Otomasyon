using Newtonsoft.Json;
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
    public partial class urunler : Form
    {
        Database database = new Database();
        public urunler()
        {
            InitializeComponent();
        }
        string yol = string.Empty;
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TBL_URUN_PAKETLERI", database.Connection());
            sqlDataAdapter.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void temizle()
        {
            textId.Text = "";
            textAd.Text = "";
            textFiyat.Text = "";
            textSure.Text = "";

            
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TBL_URUN_PAKETLERI (Ad, Fiyat, Fotoğraf, Sure) VALUES (@pAd, @pFiyat, @pFotoğraf, @pSure);", database.Connection());
                cmd.Parameters.AddWithValue("@pAd", textAd.Text);
                cmd.Parameters.AddWithValue("@pFiyat", textFiyat.Text);
                cmd.Parameters.AddWithValue("@pFotoğraf", yol);
                cmd.Parameters.AddWithValue("@pSure", textSure.Text);

                cmd.ExecuteNonQuery();
                database.Connection().Close();
                MessageBox.Show("Başarıyla kayıt eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata;" + JsonConvert.SerializeObject(ex), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dt = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                //MessageBox.Show( JsonConvert.SerializeObject(dt));
                textId.Text = dt["ID"].ToString();
                textAd.Text = dt["Ad"].ToString();
                textFiyat.Text = dt["Fiyat"].ToString();
                yol = dt["Fotoğraf"].ToString();
                textSure.Text = dt["Sure"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata;" + JsonConvert.SerializeObject(ex), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı silmek istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("UPDATE TBL_URUN_PAKETLERI SET Deleted = 1 WHERE ID = @pID", database.Connection());
                cmd.Parameters.AddWithValue("@pID", textId.Text);
                cmd.ExecuteNonQuery();
                database.Connection().Close();
                MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                Listele();
                temizle();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE TBL_URUN_PAKETLERI SET Ad = @pAd, Fiyat = @pFiyat, Fotoğraf = @pFotoğraf, Sure = @pSure WHERE ID = @pID;", database.Connection());
                cmd.Parameters.AddWithValue("@pAd", textAd.Text);
                cmd.Parameters.AddWithValue("@pFiyat", textFiyat.Text);
                cmd.Parameters.AddWithValue("@pFotoğraf", yol);
                cmd.Parameters.AddWithValue("@pSure", textSure.Text);
                cmd.Parameters.AddWithValue("@pID", textId.Text);
                cmd.ExecuteNonQuery();
                database.Connection().Close();
                MessageBox.Show("Başarıyla kayıt güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata;" + JsonConvert.SerializeObject(ex), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void pcrResim_Click(object sender, EventArgs e)
        {

        }
    }
}
