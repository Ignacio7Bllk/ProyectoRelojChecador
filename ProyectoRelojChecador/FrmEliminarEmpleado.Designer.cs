namespace ProyectoRelojChecador
{
    partial class FrmEliminarEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEliminarEmp = new System.Windows.Forms.DataGridView();
            this.txtboxEliminarDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(378, 60);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(115, 31);
            this.btnEliminarEmpleado.TabIndex = 11;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Empleado:";
            // 
            // dataGridViewEliminarEmp
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEliminarEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEliminarEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEliminarEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEliminarEmp.Location = new System.Drawing.Point(12, 102);
            this.dataGridViewEliminarEmp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewEliminarEmp.Name = "dataGridViewEliminarEmp";
            this.dataGridViewEliminarEmp.RowHeadersWidth = 62;
            this.dataGridViewEliminarEmp.RowTemplate.Height = 28;
            this.dataGridViewEliminarEmp.Size = new System.Drawing.Size(481, 121);
            this.dataGridViewEliminarEmp.TabIndex = 9;
            // 
            // txtboxEliminarDato
            // 
            this.txtboxEliminarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEliminarDato.Location = new System.Drawing.Point(149, 53);
            this.txtboxEliminarDato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxEliminarDato.Multiline = true;
            this.txtboxEliminarDato.Name = "txtboxEliminarDato";
            this.txtboxEliminarDato.Size = new System.Drawing.Size(216, 43);
            this.txtboxEliminarDato.TabIndex = 8;
            this.txtboxEliminarDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "ELIMINAR EMPLEADO";
            // 
            // FrmEliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(500, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEliminarEmp);
            this.Controls.Add(this.txtboxEliminarDato);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEliminarEmpleado";
            this.Text = "FrmEliminarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminarEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEliminarEmp;
        private System.Windows.Forms.TextBox txtboxEliminarDato;
        private System.Windows.Forms.Label label2;
    }
}