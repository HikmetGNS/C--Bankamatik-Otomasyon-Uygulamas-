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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form2 sorgu = new Form2();

            sorgu.Show();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            RegisterMember member = new RegisterMember();

            member.Show();
        }
    }
}
