using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Ticari_Otomasyon
{
    public partial class personeller : Form
    {
        Database database = new Database();
        sehirler sehirler = new sehirler();
        public personeller()
        {
            InitializeComponent();
        }

        private void listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * FROM TBL_Personeller", database.Connection());
            dr.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void temizle()
        {
            textId.Text = string.Empty;
            textPersKimlik.Text = "";
            textAd.Text = "";
            textSoyad.Text = "";
            textGorev.Text = "";
            maskedTel.Text = "";
            textMail.Text = "";
            richAdres.Text = "";
            textCalismaSaatleri.Text = "";
            textMaas.Text = "";

        }

        private void personeller_Load(object sender, EventArgs e)
        {
            
            listele();
            temizle();
        }

     

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                textId.Text = dataRow["ID"].ToString();
                textPersKimlik.Text = dataRow["PeronelID"].ToString();
                textAd.Text = dataRow["Ad"].ToString();
                textSoyad.Text = dataRow["Soyad"].ToString();
                textGorev.Text = dataRow["Gorev"].ToString();
                maskedTel.Text = dataRow["TelefonNo"].ToString();
                textMail.Text = dataRow["Email"].ToString();
                richAdres.Text = dataRow["Adres"].ToString();
                textCalismaSaatleri.Text = dataRow["CalismaSaatleri"].ToString();
                textMaas.Text = dataRow["Maas"].ToString();

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Personeli silmek istiyor musun ?","Önemli",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("update TBL_Personeller set Deleted=1 TBL_Personeller where id=@pId", database.Connection());
                komut.Parameters.AddWithValue("@pId", textId.Text);
                komut.ExecuteNonQuery();
                database.Connection().Close();
                listele();
                temizle();
                MessageBox.Show("Personel başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_Personeller   SET PeronelID = @pPeronelID, Ad = @pAd, Soyad = @pSoyad, Gorev = @pGorev,TelefonNo = @pTelefonNo,Email = @pEmail,Adres = @pAdres,        CalismaSaatleri = @pCalismaSaatleri, Maas = @pMaas  WHERE Id = @pId", database.Connection());

                komut.Parameters.AddWithValue("@pPeronelID", textPersKimlik.Text);
                komut.Parameters.AddWithValue("@pAd", textAd.Text);
                komut.Parameters.AddWithValue("@pSoyad", textSoyad.Text);
                komut.Parameters.AddWithValue("@pGorev", textGorev.Text);
                komut.Parameters.AddWithValue("@pTelefonNo", maskedTel.Text);
                komut.Parameters.AddWithValue("@pEmail", textMail.Text);
                komut.Parameters.AddWithValue("@pAdres", richAdres.Text);
                komut.Parameters.AddWithValue("@pCalismaSaatleri", textCalismaSaatleri.Text);
                komut.Parameters.AddWithValue("@pMaas", Decimal.Parse(textMaas.Text));

                komut.Parameters.AddWithValue("@pId", textId.Text);

                komut.ExecuteNonQuery();
                database.Connection().Close();
                listele();
                temizle();
                MessageBox.Show("Personel başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata;" + JsonConvert.SerializeObject(ex), " Hatalı veri girişi yapıldı. Lütfen yeniden deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_Personeller  (PeronelID, Ad, Soyad, Gorev, TelefonNo, Email, Adres, CalismaSaatleri, Maas, Deleted) VALUES " +
                    "(@pPeronelID, @pAd, @pSoyad, @pGorev, @pTelefonNo, @pEmail, @pAdres, @pCalismaSaatleri, @pMaas, DEFAULT)", database.Connection());

                komut.Parameters.AddWithValue("@pPeronelID", textPersKimlik.Text);
                komut.Parameters.AddWithValue("@pAd", textAd.Text);
                komut.Parameters.AddWithValue("@pSoyad", textSoyad.Text);
                komut.Parameters.AddWithValue("@pGorev", textGorev.Text);
                komut.Parameters.AddWithValue("@pTelefonNo", maskedTel.Text);
                komut.Parameters.AddWithValue("@pEmail", textMail.Text);
                komut.Parameters.AddWithValue("@pAdres", richAdres.Text);
                komut.Parameters.AddWithValue("@pCalismaSaatleri",textCalismaSaatleri.Text);
                komut.Parameters.AddWithValue("@pMaas",Decimal.Parse(textMaas.Text));
                
                komut.ExecuteNonQuery();
                database.Connection().Close();
                listele();
                temizle();
                MessageBox.Show("Personel başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata;" + JsonConvert.SerializeObject(ex)," Hatalı veri girişi yapıldı. Lütfen yeniden deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
