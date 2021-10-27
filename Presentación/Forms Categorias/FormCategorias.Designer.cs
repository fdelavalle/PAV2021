
namespace TP_PAVI.Presentación.Forms_Categorias
{
    partial class FormCategorias
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCategoria = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.checkboxCategorias = new System.Windows.Forms.CheckBox();
            this.btnCrearCategoria = new System.Windows.Forms.PictureBox();
            this.btnModificarCategoria = new System.Windows.Forms.PictureBox();
            this.btnEliminarCategoria = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(637, 11);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(668, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(606, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Size = new System.Drawing.Size(705, 47);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(182, 11);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtBoxCategoria
            // 
            this.txtBoxCategoria.Location = new System.Drawing.Point(187, 76);
            this.txtBoxCategoria.Name = "txtBoxCategoria";
            this.txtBoxCategoria.Size = new System.Drawing.Size(323, 22);
            this.txtBoxCategoria.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(556, 75);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(51, 134);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(578, 231);
            this.dgvCategorias.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TP_PAVI.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(607, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 55);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 8;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // checkboxCategorias
            // 
            this.checkboxCategorias.AutoSize = true;
            this.checkboxCategorias.Location = new System.Drawing.Point(556, 107);
            this.checkboxCategorias.Name = "checkboxCategorias";
            this.checkboxCategorias.Size = new System.Drawing.Size(70, 21);
            this.checkboxCategorias.TabIndex = 9;
            this.checkboxCategorias.Text = "Todas";
            this.checkboxCategorias.UseVisualStyleBackColor = true;
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.Image = global::TP_PAVI.Properties.Resources.icons8_create_90;
            this.btnCrearCategoria.Location = new System.Drawing.Point(51, 383);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(55, 55);
            this.btnCrearCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCrearCategoria.TabIndex = 10;
            this.btnCrearCategoria.TabStop = false;
            this.btnCrearCategoria.Click += new System.EventHandler(this.btnCrearCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Image = global::TP_PAVI.Properties.Resources.icons8_edit_96;
            this.btnModificarCategoria.Location = new System.Drawing.Point(122, 383);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(55, 55);
            this.btnModificarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnModificarCategoria.TabIndex = 11;
            this.btnModificarCategoria.TabStop = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Image = global::TP_PAVI.Properties.Resources.icons8_delete_64;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(187, 383);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(55, 55);
            this.btnEliminarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarCategoria.TabIndex = 12;
            this.btnEliminarCategoria.TabStop = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.checkboxCategorias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtBoxCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBoxCategoria, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.dgvCategorias, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.checkboxCategorias, 0);
            this.Controls.SetChildIndex(this.btnCrearCategoria, 0);
            this.Controls.SetChildIndex(this.btnModificarCategoria, 0);
            this.Controls.SetChildIndex(this.btnEliminarCategoria, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCategoria;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.CheckBox checkboxCategorias;
        private System.Windows.Forms.PictureBox btnCrearCategoria;
        private System.Windows.Forms.PictureBox btnModificarCategoria;
        private System.Windows.Forms.PictureBox btnEliminarCategoria;
    }
}