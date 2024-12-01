namespace ProyectoRelojChecador
{
    partial class FrmAgregarEmpleado
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
            this.dataGridViewAgregarEmp = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLastNameM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLastNameP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOcupation = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgregarEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAgregarEmp
            // 
            this.dataGridViewAgregarEmp.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridViewAgregarEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgregarEmp.Location = new System.Drawing.Point(425, 33);
            this.dataGridViewAgregarEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAgregarEmp.Name = "dataGridViewAgregarEmp";
            this.dataGridViewAgregarEmp.RowHeadersWidth = 62;
            this.dataGridViewAgregarEmp.RowTemplate.Height = 28;
            this.dataGridViewAgregarEmp.Size = new System.Drawing.Size(546, 295);
            this.dataGridViewAgregarEmp.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LavenderBlush;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(26, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "INFORMACION DEL EMPLEADO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sexo:";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(176, 182);
            this.txtBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAge.Multiline = true;
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(202, 25);
            this.txtBoxAge.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Edad:";
            // 
            // txtBoxLastNameM
            // 
            this.txtBoxLastNameM.Location = new System.Drawing.Point(176, 144);
            this.txtBoxLastNameM.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLastNameM.Multiline = true;
            this.txtBoxLastNameM.Name = "txtBoxLastNameM";
            this.txtBoxLastNameM.Size = new System.Drawing.Size(202, 25);
            this.txtBoxLastNameM.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido Materno:";
            // 
            // txtBoxLastNameP
            // 
            this.txtBoxLastNameP.Location = new System.Drawing.Point(176, 110);
            this.txtBoxLastNameP.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLastNameP.Multiline = true;
            this.txtBoxLastNameP.Name = "txtBoxLastNameP";
            this.txtBoxLastNameP.Size = new System.Drawing.Size(202, 25);
            this.txtBoxLastNameP.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido Paterno:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(176, 73);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(202, 25);
            this.txtBoxName.TabIndex = 17;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // comboBoxOcupation
            // 
            this.comboBoxOcupation.FormattingEnabled = true;
            this.comboBoxOcupation.Items.AddRange(new object[] {
            "Recursos Humanos",
            "Tecnología",
            "Ventas"});
            this.comboBoxOcupation.Location = new System.Drawing.Point(176, 262);
            this.comboBoxOcupation.Name = "comboBoxOcupation";
            this.comboBoxOcupation.Size = new System.Drawing.Size(202, 24);
            this.comboBoxOcupation.TabIndex = 32;
            this.comboBoxOcupation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOcupation_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Violet;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(205, 362);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 48);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.buttonAgar_Click);
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "Turno Matutino",
            "Turno Vespertino"});
            this.comboBoxTurno.Location = new System.Drawing.Point(176, 304);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(202, 24);
            this.comboBoxTurno.TabIndex = 34;
            this.comboBoxTurno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Turno:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxSex.Location = new System.Drawing.Point(176, 219);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(202, 24);
            this.comboBoxSex.TabIndex = 36;
            // 
            // FrmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1022, 429);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comboBoxOcupation);
            this.Controls.Add(this.dataGridViewAgregarEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxLastNameM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxLastNameP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAgregarEmpleado";
            this.Text = "FrmAgregarEmpleado";
            this.Load += new System.EventHandler(this.FrmAgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgregarEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAgregarEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLastNameM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLastNameP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOcupation;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSex;
    }
}