namespace PrimerosPasosCsharp.App3
{
    partial class Notas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPaterno = new System.Windows.Forms.TextBox();
            this.TxtMaterno = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCarrera = new System.Windows.Forms.TextBox();
            this.TxtModulo = new System.Windows.Forms.TextBox();
            this.TxtUnidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCalcularYear = new System.Windows.Forms.Button();
            this.BtnCalcularPromedio = new System.Windows.Forms.Button();
            this.BtnMensaje = new System.Windows.Forms.Button();
            this.BtnResumen = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Notas";
            // 
            // TxtPaterno
            // 
            this.TxtPaterno.Location = new System.Drawing.Point(12, 116);
            this.TxtPaterno.Name = "TxtPaterno";
            this.TxtPaterno.Size = new System.Drawing.Size(204, 20);
            this.TxtPaterno.TabIndex = 1;
            // 
            // TxtMaterno
            // 
            this.TxtMaterno.Location = new System.Drawing.Point(297, 116);
            this.TxtMaterno.Name = "TxtMaterno";
            this.TxtMaterno.Size = new System.Drawing.Size(204, 20);
            this.TxtMaterno.TabIndex = 2;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(560, 116);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(204, 20);
            this.TxtNombres.TabIndex = 3;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(808, 116);
            this.TxtEdad.MaxLength = 2;
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(81, 20);
            this.TxtEdad.TabIndex = 4;
            this.TxtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(74, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(356, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(624, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(824, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edad";
            // 
            // TxtCarrera
            // 
            this.TxtCarrera.Location = new System.Drawing.Point(12, 210);
            this.TxtCarrera.Name = "TxtCarrera";
            this.TxtCarrera.Size = new System.Drawing.Size(388, 20);
            this.TxtCarrera.TabIndex = 9;
            // 
            // TxtModulo
            // 
            this.TxtModulo.Location = new System.Drawing.Point(415, 210);
            this.TxtModulo.MaxLength = 1;
            this.TxtModulo.Name = "TxtModulo";
            this.TxtModulo.Size = new System.Drawing.Size(67, 20);
            this.TxtModulo.TabIndex = 10;
            this.TxtModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModulo_KeyPress);
            // 
            // TxtUnidad
            // 
            this.TxtUnidad.Location = new System.Drawing.Point(499, 210);
            this.TxtUnidad.Name = "TxtUnidad";
            this.TxtUnidad.Size = new System.Drawing.Size(390, 20);
            this.TxtUnidad.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(164, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Carrera Profesional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(430, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Módulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(660, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Unidad Didáctica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(12, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nota 01";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(12, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nota 02";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(9, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nota 03";
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(91, 297);
            this.TxtNota1.MaxLength = 2;
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(67, 20);
            this.TxtNota1.TabIndex = 18;
            this.TxtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNota1_KeyPress);
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(91, 342);
            this.TxtNota2.MaxLength = 2;
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(67, 20);
            this.TxtNota2.TabIndex = 19;
            this.TxtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNota2_KeyPress);
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(91, 390);
            this.TxtNota3.MaxLength = 2;
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(67, 20);
            this.TxtNota3.TabIndex = 20;
            this.TxtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNota3_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(267, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Año de Nacimiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(267, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Promedio";
            // 
            // TxtYear
            // 
            this.TxtYear.Enabled = false;
            this.TxtYear.Location = new System.Drawing.Point(387, 342);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(85, 20);
            this.TxtYear.TabIndex = 23;
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.Enabled = false;
            this.TxtPromedio.Location = new System.Drawing.Point(387, 390);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.Size = new System.Drawing.Size(85, 20);
            this.TxtPromedio.TabIndex = 24;
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.Blue;
            this.LblMensaje.Location = new System.Drawing.Point(557, 397);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(0, 13);
            this.LblMensaje.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.BtnResumen);
            this.groupBox1.Controls.Add(this.BtnMensaje);
            this.groupBox1.Controls.Add(this.BtnCalcularPromedio);
            this.groupBox1.Controls.Add(this.BtnCalcularYear);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.BtnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 67);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.Red;
            this.BtnNuevo.Location = new System.Drawing.Point(21, 28);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Red;
            this.BtnGuardar.Location = new System.Drawing.Point(112, 28);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCalcularYear
            // 
            this.BtnCalcularYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularYear.ForeColor = System.Drawing.Color.Red;
            this.BtnCalcularYear.Location = new System.Drawing.Point(207, 28);
            this.BtnCalcularYear.Name = "BtnCalcularYear";
            this.BtnCalcularYear.Size = new System.Drawing.Size(165, 23);
            this.BtnCalcularYear.TabIndex = 2;
            this.BtnCalcularYear.Text = "Calcular Año Nacimiento";
            this.BtnCalcularYear.UseVisualStyleBackColor = true;
            this.BtnCalcularYear.Click += new System.EventHandler(this.BtnCalcularYear_Click);
            // 
            // BtnCalcularPromedio
            // 
            this.BtnCalcularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularPromedio.ForeColor = System.Drawing.Color.Red;
            this.BtnCalcularPromedio.Location = new System.Drawing.Point(392, 28);
            this.BtnCalcularPromedio.Name = "BtnCalcularPromedio";
            this.BtnCalcularPromedio.Size = new System.Drawing.Size(130, 23);
            this.BtnCalcularPromedio.TabIndex = 3;
            this.BtnCalcularPromedio.Text = "Calcular Promedio";
            this.BtnCalcularPromedio.UseVisualStyleBackColor = true;
            this.BtnCalcularPromedio.Click += new System.EventHandler(this.BtnCalcularPromedio_Click);
            // 
            // BtnMensaje
            // 
            this.BtnMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMensaje.ForeColor = System.Drawing.Color.Red;
            this.BtnMensaje.Location = new System.Drawing.Point(546, 28);
            this.BtnMensaje.Name = "BtnMensaje";
            this.BtnMensaje.Size = new System.Drawing.Size(115, 23);
            this.BtnMensaje.TabIndex = 4;
            this.BtnMensaje.Text = "Ver Mensaje";
            this.BtnMensaje.UseVisualStyleBackColor = true;
            this.BtnMensaje.Click += new System.EventHandler(this.BtnMensaje_Click);
            // 
            // BtnResumen
            // 
            this.BtnResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResumen.ForeColor = System.Drawing.Color.Red;
            this.BtnResumen.Location = new System.Drawing.Point(681, 28);
            this.BtnResumen.Name = "BtnResumen";
            this.BtnResumen.Size = new System.Drawing.Size(115, 23);
            this.BtnResumen.TabIndex = 5;
            this.BtnResumen.Text = "Resumen";
            this.BtnResumen.UseVisualStyleBackColor = true;
            this.BtnResumen.Click += new System.EventHandler(this.BtnResumen_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Red;
            this.BtnSalir.Location = new System.Drawing.Point(815, 28);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(115, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.TxtPromedio);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtUnidad);
            this.Controls.Add(this.TxtModulo);
            this.Controls.Add(this.TxtCarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.TxtMaterno);
            this.Controls.Add(this.TxtPaterno);
            this.Controls.Add(this.panel1);
            this.Name = "Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPaterno;
        private System.Windows.Forms.TextBox TxtMaterno;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCarrera;
        private System.Windows.Forms.TextBox TxtModulo;
        private System.Windows.Forms.TextBox TxtUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnResumen;
        private System.Windows.Forms.Button BtnMensaje;
        private System.Windows.Forms.Button BtnCalcularPromedio;
        private System.Windows.Forms.Button BtnCalcularYear;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnNuevo;
    }
}