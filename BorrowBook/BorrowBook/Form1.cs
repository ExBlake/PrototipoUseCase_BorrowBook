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
                        var fecha = DateTime.Now.ToString("dd/MM/yyyy");
                        txCarnetCliente1.Text = objTabla1[0].ToString();
                        txNombreCliente.Text = objTabla1[1].ToString();
                        txFechaPres.Text = fecha;
                        var fecha2 = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
                        txFechaEntr.Text = fecha2;
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
            
            var fecha = DateTime.Now.ToString("dd/MM/yyyy");
           
            
            string codigo = txCodigoLibro1.Text;
            string titulolibro = txTituloLibro.Text;
            string carnet = txCarnetCliente1.Text;
            string nombre = txNombreCliente.Text;
            string fechaprestamo = txFechaPres.Text;
            string fechaentrega = txFechaEntr.Text;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(titulolibro) ||
                              string.IsNullOrEmpty(carnet) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(fechaprestamo) || string.IsNullOrEmpty(fechaentrega))
            {

                txMensaje.Text = ("INFORMACION INCOMPLETA");
            }
            else
            {
                SqlConnection objConector1 = DB.conectar("BorrowBook");
                string carnet1 = txCarnetCliente1.Text;
                string query = "Select * from Moroso where CarnetCliente = '" + carnet1 + "'";
                SqlDataReader objTabla1 = DB.consulta(query, objConector1);

                if (objTabla1.Read())
                {
                    txMensaje.Text = "NO SE PUEDE REALIZAR EL PRESTAMO, EL CLIENTE ESTA MOROSO";
                }
                else
                {
                    objConector1.Close();
                    objTabla1.Close();
                    SqlConnection objConector2 = DB.conectar("BorrowBook");
                    string codigo2 = txCodigoLibro1.Text;
                    string query1 = "Select * from Reserva where CodigoLibro = '" + codigo2 + "'";
                    SqlDataReader objTabla2 = DB.consulta(query1, objConector2);

                    if (objTabla2.Read())
                    {
                        txMensaje.Text = "NO SE PUEDE REALIZAR EL PRESTAMO, EL LIBRO ESTA RESERVADO";
                    }
                    else
                    {
                        objConector2.Close();
                        objTabla2.Close();
                        SqlConnection objConector3 = DB.conectar("BorrowBook");
                        string libro = txConsularCodigoLibro.Text;
                        string query2 = "Select * from Prestamos where CodigoLibro = " + libro + "";
                        SqlDataReader objTabla3 = DB.consulta(query2, objConector3);
                        if (objTabla3.Read())
                        {
                            txMensaje.Text = "NO SE PUEDE REALIZAR EL PRESTAMO, EL LIBRO YA FUE PRESTADO";
                        }
                        else
                        {
                            objConector3.Close();
                            objTabla3.Close();

                            SqlConnection objConector4 = DB.conectar("BorrowBook");

                            string query3 = "Select * from Moroso where CodigoLibro = " + carnet + "and TipoCliente = 'DOCENTE'";
                            SqlDataReader objTabla4 = DB.consulta(query3, objConector4);
                            if (objTabla4.Read())
                            {
                                txMensaje.Text = "RECORDAR AL DOCENTE ENTREGAR LOS LIBROS EN LA FECHA ESTABLECIDA, PRESTAMO REGISTRADO EXITOSAMENTE";
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
                                            txFechaEntr.Text = "";

                                            txMensaje.Text = "SE REGISTRO EL PRESTAMO EXITOSAMENTE";
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
                            else
                            {
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
                                            txFechaEntr.Text = "";

                                            txMensaje.Text = "SE REGISTRO EL PRESTAMO EXITOSAMENTE";
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
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txMensaje.Text = "";
            txCarnetCliente.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txCarnetCliente.Text = "";
            txNombreCliente.Text = "";
            txCodigoLibro1.Text = "";
            txTituloLibro.Text = "";
            txCarnetCliente1.Text = "";
            txNombreCliente.Text = "";
            txConsularCodigoLibro.Text = "";
            txFechaPres.Text = "";
            txFechaEntr.Text = "";
            txMensaje.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
