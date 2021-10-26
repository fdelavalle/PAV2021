
namespace TP_PAVI
{
    partial class Form_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Categoria));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.restoreBtn = new System.Windows.Forms.PictureBox();
            this.maxBtn = new System.Windows.Forms.PictureBox();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.checkBoxCursosEliminados = new System.Windows.Forms.CheckBox();
            this.groupBoxInfoCategoria = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInfoNombre = new System.Windows.Forms.GroupBox();
            this.lblInfoNombre = new System.Windows.Forms.Label();
            this.infoCategorías = new System.Windows.Forms.PictureBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.textBoxNombreCurso = new System.Windows.Forms.TextBox();
            this.labelCategoría = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.infoNombre = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnEliminarCurso = new System.Windows.Forms.PictureBox();
            this.btnModificarCurso = new System.Windows.Forms.PictureBox();
            this.btnCrearCurso = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.groupBoxInfoCategoria.SuspendLayout();
            this.groupBoxInfoNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoCategorías)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelBarraTitulo.Controls.Add(this.label2);
            this.panelBarraTitulo.Controls.Add(this.minBtn);
            this.panelBarraTitulo.Controls.Add(this.closeBtn);
            this.panelBarraTitulo.Controls.Add(this.restoreBtn);
            this.panelBarraTitulo.Controls.Add(this.maxBtn);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(537, 47);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            this.panelBarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Categorias";
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minBtn.Image = ((System.Drawing.Image)(resources.GetObject("minBtn.Image")));
            this.minBtn.Location = new System.Drawing.Point(438, 11);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(25, 25);
            this.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBtn.TabIndex = 1;
            this.minBtn.TabStop = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(500, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("restoreBtn.Image")));
            this.restoreBtn.Location = new System.Drawing.Point(469, 12);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(25, 25);
            this.restoreBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restoreBtn.TabIndex = 3;
            this.restoreBtn.TabStop = false;
            this.restoreBtn.Visible = false;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            this.restoreBtn.MouseEnter += new System.EventHandler(this.restoreBtn_MouseEnter);
            this.restoreBtn.MouseLeave += new System.EventHandler(this.restoreBtn_MouseLeave);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxBtn.Image = ((System.Drawing.Image)(resources.GetObject("maxBtn.Image")));
            this.maxBtn.Location = new System.Drawing.Point(469, 11);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(25, 25);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 2;
            this.maxBtn.TabStop = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            this.maxBtn.MouseEnter += new System.EventHandler(this.maxBtn_MouseEnter);
            this.maxBtn.MouseLeave += new System.EventHandler(this.maxBtn_MouseLeave);
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.textDescripcion);
            this.groupBoxFiltros.Controls.Add(this.checkBoxCursosEliminados);
            this.groupBoxFiltros.Controls.Add(this.groupBoxInfoCategoria);
            this.groupBoxFiltros.Controls.Add(this.groupBoxInfoNombre);
            this.groupBoxFiltros.Controls.Add(this.infoCategorías);
            this.groupBoxFiltros.Controls.Add(this.buttonConsultar);
            this.groupBoxFiltros.Controls.Add(this.dgvCategorias);
            this.groupBoxFiltros.Controls.Add(this.textBoxNombreCurso);
            this.groupBoxFiltros.Controls.Add(this.labelCategoría);
            this.groupBoxFiltros.Controls.Add(this.lblNombreCurso);
            this.groupBoxFiltros.Controls.Add(this.infoNombre);
            this.groupBoxFiltros.Location = new System.Drawing.Point(12, 53);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(518, 490);
            this.groupBoxFiltros.TabIndex = 1;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            this.groupBoxFiltros.Enter += new System.EventHandler(this.groupBoxFiltros_Enter);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(21, 111);
            this.textDescripcion.MaxLength = 50;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(155, 24);
            this.textDescripcion.TabIndex = 15;
            // 
            // checkBoxCursosEliminados
            // 
            this.checkBoxCursosEliminados.AutoSize = true;
            this.checkBoxCursosEliminados.Location = new System.Drawing.Point(21, 220);
            this.checkBoxCursosEliminados.Name = "checkBoxCursosEliminados";
            this.checkBoxCursosEliminados.Size = new System.Drawing.Size(231, 21);
            this.checkBoxCursosEliminados.TabIndex = 14;
            this.checkBoxCursosEliminados.Text = "Incluir categorias dadas de baja";
            this.checkBoxCursosEliminados.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfoCategoria
            // 
            this.groupBoxInfoCategoria.Controls.Add(this.label1);
            this.groupBoxInfoCategoria.Location = new System.Drawing.Point(223, 72);
            this.groupBoxInfoCategoria.Name = "groupBoxInfoCategoria";
            this.groupBoxInfoCategoria.Size = new System.Drawing.Size(265, 58);
            this.groupBoxInfoCategoria.TabIndex = 9;
            this.groupBoxInfoCategoria.TabStop = false;
            this.groupBoxInfoCategoria.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Si se deja en blanco ignora el filtro \r\npor descripcion";
            // 
            // groupBoxInfoNombre
            // 
            this.groupBoxInfoNombre.Controls.Add(this.lblInfoNombre);
            this.groupBoxInfoNombre.Location = new System.Drawing.Point(223, 21);
            this.groupBoxInfoNombre.Name = "groupBoxInfoNombre";
            this.groupBoxInfoNombre.Size = new System.Drawing.Size(265, 58);
            this.groupBoxInfoNombre.TabIndex = 8;
            this.groupBoxInfoNombre.TabStop = false;
            this.groupBoxInfoNombre.Visible = false;
            // 
            // lblInfoNombre
            // 
            this.lblInfoNombre.AutoSize = true;
            this.lblInfoNombre.Location = new System.Drawing.Point(6, 14);
            this.lblInfoNombre.Name = "lblInfoNombre";
            this.lblInfoNombre.Size = new System.Drawing.Size(230, 34);
            this.lblInfoNombre.TabIndex = 0;
            this.lblInfoNombre.Text = "Si se deja en blanco ignora el filtro \r\npor nombre";
            // 
            // infoCategorías
            // 
            this.infoCategorías.Image = global::TP_PAVI.Properties.Resources.icons8_info_100;
            this.infoCategorías.Location = new System.Drawing.Point(188, 111);
            this.infoCategorías.Name = "infoCategorías";
            this.infoCategorías.Size = new System.Drawing.Size(39, 24);
            this.infoCategorías.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoCategorías.TabIndex = 7;
            this.infoCategorías.TabStop = false;
            this.infoCategorías.MouseEnter += new System.EventHandler(this.infoCategorías_MouseEnter);
            this.infoCategorías.MouseLeave += new System.EventHandler(this.infoCategorías_MouseLeave);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(401, 210);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(93, 36);
            this.buttonConsultar.TabIndex = 6;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(21, 262);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(473, 212);
            this.dgvCategorias.TabIndex = 5;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // textBoxNombreCurso
            // 
            this.textBoxNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCurso.Location = new System.Drawing.Point(21, 55);
            this.textBoxNombreCurso.MaxLength = 50;
            this.textBoxNombreCurso.Name = "textBoxNombreCurso";
            this.textBoxNombreCurso.Size = new System.Drawing.Size(155, 24);
            this.textBoxNombreCurso.TabIndex = 4;
            // 
            // labelCategoría
            // 
            this.labelCategoría.AutoSize = true;
            this.labelCategoría.Location = new System.Drawing.Point(18, 91);
            this.labelCategoría.Name = "labelCategoría";
            this.labelCategoría.Size = new System.Drawing.Size(82, 17);
            this.labelCategoría.TabIndex = 2;
            this.labelCategoría.Text = "Descripcion";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(18, 35);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(58, 17);
            this.lblNombreCurso.TabIndex = 1;
            this.lblNombreCurso.Text = "Nombre";
            // 
            // infoNombre
            // 
            this.infoNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoNombre.Image = global::TP_PAVI.Properties.Resources.icons8_info_100;
            this.infoNombre.Location = new System.Drawing.Point(188, 55);
            this.infoNombre.Name = "infoNombre";
            this.infoNombre.Size = new System.Drawing.Size(39, 24);
            this.infoNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoNombre.TabIndex = 0;
            this.infoNombre.TabStop = false;
            this.infoNombre.MouseEnter += new System.EventHandler(this.infoNombre_MouseEnter);
            this.infoNombre.MouseLeave += new System.EventHandler(this.infoNombre_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::TP_PAVI.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(430, 549);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 50);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCurso.Enabled = false;
            this.btnEliminarCurso.Image = global::TP_PAVI.Properties.Resources.eliminar;
            this.btnEliminarCurso.Location = new System.Drawing.Point(200, 549);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(53, 50);
            this.btnEliminarCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminarCurso.TabIndex = 4;
            this.btnEliminarCurso.TabStop = false;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            this.btnEliminarCurso.MouseEnter += new System.EventHandler(this.btnEliminarCurso_MouseEnter);
            this.btnEliminarCurso.MouseLeave += new System.EventHandler(this.btnEliminarCurso_MouseLeave);
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCurso.Enabled = false;
            this.btnModificarCurso.Image = global::TP_PAVI.Properties.Resources.editar;
            this.btnModificarCurso.Location = new System.Drawing.Point(106, 549);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(53, 50);
            this.btnModificarCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificarCurso.TabIndex = 3;
            this.btnModificarCurso.TabStop = false;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            this.btnModificarCurso.MouseEnter += new System.EventHandler(this.btnModificarCurso_MouseEnter);
            this.btnModificarCurso.MouseLeave += new System.EventHandler(this.btnModificarCurso_MouseLeave);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCurso.Image = global::TP_PAVI.Properties.Resources.crear;
            this.btnCrearCurso.Location = new System.Drawing.Point(12, 549);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(53, 50);
            this.btnCrearCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCrearCurso.TabIndex = 2;
            this.btnCrearCurso.TabStop = false;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            this.btnCrearCurso.MouseEnter += new System.EventHandler(this.btnCrearCurso_MouseEnter);
            this.btnCrearCurso.MouseLeave += new System.EventHandler(this.btnCrearCurso_MouseLeave);
            // 
            // Form_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 611);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.btnCrearCurso);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Categoria_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.groupBoxInfoCategoria.ResumeLayout(false);
            this.groupBoxInfoCategoria.PerformLayout();
            this.groupBoxInfoNombre.ResumeLayout(false);
            this.groupBoxInfoNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoCategorías)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox restoreBtn;
        private System.Windows.Forms.PictureBox maxBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minBtn;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.PictureBox infoNombre;
        private System.Windows.Forms.PictureBox btnCrearCurso;
        private System.Windows.Forms.PictureBox btnModificarCurso;
        private System.Windows.Forms.PictureBox btnEliminarCurso;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox textBoxNombreCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.GroupBox groupBoxInfoNombre;
        private System.Windows.Forms.Label lblInfoNombre;
        private System.Windows.Forms.CheckBox checkBoxCursosEliminados;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.GroupBox groupBoxInfoCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox infoCategorías;
        private System.Windows.Forms.Label labelCategoría;
        private System.Windows.Forms.Label label2;
    }
}

