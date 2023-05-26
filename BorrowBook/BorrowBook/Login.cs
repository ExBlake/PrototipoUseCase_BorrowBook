using BorrowBook.Clases;
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

namespace BorrowBook
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Verifica si el TextBox esta vacio o lleno.
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("INFORMACION INCOMPLETA");
            }
            else
            {
                //Abre la conexión y verifica el usuario y contraseña de la base de datos.
                SqlConnection objConector = DB.conectar("BorrowBook");
                string usuario = txtUser.Text;
                string query =
                    "Select * from Usuarios where Usuario = '" + usuario + "'";
                SqlDataReader objTabla = DB.consulta(query, objConector);

                if (objTabla.Read())
                {
                    string clave = txtPass.Text;
                    string claveDb = objTabla[1].ToString();
                    
                    if (clave == claveDb)
                    {
                        MenuPrincipal objmenu = new MenuPrincipal();
                        objmenu.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("CONTRASEÑA INCORRECTA");
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("EL USUARIO NO ESTA REGISTRADO EN EL SISTEMA");
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new RecuperarContraseña();
            recoverPassword.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Invoca el formulario de Registro de usuarios.
            RegistroUsuarios objRegUser = new RegistroUsuarios();
            objRegUser.Show();
            this.Hide();
        }
    }
}
