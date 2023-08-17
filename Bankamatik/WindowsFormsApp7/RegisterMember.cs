using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class RegisterMember : Form
    {
        public RegisterMember()
        {
            InitializeComponent();
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            var entities = new BankEntities();

            var dialogResult = MessageBox.Show("Müşteriyi Kaydetmek İstiyor Musunuz?", "Kayıt",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                entities.Member.Add(new Member
                {
                    name = txtName.Text,
                    surname = txtSurname.Text,
                    password = txtPassword.Text,
                    phone_number = txtPhoneNumber.Text,
                    amount = Convert.ToDecimal(txtAmount.Text),
                    create_date = DateTime.Now,
                });
                if (txtPhoneNumber.Text.Length > 11)
                {
                    MessageBox.Show("Telefon numarası en fazla 11 haneli olmalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entities.SaveChanges();

                    MessageBox.Show("Kayıt işlemi başarılı");

                    Form2 sorgu = new Form2();

                    sorgu.Show();
                }
            }
        }
    }
}
