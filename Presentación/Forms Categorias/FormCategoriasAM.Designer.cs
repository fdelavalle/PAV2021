
namespace TP_PAVI.Presentación.Forms_Categorias
{
    partial class FormCategoriasAM
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.greaterBtn = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greaterBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(511, 11);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(553, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(491, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Controls.Add(this.greaterBtn);
            this.panelBarraTitulo.Size = new System.Drawing.Size(590, 47);
            this.panelBarraTitulo.Controls.SetChildIndex(this.maxBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.closeBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.minBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.restoreBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.Titulo, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.greaterBtn, 0);
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(12, 8);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(-1858, 11);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(53, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(117, 92);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(351, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(29, 152);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(117, 147);
            this.textBoxDescripcion.MaxLength = 50;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(351, 22);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(365, 189);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 41);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // greaterBtn
            // 
            this.greaterBtn.Image = global::TP_PAVI.Properties.Resources.max;
            this.greaterBtn.Location = new System.Drawing.Point(522, 11);
            this.greaterBtn.Name = "greaterBtn";
            this.greaterBtn.Size = new System.Drawing.Size(25, 24);
            this.greaterBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greaterBtn.TabIndex = 5;
            this.greaterBtn.TabStop = false;
            this.greaterBtn.Click += new System.EventHandler(this.greaterBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TP_PAVI.Properties.Resources.salir;
            this.btnExit.Location = new System.Drawing.Point(511, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 52);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormCategoriasAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 306);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormCategoriasAM";
            this.Text = "FormCategoriasAM";
            this.Load += new System.EventHandler(this.FormCategoriasAM_Load);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.textBoxDescripcion, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greaterBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox greaterBtn;
        private System.Windows.Forms.PictureBox btnExit;
    }
}