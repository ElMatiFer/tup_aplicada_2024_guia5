namespace aaaaa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCodigos = new System.Windows.Forms.ComboBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btIniciar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBanco = new System.Windows.Forms.RadioButton();
            this.rbMesa = new System.Windows.Forms.RadioButton();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCodigos);
            this.groupBox1.Controls.Add(this.btBorrar);
            this.groupBox1.Controls.Add(this.btCerrar);
            this.groupBox1.Controls.Add(this.btIniciar);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cbCodigos
            // 
            this.cbCodigos.FormattingEnabled = true;
            this.cbCodigos.Location = new System.Drawing.Point(9, 87);
            this.cbCodigos.Name = "cbCodigos";
            this.cbCodigos.Size = new System.Drawing.Size(158, 21);
            this.cbCodigos.TabIndex = 8;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(184, 87);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(162, 23);
            this.btBorrar.TabIndex = 7;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(184, 42);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(162, 23);
            this.btCerrar.TabIndex = 6;
            this.btCerrar.Text = "Cerrar presupuesto";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(184, 13);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(162, 23);
            this.btIniciar.TabIndex = 5;
            this.btIniciar.Text = "Iniciar presupuesto";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(67, 45);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(67, 15);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBanco);
            this.groupBox2.Controls.Add(this.rbMesa);
            this.groupBox2.Controls.Add(this.tbGrosor);
            this.groupBox2.Controls.Add(this.tbLargo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btAgregar);
            this.groupBox2.Controls.Add(this.tbAncho);
            this.groupBox2.Controls.Add(this.tbPrecio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(380, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // rbBanco
            // 
            this.rbBanco.AutoSize = true;
            this.rbBanco.Location = new System.Drawing.Point(82, 123);
            this.rbBanco.Name = "rbBanco";
            this.rbBanco.Size = new System.Drawing.Size(56, 17);
            this.rbBanco.TabIndex = 2;
            this.rbBanco.TabStop = true;
            this.rbBanco.Text = "Banco";
            this.rbBanco.UseVisualStyleBackColor = true;
            this.rbBanco.CheckedChanged += new System.EventHandler(this.rbBanco_CheckedChanged);
            // 
            // rbMesa
            // 
            this.rbMesa.AutoSize = true;
            this.rbMesa.Location = new System.Drawing.Point(218, 123);
            this.rbMesa.Name = "rbMesa";
            this.rbMesa.Size = new System.Drawing.Size(51, 17);
            this.rbMesa.TabIndex = 3;
            this.rbMesa.TabStop = true;
            this.rbMesa.Text = "Mesa";
            this.rbMesa.UseVisualStyleBackColor = true;
            this.rbMesa.CheckedChanged += new System.EventHandler(this.rbMesa_CheckedChanged);
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(246, 46);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(100, 20);
            this.tbGrosor.TabIndex = 13;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(246, 16);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(100, 20);
            this.tbLargo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grosor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Largo:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(67, 77);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo:";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(184, 77);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(162, 23);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(67, 45);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(100, 20);
            this.tbAncho.TabIndex = 4;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(67, 15);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ancho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Precio B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 197);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbBanco;
        private System.Windows.Forms.RadioButton rbMesa;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbCodigos;
    }
}

