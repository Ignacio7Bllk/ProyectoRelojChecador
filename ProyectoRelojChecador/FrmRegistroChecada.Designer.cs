namespace ProyectoRelojChecador
{
    partial class FrmRegistroChecada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewRegistroChecada = new System.Windows.Forms.DataGridView();
            this.txtboxFecha = new System.Windows.Forms.Label();
            this.textBoxfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxIdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroChecada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(285, 179);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 31);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewRegistroChecada
            // 
            this.dataGridViewRegistroChecada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistroChecada.Location = new System.Drawing.Point(14, 230);
            this.dataGridViewRegistroChecada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRegistroChecada.Name = "dataGridViewRegistroChecada";
            this.dataGridViewRegistroChecada.RowHeadersWidth = 62;
            this.dataGridViewRegistroChecada.RowTemplate.Height = 28;
            this.dataGridViewRegistroChecada.Size = new System.Drawing.Size(489, 185);
            this.dataGridViewRegistroChecada.TabIndex = 10;
            // 
            // txtboxFecha
            // 
            this.txtboxFecha.AutoSize = true;
            this.txtboxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFecha.Location = new System.Drawing.Point(95, 132);
            this.txtboxFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtboxFecha.Name = "txtboxFecha";
            this.txtboxFecha.Size = new System.Drawing.Size(93, 29);
            this.txtboxFecha.TabIndex = 9;
            this.txtboxFecha.Text = "FECHA";
            this.txtboxFecha.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxfecha
            // 
            this.textBoxfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfecha.Location = new System.Drawing.Point(213, 132);
            this.textBoxfecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxfecha.Multiline = true;
            this.textBoxfecha.Name = "textBoxfecha";
            this.textBoxfecha.Size = new System.Drawing.Size(290, 34);
            this.textBoxfecha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID EMPLEADO ";
            // 
            // txtboxIdEmpleado
            // 
            this.txtboxIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIdEmpleado.Location = new System.Drawing.Point(213, 82);
            this.txtboxIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxIdEmpleado.Multiline = true;
            this.txtboxIdEmpleado.Name = "txtboxIdEmpleado";
            this.txtboxIdEmpleado.Size = new System.Drawing.Size(290, 34);
            this.txtboxIdEmpleado.TabIndex = 6;
            this.txtboxIdEmpleado.TextChanged += new System.EventHandler(this.txtboxIdEmpleado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "REGISTRO DE CHECADAS ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmRegistroChecada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridViewRegistroChecada);
            this.Controls.Add(this.txtboxFecha);
            this.Controls.Add(this.textBoxfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxIdEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistroChecada";
            this.Text = "FrmRegistroChecada";
            this.Load += new System.EventHandler(this.FrmRegistroChecada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistroChecada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewRegistroChecada;
        private System.Windows.Forms.Label txtboxFecha;
        private System.Windows.Forms.TextBox textBoxfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxIdEmpleado;
        private System.Windows.Forms.Label label2;
    }
}