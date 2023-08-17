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
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Bank;Integrated Security=True");
        private void Fatura_Load(object sender, EventArgs e)
        {
            label10.Text = Form2.idGonder;
        }
        private void btnElektrikOde_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 458) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label10.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            label8.Text = "Ödendi";
            MessageBox.Show("Elektrik faturanız ödendi");
        }

        private void btnSuOde_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 216) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label10.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            label7.Text = "Ödendi";
            MessageBox.Show("Su faturanız ödendi");
        }

        private void btnDogalgazOde_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 342) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label10.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            label6.Text = "Ödendi";
            MessageBox.Show("Doğalgaz faturanız ödendi");
        }

        private void btnTelefonOde_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Member Set amount = (amount - 150) where id = @id", baglanti);
            guncelle.Parameters.AddWithValue("id", label10.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            label5.Text = "Ödendi";
            MessageBox.Show("Telefon faturanız ödendi");
        }
    }
}
