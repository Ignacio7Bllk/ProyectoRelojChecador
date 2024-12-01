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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(222, 152);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(394, 39);
            this.btnEliminarEmpleado.TabIndex = 11;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Empleado:";
            // 
            // dataGridViewEliminarEmp
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEliminarEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEliminarEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEliminarEmp.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEliminarEmp.Location = new System.Drawing.Point(14, 223);
            this.dataGridViewEliminarEmp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridViewEliminarEmp.Name = "dataGridViewEliminarEmp";
            this.dataGridViewEliminarEmp.RowHeadersWidth = 62;
            this.dataGridViewEliminarEmp.RowTemplate.Height = 28;
            this.dataGridViewEliminarEmp.Size = new System.Drawing.Size(602, 151);
            this.dataGridViewEliminarEmp.TabIndex = 9;
            // 
            // txtboxEliminarDato
            // 
            this.txtboxEliminarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEliminarDato.Location = new System.Drawing.Point(222, 96);
            this.txtboxEliminarDato.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtboxEliminarDato.Multiline = true;
            this.txtboxEliminarDato.Name = "txtboxEliminarDato";
            this.txtboxEliminarDato.Size = new System.Drawing.Size(394, 37);
            this.txtboxEliminarDato.TabIndex = 8;
            this.txtboxEliminarDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "ELIMINAR EMPLEADO";
            // 
            // FrmEliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEliminarEmp);
            this.Controls.Add(this.txtboxEliminarDato);
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