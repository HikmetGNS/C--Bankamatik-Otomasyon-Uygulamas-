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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }
        public static string idGonder;
        private void button1_Click(object sender, EventArgs e)
        {
            idGonder = txtIdCheck.Text;
            string phone_number = txtPhoneNumberCheck.Text;
            string password = txtPasswordCheck.Text;
            con = new SqlConnection("Data Source=.;Initial Catalog=Bank;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Member where phone_number='" + txtPhoneNumberCheck.Text + "' AND password='" + txtPasswordCheck.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form4 main = new Form4();
                main.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }
    }
}
