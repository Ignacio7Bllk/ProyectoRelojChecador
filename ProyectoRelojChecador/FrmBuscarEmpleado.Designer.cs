namespace ProyectoRelojChecador
{
    partial class FrmBuscarEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBuscarEmp = new System.Windows.Forms.DataGridView();
            this.txtboxBuscarDato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(340, 149);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(133, 39);
            this.btnBuscarEmpleado.TabIndex = 7;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Empleado:";
            // 
            // dataGridViewBuscarEmp
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuscarEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewBuscarEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBuscarEmp.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewBuscarEmp.Location = new System.Drawing.Point(25, 217);
            this.dataGridViewBuscarEmp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridViewBuscarEmp.Name = "dataGridViewBuscarEmp";
            this.dataGridViewBuscarEmp.RowHeadersWidth = 62;
            this.dataGridViewBuscarEmp.RowTemplate.Height = 28;
            this.dataGridViewBuscarEmp.Size = new System.Drawing.Size(602, 157);
            this.dataGridViewBuscarEmp.TabIndex = 5;
            // 
            // txtboxBuscarDato
            // 
            this.txtboxBuscarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBuscarDato.Location = new System.Drawing.Point(188, 93);
            this.txtboxBuscarDato.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtboxBuscarDato.Multiline = true;
            this.txtboxBuscarDato.Name = "txtboxBuscarDato";
            this.txtboxBuscarDato.Size = new System.Drawing.Size(439, 37);
            this.txtboxBuscarDato.TabIndex = 4;
            this.txtboxBuscarDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "BUSCAR EMPLEADO";
            // 
            // FrmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBuscarEmp);
            this.Controls.Add(this.txtboxBuscarDato);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBuscarEmpleado";
            this.Text = "FrmBuscarEmpleado";
            this.Load += new System.EventHandler(this.FrmBuscarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBuscarEmp;
        private System.Windows.Forms.TextBox txtboxBuscarDato;
        private System.Windows.Forms.Label label2;
    }
}