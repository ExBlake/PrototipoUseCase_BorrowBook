namespace BorrowBook
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txCarnetCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txConsularCodigoLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.txMensaje = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txTituloLibro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txCodigoLibro1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txCarnetCliente1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txNombreCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txFechaEnt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txFechaPres = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txFechaPrestamo = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txCarnetCliente
            // 
            this.txCarnetCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txCarnetCliente.DefaultText = "";
            this.txCarnetCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCarnetCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCarnetCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCarnetCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCarnetCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCarnetCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txCarnetCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCarnetCliente.Location = new System.Drawing.Point(243, 44);
            this.txCarnetCliente.Name = "txCarnetCliente";
            this.txCarnetCliente.PasswordChar = '\0';
            this.txCarnetCliente.PlaceholderText = "";
            this.txCarnetCliente.SelectedText = "";
            this.txCarnetCliente.Size = new System.Drawing.Size(200, 36);
            this.txCarnetCliente.TabIndex = 0;
            // 
            // txConsularCodigoLibro
            // 
            this.txConsularCodigoLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txConsularCodigoLibro.DefaultText = "";
            this.txConsularCodigoLibro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txConsularCodigoLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txConsularCodigoLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txConsularCodigoLibro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txConsularCodigoLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txConsularCodigoLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txConsularCodigoLibro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txConsularCodigoLibro.Location = new System.Drawing.Point(243, 99);
            this.txConsularCodigoLibro.Name = "txConsularCodigoLibro";
            this.txConsularCodigoLibro.PasswordChar = '\0';
            this.txConsularCodigoLibro.PlaceholderText = "";
            this.txConsularCodigoLibro.SelectedText = "";
            this.txConsularCodigoLibro.Size = new System.Drawing.Size(200, 36);
            this.txConsularCodigoLibro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar Carnet del Cliente: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar Codigo del Libro: ";
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(473, 44);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(100, 98);
            this.Consultar.TabIndex = 4;
            this.Consultar.Text = "Buscar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // txMensaje
            // 
            this.txMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txMensaje.DefaultText = "";
            this.txMensaje.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txMensaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txMensaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txMensaje.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txMensaje.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txMensaje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txMensaje.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txMensaje.Location = new System.Drawing.Point(115, 316);
            this.txMensaje.Name = "txMensaje";
            this.txMensaje.PasswordChar = '\0';
            this.txMensaje.PlaceholderText = "";
            this.txMensaje.SelectedText = "";
            this.txMensaje.Size = new System.Drawing.Size(403, 66);
            this.txMensaje.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mensaje: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(537, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txTituloLibro
            // 
            this.txTituloLibro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txTituloLibro.DefaultText = "";
            this.txTituloLibro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txTituloLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txTituloLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTituloLibro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTituloLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTituloLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txTituloLibro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTituloLibro.Location = new System.Drawing.Point(133, 182);
            this.txTituloLibro.Name = "txTituloLibro";
            this.txTituloLibro.PasswordChar = '\0';
            this.txTituloLibro.PlaceholderText = "";
            this.txTituloLibro.SelectedText = "";
            this.txTituloLibro.Size = new System.Drawing.Size(123, 36);
            this.txTituloLibro.TabIndex = 11;
            // 
            // txCodigoLibro1
            // 
            this.txCodigoLibro1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txCodigoLibro1.DefaultText = "";
            this.txCodigoLibro1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCodigoLibro1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCodigoLibro1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCodigoLibro1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCodigoLibro1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCodigoLibro1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txCodigoLibro1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCodigoLibro1.Location = new System.Drawing.Point(28, 182);
            this.txCodigoLibro1.Name = "txCodigoLibro1";
            this.txCodigoLibro1.PasswordChar = '\0';
            this.txCodigoLibro1.PlaceholderText = "";
            this.txCodigoLibro1.SelectedText = "";
            this.txCodigoLibro1.Size = new System.Drawing.Size(99, 36);
            this.txCodigoLibro1.TabIndex = 12;
            // 
            // txCarnetCliente1
            // 
            this.txCarnetCliente1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txCarnetCliente1.DefaultText = "";
            this.txCarnetCliente1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCarnetCliente1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCarnetCliente1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCarnetCliente1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCarnetCliente1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCarnetCliente1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txCarnetCliente1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCarnetCliente1.Location = new System.Drawing.Point(262, 182);
            this.txCarnetCliente1.Name = "txCarnetCliente1";
            this.txCarnetCliente1.PasswordChar = '\0';
            this.txCarnetCliente1.PlaceholderText = "";
            this.txCarnetCliente1.SelectedText = "";
            this.txCarnetCliente1.Size = new System.Drawing.Size(113, 36);
            this.txCarnetCliente1.TabIndex = 13;
            // 
            // txNombreCliente
            // 
            this.txNombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txNombreCliente.DefaultText = "";
            this.txNombreCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txNombreCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txNombreCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNombreCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNombreCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txNombreCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNombreCliente.Location = new System.Drawing.Point(381, 182);
            this.txNombreCliente.Name = "txNombreCliente";
            this.txNombreCliente.PasswordChar = '\0';
            this.txNombreCliente.PlaceholderText = "";
            this.txNombreCliente.SelectedText = "";
            this.txNombreCliente.Size = new System.Drawing.Size(121, 36);
            this.txNombreCliente.TabIndex = 14;
            // 
            // txFechaEnt
            // 
            this.txFechaEnt.Checked = true;
            this.txFechaEnt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txFechaEnt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txFechaEnt.Location = new System.Drawing.Point(600, 67);
            this.txFechaEnt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txFechaEnt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txFechaEnt.Name = "txFechaEnt";
            this.txFechaEnt.Size = new System.Drawing.Size(129, 36);
            this.txFechaEnt.TabIndex = 15;
            this.txFechaEnt.Value = new System.DateTime(2023, 5, 25, 13, 4, 7, 103);
            // 
            // txFechaPres
            // 
            this.txFechaPres.Animated = true;
            this.txFechaPres.AutoRoundedCorners = true;
            this.txFechaPres.BackColor = System.Drawing.Color.Transparent;
            this.txFechaPres.BorderRadius = 17;
            this.txFechaPres.Checked = true;
            this.txFechaPres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txFechaPres.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txFechaPres.IndicateFocus = true;
            this.txFechaPres.Location = new System.Drawing.Point(588, 25);
            this.txFechaPres.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txFechaPres.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txFechaPres.Name = "txFechaPres";
            this.txFechaPres.Size = new System.Drawing.Size(200, 36);
            this.txFechaPres.TabIndex = 17;
            this.txFechaPres.UseTransparentBackground = true;
            this.txFechaPres.Value = new System.DateTime(2023, 5, 25, 13, 8, 24, 762);
            // 
            // txFechaPrestamo
            // 
            this.txFechaPrestamo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txFechaPrestamo.DefaultText = "";
            this.txFechaPrestamo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txFechaPrestamo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txFechaPrestamo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txFechaPrestamo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txFechaPrestamo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txFechaPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txFechaPrestamo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txFechaPrestamo.Location = new System.Drawing.Point(508, 182);
            this.txFechaPrestamo.Name = "txFechaPrestamo";
            this.txFechaPrestamo.PasswordChar = '\0';
            this.txFechaPrestamo.PlaceholderText = "";
            this.txFechaPrestamo.SelectedText = "";
            this.txFechaPrestamo.Size = new System.Drawing.Size(121, 36);
            this.txFechaPrestamo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 522);
            this.Controls.Add(this.txFechaPrestamo);
            this.Controls.Add(this.txFechaPres);
            this.Controls.Add(this.txFechaEnt);
            this.Controls.Add(this.txNombreCliente);
            this.Controls.Add(this.txCarnetCliente1);
            this.Controls.Add(this.txCodigoLibro1);
            this.Controls.Add(this.txTituloLibro);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txMensaje);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txConsularCodigoLibro);
            this.Controls.Add(this.txCarnetCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txCarnetCliente;
        private Guna.UI2.WinForms.Guna2TextBox txConsularCodigoLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Consultar;
        private Guna.UI2.WinForms.Guna2TextBox txMensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2TextBox txTituloLibro;
        private Guna.UI2.WinForms.Guna2TextBox txCodigoLibro1;
        private Guna.UI2.WinForms.Guna2TextBox txCarnetCliente1;
        private Guna.UI2.WinForms.Guna2TextBox txNombreCliente;
        private Guna.UI2.WinForms.Guna2DateTimePicker txFechaEnt;
        private Guna.UI2.WinForms.Guna2DateTimePicker txFechaPres;
        private Guna.UI2.WinForms.Guna2TextBox txFechaPrestamo;
        private Guna.UI2.WinForms.Guna2TextBox txFechaEntrega;
    }
}

