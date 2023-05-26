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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            //Registra/Ingresa un nuevo Usuario a la base de datos.
            string usuario = txtUserReg.Text;
            string contrasena = txtPassReg.Text;
            
            string correo = txCorreoReg.Text;
            

            try
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena) ||
                string.IsNullOrEmpty(correo) )
                {
                    MessageBox.Show("INFORMACION INCOMPLETA");
                }
                else
                {
                    //Instrucción comando para insertar un nuevo usuario a la tabla Usuarios de la base de datos.
                    SqlConnection objConector = DB.conectar("BorrowBook");
                    string consultaSql = "insert into Usuarios values ('" + usuario + "', '" + contrasena + "','" + correo + "')";
                    int cont = DB.operar(consultaSql, objConector);

                    if (cont > 0)
                    {
                        MessageBox.Show("El usuario se registro con exito!");
                    }
                    else
                    {
                        MessageBox.Show("¡Error!, Usuario no registrado");
                    }

                    //Cierra la ventana de RegistroUsuarios y abre nuevamente la ventana de Login.
                    this.Close();
                    Login objLogin = new Login();
                    objLogin.Show();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
