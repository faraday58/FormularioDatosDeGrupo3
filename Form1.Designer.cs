namespace FormularioDatosDeGrupo3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNombreAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbMateria = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del alumno";
            // 
            // txtbNombreAlumno
            // 
            this.txtbNombreAlumno.Location = new System.Drawing.Point(229, 45);
            this.txtbNombreAlumno.Name = "txtbNombreAlumno";
            this.txtbNombreAlumno.Size = new System.Drawing.Size(200, 26);
            this.txtbNombreAlumno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de cuenta";
            // 
            // txtbNumeroCuenta
            // 
            this.txtbNumeroCuenta.Location = new System.Drawing.Point(229, 101);
            this.txtbNumeroCuenta.Name = "txtbNumeroCuenta";
            this.txtbNumeroCuenta.Size = new System.Drawing.Size(200, 26);
            this.txtbNumeroCuenta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Materia";
            // 
            // txtbMateria
            // 
            this.txtbMateria.Location = new System.Drawing.Point(229, 168);
            this.txtbMateria.Name = "txtbMateria";
            this.txtbMateria.Size = new System.Drawing.Size(200, 26);
            this.txtbMateria.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(110, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 49);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(315, 239);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(95, 49);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 319);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbNumeroCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNombreAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Grupo 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNombreAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNumeroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbMateria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

