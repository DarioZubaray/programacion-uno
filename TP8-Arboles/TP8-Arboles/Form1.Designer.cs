namespace TP8_Arboles
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarRaiz = new System.Windows.Forms.Button();
            this.btnAgregarIzquierda = new System.Windows.Forms.Button();
            this.btnAgregarDerecha = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnInorden = new System.Windows.Forms.Button();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.lstRecorrido = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(346, 250);
            this.treeView1.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(440, 57);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(196, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // btnAgregarRaiz
            // 
            this.btnAgregarRaiz.Location = new System.Drawing.Point(390, 97);
            this.btnAgregarRaiz.Name = "btnAgregarRaiz";
            this.btnAgregarRaiz.Size = new System.Drawing.Size(246, 23);
            this.btnAgregarRaiz.TabIndex = 3;
            this.btnAgregarRaiz.Text = "Agregar Raiz";
            this.btnAgregarRaiz.UseVisualStyleBackColor = true;
            this.btnAgregarRaiz.Click += new System.EventHandler(this.btnAgregarRaiz_Click);
            // 
            // btnAgregarIzquierda
            // 
            this.btnAgregarIzquierda.Location = new System.Drawing.Point(390, 140);
            this.btnAgregarIzquierda.Name = "btnAgregarIzquierda";
            this.btnAgregarIzquierda.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarIzquierda.TabIndex = 4;
            this.btnAgregarIzquierda.Text = "Agregar Izquierda";
            this.btnAgregarIzquierda.UseVisualStyleBackColor = true;
            this.btnAgregarIzquierda.Click += new System.EventHandler(this.btnAgregarIzquierda_Click);
            // 
            // btnAgregarDerecha
            // 
            this.btnAgregarDerecha.Location = new System.Drawing.Point(516, 140);
            this.btnAgregarDerecha.Name = "btnAgregarDerecha";
            this.btnAgregarDerecha.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarDerecha.TabIndex = 5;
            this.btnAgregarDerecha.Text = "Agregar Derecha";
            this.btnAgregarDerecha.UseVisualStyleBackColor = true;
            this.btnAgregarDerecha.Click += new System.EventHandler(this.btnAgregarDerecha_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPostorden);
            this.groupBox1.Controls.Add(this.btnInorden);
            this.groupBox1.Controls.Add(this.btnPreorden);
            this.groupBox1.Location = new System.Drawing.Point(390, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos";
            // 
            // btnPreorden
            // 
            this.btnPreorden.Location = new System.Drawing.Point(6, 33);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(234, 23);
            this.btnPreorden.TabIndex = 0;
            this.btnPreorden.Text = "PreOrden";
            this.btnPreorden.UseVisualStyleBackColor = true;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);
            // 
            // btnInorden
            // 
            this.btnInorden.Location = new System.Drawing.Point(7, 62);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(233, 23);
            this.btnInorden.TabIndex = 1;
            this.btnInorden.Text = "InOrden";
            this.btnInorden.UseVisualStyleBackColor = true;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click);
            // 
            // btnPostorden
            // 
            this.btnPostorden.Location = new System.Drawing.Point(7, 91);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(233, 23);
            this.btnPostorden.TabIndex = 2;
            this.btnPostorden.Text = "PosOrden";
            this.btnPostorden.UseVisualStyleBackColor = true;
            this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click);
            // 
            // lstRecorrido
            // 
            this.lstRecorrido.FormattingEnabled = true;
            this.lstRecorrido.Location = new System.Drawing.Point(12, 303);
            this.lstRecorrido.Name = "lstRecorrido";
            this.lstRecorrido.Size = new System.Drawing.Size(346, 134);
            this.lstRecorrido.TabIndex = 7;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(390, 13);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(60, 24);
            this.lblSelected.TabIndex = 8;
            this.lblSelected.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstRecorrido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarDerecha);
            this.Controls.Add(this.btnAgregarIzquierda);
            this.Controls.Add(this.btnAgregarRaiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "TP8";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarRaiz;
        private System.Windows.Forms.Button btnAgregarIzquierda;
        private System.Windows.Forms.Button btnAgregarDerecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.ListBox lstRecorrido;
        private System.Windows.Forms.Label lblSelected;
    }
}

