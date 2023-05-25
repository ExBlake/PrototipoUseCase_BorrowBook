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
using System.Xml.Linq;

namespace BorrowBook
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Busca apartir del codigo, un articulo en la base de datos
                if (string.IsNullOrEmpty(txConsularCodigoLibro.Text) && string.IsNullOrEmpty(txCarnetCliente.Text))
                {
                    txMensaje.Text = ("INFORMACIÓN INCOMPLETA!");
                    //Buscar apartir del nombre, un articulo en la base de datos
                }
                else
                {
                    //Instrucción en comando
                    SqlConnection objConector = Clases.DB.conectar("BorrowBook");
                    string codigo = txConsularCodigoLibro.Text;
                   
                    string query = "Select * from Libro where CodigoLibro = " + codigo;
                    
                    SqlDataReader objTabla = Clases.DB.consulta(query, objConector);
                    

                    if (objTabla.Read())
                    {
                        txCodigoLibro1.Text = objTabla[0].ToString();
                        txTituloLibro.Text = objTabla[1].ToString();
                        


                    }
                    else
                    {
                        txMensaje.Text = ("¡EL CODIGO DEL LIBRO ES INCORRECTO O NO EXISTE!");
                        txCodigoLibro1.Text = "";
                        txTituloLibro.Text = "";
                        txConsularCodigoLibro.Focus();

                    }
                    objConector.Close();
                    objTabla.Close();
                    SqlConnection objConector1 = Clases.DB.conectar("BorrowBook");
                    string Carnet = txCarnetCliente.Text;
                    string query1 = "Select * from Cliente where Carnet = " + Carnet;
                    SqlDataReader objTabla1 = Clases.DB.consulta(query1, objConector1);

                    if (objTabla1.Read())
                    {
                        txCarnetCliente1.Text = objTabla1[0].ToString();
                        txNombreCliente.Text = objTabla1[1].ToString();
                        


                    }
                    else
                    {
                        txMensaje.Text = ("EL CLIENTE NO EXISTE");
                        txCarnetCliente1.Text = "";
                        txNombreCliente.Text = "";
                        txCarnetCliente.Focus();

                    }

                    

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show("Error en la conexión" + err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Insertar los datos de la factura a la base de datos.
            string codigo = txCodigoLibro1.Text;
            string titulolibro = txTituloLibro.Text;
            string carnet = txCarnetCliente1.Text;
            string nombre = txNombreCliente.Text;
            string fechaprestamo = txFechaPres.Text;
            string fechaentrega = txFechaEnt.Text;
            

            try
            {
                if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(titulolibro) ||
               string.IsNullOrEmpty(carnet) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(fechaprestamo) || string.IsNullOrEmpty(fechaentrega))
                {

                    txMensaje.Text = ("INFORMACION INCOMPLETA");
                }
                else
                {
                    //Comando para insertar datos a la tabla facturacion en la base de datos.
                    SqlConnection objConector = DB.conectar("BorrowBook");
                    string consultaSql = "insert into Prestamos values (" + codigo + ", " + carnet + ",'" + titulolibro +
                        "', '" + nombre + "', '" + fechaprestamo + "', '" + fechaentrega + "')";
                    int cont = DB.operar(consultaSql, objConector);

                    if (cont > 0)
                    {
                        txCodigoLibro1.Text = "";
                        txTituloLibro.Text = "";
                        txCarnetCliente1.Text = "";
                        txNombreCliente.Text = "";
                        txFechaPres.Text = "";
                        txFechaEnt.Text = "";
                        txMensaje.Text = "";
                    }
                    else
                    {
                        txMensaje.Text = ("¡Error!, Prestamo no registrado");
                        txMensaje.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            
        }
    }
}
