using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraBars.Ribbon.Internal;
using System.IO;
using Newtonsoft.Json;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Collections;

namespace Ticari_Otomasyon
{
    public partial class musteriler : Form
    {
        Database database = new Database();

        string masaustu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        public musteriler()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textId.Text = string.Empty;
            textAd.Text = "";
            textSoyad.Text = "";
            maskedTel.Text = "";            
            maskedTC.Text = "";
            textMail.Text = "";
            richAdres.Text = "";
        }

        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TBL_Musteriler", database.Connection());
            sqlDataAdapter.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }
       
        Database bgl = new Database();

        void listele()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = bgl.Connection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_Musteriler", connection);
                    da.Fill(dt);
                    gridControl1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"Veri Yok");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }


        }


        public string cinsiyet;
        public string yeniyol;
        
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                

                SqlCommand komut = new SqlCommand("INSERT INTO TBL_Musteriler (Ad, Soyad, Cinsiyet, DogumTarihi, KayitTarihi, TCNo, Email, Telefon, Adres, Fotoğraf,Deleted, Statu) values(@pAd,@pSoyad,@pCinsiyet,@pDogumTarihi,@pKayitTarihi,@pTCNo,@pEmail,@pTelefon,@pAdres,@pFotoğraf,DEFAULT,DEFAULT)", bgl.Connection());
                komut.Parameters.AddWithValue("@pAd", textAd.Text);
                komut.Parameters.AddWithValue("@pSoyad", textSoyad.Text);
                if (rdbErkek.Checked == true)
                {
                    komut.Parameters.AddWithValue("@pCinsiyet", cinsiyet = "E");
                }
                else
                {
                    komut.Parameters.AddWithValue("pCinsiyet", cinsiyet = "K");
                }
                komut.Parameters.AddWithValue("@pDogumTarihi", DateTime.Parse(dtDogum.Value.ToString()));
                komut.Parameters.AddWithValue("@pKayitTarihi", DateTime.Now);
                komut.Parameters.AddWithValue("@pTCNo", maskedTC.Text);
                komut.Parameters.AddWithValue("@pEmail", textMail.Text);
                komut.Parameters.AddWithValue("@pTelefon", maskedTel.Text);
                komut.Parameters.AddWithValue("@pAdres", richAdres.Text);
                komut.Parameters.AddWithValue("@pFotoğraf", Path.GetFileName(yeniyol));
                komut.ExecuteNonQuery();
                bgl.Connection().Close();
                MessageBox.Show("Üye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata;" + JsonConvert.SerializeObject(ex), " Hatalı veri girişi yapıldı. Lütfen yeniden deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Müşteriyi gerçekten silmek istiyor musun ?", "Önemli", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_Musteriler SET Deleted = 1 WHERE ID = @pId;", bgl.Connection());
                komut.Parameters.AddWithValue("@pId", textId.Text);
                komut.ExecuteNonQuery();
                bgl.Connection().Close();
                MessageBox.Show("Üye Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if(dr == null)
                    return;

                textId.Text = dr["ID"].ToString();
                textAd.Text = dr["Ad"].ToString();
                textSoyad.Text = dr["Soyad"].ToString();
                if (dr["Cinsiyet"].ToString() == "Erkek")
                {
                    rdbErkek.Checked = true;
                }
                else
                {
                    rdbKadin.Checked = true;
                }
                dtDogum.Text = dr["DogumTarihi"].ToString();
                //dateKayıt.Text = dr["KayitTarihi"].ToString();
                maskedTel.Text = dr["TCNo"].ToString();
                textMail.Text = dr["Email"].ToString();
                maskedTel.Text = dr["Telefon"].ToString();
                richAdres.Text = dr["Adres"].ToString();

                yeniyol = masaustu + "spor salonu otomasyonu\\SporSalonuOtomasyonu" + "\\Resimler\\" + dr["Fotoğraf"].ToString();
                if (!string.IsNullOrEmpty(yeniyol))
                    pcrResim.ImageLocation = yeniyol;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata", "Hata;"+JsonConvert.SerializeObject(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_Musteriler SET Ad = @pAd, Soyad = @pSoyad, Cinsiyet = @pCinsiyet, DogumTarihi = @pDogumTarihi, TCNo = @pTCNo, Email = @pEmail, Telefon = @pTelefon, Adres = @pAdres, Fotoğraf = @pFotoğraf WHERE ID = @pID;", bgl.Connection());
                komut.Parameters.AddWithValue("@pAd", textAd.Text);
                komut.Parameters.AddWithValue("@pSoyad", textSoyad.Text);
                if (rdbErkek.Checked == true)
                {
                    komut.Parameters.AddWithValue("@pCinsiyet", cinsiyet = "E");
                }
                else
                {
                    komut.Parameters.AddWithValue("pDogumTarihi", cinsiyet = "K");
                }
                
                komut.Parameters.AddWithValue("@pTCNo", maskedTC.Text);
                komut.Parameters.AddWithValue("@pEmail", textMail.Text);
                komut.Parameters.AddWithValue("@pTelefon", maskedTel.Text);
                komut.Parameters.AddWithValue("@pAdres", richAdres.Text);
                komut.Parameters.AddWithValue("@Fotoğraf", Path.GetFileName(yeniyol));
                komut.Parameters.AddWithValue("p11", textId.Text);
                komut.ExecuteNonQuery();
                bgl.Connection().Close();
                MessageBox.Show("Üye Bilgileri Yenilendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata", "Hata;" + JsonConvert.SerializeObject(ex), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void pcrResim_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Resim Dosyası|*.jpg;*png;*nef|Tüm Dosyalar|*.*";
                dosya.ShowDialog();
                string dosyayolu = dosya.FileName;
                yeniyol = masaustu + "spor salonu otomasyonu\\SporSalonuOtomasyonu" + "\\Resimler\\" + Guid.NewGuid().ToString() + dosya.DefaultExt;
                File.Copy(dosyayolu, yeniyol);
                pcrResim.ImageLocation = yeniyol;

            }
            catch (Exception)
            {
                yeniyol = "";
            }
            
        }
    }
}
