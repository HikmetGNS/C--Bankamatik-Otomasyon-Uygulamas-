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

namespace WindowsFormsApp7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Bank;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.bankDataSet.Member);
            label2.Text = Form2.idGonder;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set name=@isim, surname=@soyisim, phone_number=@telefon, password=@sifre where id=@id", baglanti);
            guncelle.Parameters.AddWithValue("isim", txtNewName.Text);
            guncelle.Parameters.AddWithValue("soyisim", txtNewSurname.Text);
            guncelle.Parameters.AddWithValue("telefon", txtNewPhoneNumber.Text);
            guncelle.Parameters.AddWithValue("sifre", txtNewPassword.Text);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            if (txtNewPhoneNumber.Text.Length < 11)
            {
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgileriniz Güncellendi");
            }
            else
            {
                MessageBox.Show("Telefon numarası en fazla 11 haneli olmalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            double cekilen = Convert.ToDouble(txtParaCek.Text);
            if (cekilen % 10 == 0)
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - @cekilen) where id = @id", baglanti);
                guncelle.Parameters.AddWithValue("cekilen", Convert.ToDouble(txtParaCek.Text));
                guncelle.Parameters.AddWithValue("id", label2.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Para çekme işleminiz başarıyla gerçekleşti");
            }
            else
            {
                MessageBox.Show("Çektiğiniz Tutar 10 ve Katları Olmalı");
            }
        }
        private void btn10Tl_Click(object sender, EventArgs e)
        {   
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 10) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para çekme işleminiz başarıyla gerçekleşti");
        }

        private void btn20Tl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 20) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para çekme işleminiz başarıyla gerçekleşti");
        }

        private void btn50Tl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 50) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para çekme işleminiz başarıyla gerçekleşti");
        }

        private void btn100Tl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 100) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para çekme işleminiz başarıyla gerçekleşti");
        }

        private void btn200Tl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 200) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para çekme işleminiz başarıyla gerçekleşti");
        }

        private void btn500Tl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 500) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para çekme işleminiz başarıyla gerçekleşti");
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Havale Yapmak İstiyor Musunuz?", "Havale",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                double havale = Convert.ToDouble(txtHavaleTutar.Text);
                if (havale > 0)
                {

                    baglanti.Open();
                    SqlCommand gonderen = new SqlCommand("Update Member Set amount = (amount - @havale) where id = @id", baglanti);
                    gonderen.Parameters.AddWithValue("havale", Convert.ToDouble(txtHavaleTutar.Text));
                    gonderen.Parameters.AddWithValue("id", label2.Text);
                    gonderen.ExecuteNonQuery();
                    SqlCommand alici = new SqlCommand("Update Member Set amount = (amount + @havale) where id = @id", baglanti);
                    alici.Parameters.AddWithValue("havale", Convert.ToDouble(txtHavaleTutar.Text));
                    alici.Parameters.AddWithValue("id", txtHavaleId.Text);
                    alici.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Havale işleminiz başarıyla gerçekleşti");
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir tutar giriniz");
                }
            }
            else
            {
                MessageBox.Show("Havale işlemi iptal edildi");
            }
        }
        private void btnFaturaOde_Click(object sender, EventArgs e)
        {
            Fatura ode = new Fatura();
            ode.Show();
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda bilgi = new Hakkinda();
            bilgi.Show();
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            double yatirilan = Convert.ToDouble(txtParaYatir.Text);
            if (yatirilan % 10 == 0)
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount + @yatirilan) where id = @id", baglanti);
                guncelle.Parameters.AddWithValue("yatirilan", Convert.ToDouble(txtParaYatir.Text));
                guncelle.Parameters.AddWithValue("id", label2.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Paranız Başarıyla Yatırıldı");
            }
            else
            {
                MessageBox.Show("Yatırdığınız Tutar 10 ve Katları Olmalı");
            }
        }

        private void btn10Yatir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount + 10) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paranız Başarıyla Yatırıldı");
        }

        private void btn20Yatir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount + 20) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paranız Başarıyla Yatırıldı");
        }

        private void btn50Yatir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount + 50) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paranız Başarıyla Yatırıldı");
        }

        private void btn100Yatir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount + 100) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paranız Başarıyla Yatırıldı");
        }

        private void btn200Yatir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount + 200) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paranız Başarıyla Yatırıldı");
        }

        private void btn500Yatir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount + 500) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label2.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Paranız Başarıyla Yatırıldı");
        }
    }
}

