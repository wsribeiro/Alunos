using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Btn_login_Click(object sender, EventArgs e)
        {
            if((txt_user.Text == "admin") && (txt_senha.Text == "admin"))
            {
                Close();     
            }
            else
            {
                MessageBox.Show("Você não é um administrador do sistema! \nOperação não permitida!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lbl_senha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entre em contato com o adminisrador!");
        }
    }
}
