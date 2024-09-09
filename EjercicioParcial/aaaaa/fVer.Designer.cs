namespace aaaaa
{
    partial class fVer
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
            this.lbResumen = new System.Windows.Forms.ListBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResumen
            // 
            this.lbResumen.FormattingEnabled = true;
            this.lbResumen.Location = new System.Drawing.Point(12, 12);
            this.lbResumen.Name = "lbResumen";
            this.lbResumen.Size = new System.Drawing.Size(479, 368);
            this.lbResumen.TabIndex = 0;
            // 
            // btCerrar
            // 
            this.btCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCerrar.Location = new System.Drawing.Point(228, 386);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // fVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 415);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.lbResumen);
            this.Name = "fVer";
            this.Text = "Ver resumen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCerrar;
        public System.Windows.Forms.ListBox lbResumen;
    }
}