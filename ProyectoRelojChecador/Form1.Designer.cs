namespace ProyectoRelojChecador
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
            this.components = new System.ComponentModel.Container();
            this.btnRegistroChecadas = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.etiquetaFecha = new System.Windows.Forms.Label();
            this.etiquetaIntroducir = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.TimerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.etiquetaHora = new System.Windows.Forms.Label();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroChecadas
            // 
            this.btnRegistroChecadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroChecadas.ForeColor = System.Drawing.Color.Purple;
            this.btnRegistroChecadas.Location = new System.Drawing.Point(17, 380);
            this.btnRegistroChecadas.Name = "btnRegistroChecadas";
            this.btnRegistroChecadas.Size = new System.Drawing.Size(233, 70);
            this.btnRegistroChecadas.TabIndex = 35;
            this.btnRegistroChecadas.Text = "Registro Checadas";
            this.btnRegistroChecadas.UseVisualStyleBackColor = true;
            this.btnRegistroChecadas.Click += new System.EventHandler(this.btnRegistroChecadas_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscarEmpleado.ForeColor = System.Drawing.Color.Purple;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(26, 305);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(109, 69);
            this.btnBuscarEmpleado.TabIndex = 34;
            this.btnBuscarEmpleado.Text = "Buscar Empleado";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.Purple;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(26, 190);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(109, 100);
            this.btnAgregarEmpleado.TabIndex = 33;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // etiquetaFecha
            // 
            this.etiquetaFecha.AutoSize = true;
            this.etiquetaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.etiquetaFecha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.etiquetaFecha.Location = new System.Drawing.Point(36, 117);
            this.etiquetaFecha.Name = "etiquetaFecha";
            this.etiquetaFecha.Size = new System.Drawing.Size(159, 58);
            this.etiquetaFecha.TabIndex = 32;
            this.etiquetaFecha.Text = "label1";
            // 
            // etiquetaIntroducir
            // 
            this.etiquetaIntroducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaIntroducir.Location = new System.Drawing.Point(257, 137);
            this.etiquetaIntroducir.Name = "etiquetaIntroducir";
            this.etiquetaIntroducir.Size = new System.Drawing.Size(270, 38);
            this.etiquetaIntroducir.TabIndex = 30;
            this.etiquetaIntroducir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(444, 392);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 59);
            this.btnOk.TabIndex = 29;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(351, 391);
            this.btnCero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(83, 59);
            this.btnCero.TabIndex = 28;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(258, 391);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(83, 59);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "⌫";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnNueve.Location = new System.Drawing.Point(444, 324);
            this.btnNueve.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(83, 59);
            this.btnNueve.TabIndex = 26;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOcho.Location = new System.Drawing.Point(351, 324);
            this.btnOcho.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(83, 59);
            this.btnOcho.TabIndex = 25;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSiete.Location = new System.Drawing.Point(258, 324);
            this.btnSiete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(83, 59);
            this.btnSiete.TabIndex = 24;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSeis.Location = new System.Drawing.Point(444, 257);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(83, 59);
            this.btnSeis.TabIndex = 23;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCinco.Location = new System.Drawing.Point(351, 257);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(83, 59);
            this.btnCinco.TabIndex = 22;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCuatro.Location = new System.Drawing.Point(258, 257);
            this.btnCuatro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(83, 59);
            this.btnCuatro.TabIndex = 21;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTres.Location = new System.Drawing.Point(444, 190);
            this.btnTres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(83, 59);
            this.btnTres.TabIndex = 20;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDos.Location = new System.Drawing.Point(351, 190);
            this.btnDos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(83, 59);
            this.btnDos.TabIndex = 19;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnUno.Location = new System.Drawing.Point(258, 190);
            this.btnUno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(83, 59);
            this.btnUno.TabIndex = 18;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // TimerHoraFecha
            // 
            this.TimerHoraFecha.Enabled = true;
            this.TimerHoraFecha.Tick += new System.EventHandler(this.TimerHoraFecha_Tick);
            // 
            // etiquetaHora
            // 
            this.etiquetaHora.AutoSize = true;
            this.etiquetaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaHora.ForeColor = System.Drawing.Color.Purple;
            this.etiquetaHora.Location = new System.Drawing.Point(30, 21);
            this.etiquetaHora.Name = "etiquetaHora";
            this.etiquetaHora.Size = new System.Drawing.Size(249, 91);
            this.etiquetaHora.TabIndex = 36;
            this.etiquetaHora.Text = "label1";
            this.etiquetaHora.Click += new System.EventHandler(this.etiquetaHora_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModificarEmpleado.ForeColor = System.Drawing.Color.Purple;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(141, 305);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(109, 69);
            this.btnModificarEmpleado.TabIndex = 37;
            this.btnModificarEmpleado.Text = "Modificar Empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.Purple;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(141, 190);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(109, 100);
            this.btnEliminarEmpleado.TabIndex = 38;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(546, 460);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.etiquetaHora);
            this.Controls.Add(this.btnRegistroChecadas);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.etiquetaFecha);
            this.Controls.Add(this.etiquetaIntroducir);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "RELOJ CHECADOR ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistroChecadas;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Label etiquetaFecha;
        private System.Windows.Forms.Label etiquetaIntroducir;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Timer TimerHoraFecha;
        private System.Windows.Forms.Label etiquetaHora;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
    }
}

