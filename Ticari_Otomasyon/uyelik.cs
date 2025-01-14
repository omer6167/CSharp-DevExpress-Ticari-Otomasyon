using DevExpress.XtraEditors;
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
    public partial class uyelik : Form
    {
        public uyelik()
        {
            InitializeComponent();
        }
        Database database = new Database();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO TBL_Uyelikler (MusteriID, PaketID, UyelikBaslangicTarihi, UyelikBitisTarihi, Aktif, Deleted) " +
                                       "VALUES (@pMusteriID, @pPaketID, @pUyelikBaslangicTarihi, @pUyelikBitisTarihi, DEFAULT, DEFAULT)", database.Connection()))
            {

                var secilenMusteri= cmbMusteri.SelectedItem as ComboBoxItem;
                var secilenPaket = cmbMusteri.SelectedItem as ComboBoxItem;

                cmd.Parameters.AddWithValue("@pMusteriID", secilenMusteri.Value);
                cmd.Parameters.AddWithValue("@pPaketID", secilenPaket.Value);
                cmd.Parameters.AddWithValue("@pUyelikBaslangicTarihi", DateTime.Parse(dtBaslangic.SelectedText));
                cmd.Parameters.AddWithValue("@pUyelikBitisTarihi", DateTime.Parse(dtBitis.SelectedText));

                cmd.ExecuteNonQuery();

                listele();
                temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Üyeliği silmek istiyor musun ?", "Önemli", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE TBL_Uyelikler SET Deleted = 1 WHERE ID = @pID", database.Connection()))
                {
                    cmd.Parameters.AddWithValue("@pID", textId.Text);

                    cmd.ExecuteNonQuery();
                }



                listele();
                temizle();
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE TBL_Uyelikler SET PaketID = @pPaketID, UyelikBitisTarihi = @pUyelikBitisTarihi, Aktif = @pAktif " +
                                       "WHERE ID = @pID", database.Connection()))
            {
                cmd.Parameters.AddWithValue("@pMusteriID", cmbMusteri.SelectedItem);
                cmd.Parameters.AddWithValue("@pPaketID", cmbPaket.SelectedItem);
                cmd.Parameters.AddWithValue("@pUyelikBitisTarihi",dtBitis.SelectedText);
                

                cmd.ExecuteNonQuery();
            }


            listele();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void uyelik_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            MusteriDoldur();
            PaketDoldur();

            //Grid Doldur

            DataTable dataTable = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * FROM TBL_Uyelikler", database.Connection());
            dr.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        void PaketDoldur()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT ID ,Ad  FROM TBL_URUN_PAKETLERI  where Deleted =0", database.Connection());
            dr.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                var item = new ComboBoxItem()
                {
                    Text = row["Ad"].ToString(),  // Görünen metin
                    Value = row["ID"]                  // Seçilen değer
                };

                cmbPaket.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ComboBoxItem(item));
            }
            cmbPaket.SelectedIndex = -1;


        }
        void MusteriDoldur()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT ID ,Ad +' '+Soyad as AdSoyad FROM TBL_Musteriler where Deleted = 0 and Statu =1", database.Connection());
            dr.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                var item = new ComboBoxItem()
                {
                    Text = row["AdSoyad"].ToString(),  // Görünen metin
                    Value = row["ID"]                  // Seçilen değer
                };

                cmbMusteri.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ComboBoxItem(item));

            }
            cmbMusteri.SelectedIndex = -1;
        }
        void temizle()
        {
            cmbMusteri.Properties.Items.Clear();
            cmbPaket.Properties.Items.Clear();
        }
        public class ComboBoxItem
{
    public string Text { get; set; }
    public object Value { get; set; }

    public override string ToString()
    {
        return Text; // Görünen metni Text yapıyoruz
    }
}

    }
}
