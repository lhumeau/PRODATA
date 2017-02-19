using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProDATA
{

    public partial class frmLogin : Form
    {



        public frmLogin()
        {
            InitializeComponent();
        }

        ProdataEntities ef = new ProdataEntities();

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            foreach (var user in ef.logins)
            {
                if (user.user.Replace(" ", " ") == Txtbuser.Text && user.password.Replace(" ", " ") == Txtbpassword.Text)
                {
                  
                    FrmPrincipal frmprin = new FrmPrincipal();
                    frmprin.Show();
                    this.Hide();

                    return;
                }else
                {
                    MessageBox.Show("Usuario o Contraseña no validos.");

                }


            }




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }









    }
}



