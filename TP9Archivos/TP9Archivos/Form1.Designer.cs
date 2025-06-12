namespace TP9Archivos
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
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(120, 35);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(184, 20);
            this.txtLegajo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellio y nombre";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Location = new System.Drawing.Point(120, 85);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(184, 20);
            this.txtApellidoNombre.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellidoNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLegajo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestor Alumnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(120, 135);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(184, 20);
            this.txtCategoria.TabIndex = 5;
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(12, 203);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(480, 186);
            this.lstListado.TabIndex = 5;
            this.lstListado.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 405);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(156, 23);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(173, 405);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(156, 23);
            this.btnBaja.TabIndex = 7;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(335, 405);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(156, 23);
            this.btnModificacion.TabIndex = 8;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(416, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(364, 88);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 486);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "archivo secuencial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
    }
}

