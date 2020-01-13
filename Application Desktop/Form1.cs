using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Connecter_Click(object sender, EventArgs e)
        {
            string A = "admin";
            string B = "admin";
            if(Txt_Auth_Login.Text == A && Txt_Auth_Password.Text == B && Txt_Auth_Login.Text !="" && Txt_Auth_Password.Text != "")
            {
                MessageBox.Show("YOOOOO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login - MDP Erronee / Remplir tous les Champs svp", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
