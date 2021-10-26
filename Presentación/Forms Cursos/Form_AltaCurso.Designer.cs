
namespace TP_PAVI.Presentación.Forms_Cursos
{
    partial class Form_AltaCurso
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
            this.Nombre = new System.Windows.Forms.Label();
            this.FechaVigencia = new System.Windows.Forms.Label();
            this.Categoría = new System.Windows.Forms.Label();
            this.Descripción = new System.Windows.Forms.Label();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBoxRegresar = new System.Windows.Forms.PictureBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(501, 11);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(532, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(470, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Size = new System.Drawing.Size(569, 47);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(501, 11);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(29, 80);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(81, 25);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // FechaVigencia
            // 
            this.FechaVigencia.AutoSize = true;
            this.FechaVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVigencia.Location = new System.Drawing.Point(29, 142);
            this.FechaVigencia.Name = "FechaVigencia";
            this.FechaVigencia.Size = new System.Drawing.Size(144, 25);
            this.FechaVigencia.TabIndex = 2;
            this.FechaVigencia.Text = "Fecha vigencia";
            // 
            // Categoría
            // 
            this.Categoría.AutoSize = true;
            this.Categoría.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoría.Location = new System.Drawing.Point(29, 112);
            this.Categoría.Name = "Categoría";
            this.Categoría.Size = new System.Drawing.Size(97, 25);
            this.Categoría.TabIndex = 3;
            this.Categoría.Text = "Categoría";
            // 
            // Descripción
            // 
            this.Descripción.AutoSize = true;
            this.Descripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripción.Location = new System.Drawing.Point(29, 170);
            this.Descripción.Name = "Descripción";
            this.Descripción.Size = new System.Drawing.Size(114, 25);
            this.Descripción.TabIndex = 4;
            this.Descripción.Text = "Descripción";
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(206, 146);
            this.maskedTextBoxFecha.Mask = "00/00/0000";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(217, 22);
            this.maskedTextBoxFecha.TabIndex = 2;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(207, 174);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(216, 93);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(206, 84);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(217, 22);
            this.textBoxNombre.TabIndex = 0;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(206, 116);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(217, 24);
            this.comboBoxCategoria.TabIndex = 1;
            // 
            // pictureBoxRegresar
            // 
            this.pictureBoxRegresar.Image = global::TP_PAVI.Properties.Resources.salir;
            this.pictureBoxRegresar.Location = new System.Drawing.Point(457, 295);
            this.pictureBoxRegresar.Name = "pictureBoxRegresar";
            this.pictureBoxRegresar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegresar.TabIndex = 9;
            this.pictureBoxRegresar.TabStop = false;
            this.pictureBoxRegresar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxRegresar.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxRegresar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(296, 273);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(127, 43);
            this.buttonConfirmar.TabIndex = 4;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // Form_AltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 357);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.pictureBoxRegresar);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.Descripción);
            this.Controls.Add(this.Categoría);
            this.Controls.Add(this.FechaVigencia);
            this.Controls.Add(this.Nombre);
            this.Name = "Form_AltaCurso";
            this.Text = "Form_AltaCurso";
            this.Load += new System.EventHandler(this.Form_AltaCurso_Load);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.Nombre, 0);
            this.Controls.SetChildIndex(this.FechaVigencia, 0);
            this.Controls.SetChildIndex(this.Categoría, 0);
            this.Controls.SetChildIndex(this.Descripción, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxFecha, 0);
            this.Controls.SetChildIndex(this.textBoxDescripcion, 0);
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.comboBoxCategoria, 0);
            this.Controls.SetChildIndex(this.pictureBoxRegresar, 0);
            this.Controls.SetChildIndex(this.buttonConfirmar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label FechaVigencia;
        private System.Windows.Forms.Label Categoría;
        private System.Windows.Forms.Label Descripción;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
        public System.Windows.Forms.TextBox textBoxDescripcion;
        public System.Windows.Forms.TextBox textBoxNombre;
        public System.Windows.Forms.ComboBox comboBoxCategoria;
        public System.Windows.Forms.PictureBox pictureBoxRegresar;
        public System.Windows.Forms.Button buttonConfirmar;
    }
}