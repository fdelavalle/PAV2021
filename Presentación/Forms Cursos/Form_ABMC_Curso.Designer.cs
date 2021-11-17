
namespace TP_PAVI.Presentación.Forms_Cursos
{
    partial class Form_ABMC_Curso
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.infoCategoría = new System.Windows.Forms.PictureBox();
            this.infoFechaVigencia = new System.Windows.Forms.PictureBox();
            this.infoNombre = new System.Windows.Forms.PictureBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.checkBoxDadosBaja = new System.Windows.Forms.CheckBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelFechaVigencia = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.toolTipInfoFiltros = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.groupBoxCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoCategoría)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFechaVigencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(582, 5);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(610, 11);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(640, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(580, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Size = new System.Drawing.Size(675, 47);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(484, 11);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AllowUserToAddRows = false;
            this.dataGridViewCursos.AllowUserToDeleteRows = false;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(12, 256);
            this.dataGridViewCursos.MultiSelect = false;
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.ReadOnly = true;
            this.dataGridViewCursos.RowHeadersWidth = 51;
            this.dataGridViewCursos.RowTemplate.Height = 24;
            this.dataGridViewCursos.ShowEditingIcon = false;
            this.dataGridViewCursos.Size = new System.Drawing.Size(628, 223);
            this.dataGridViewCursos.TabIndex = 6;
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.infoCategoría);
            this.groupBoxCursos.Controls.Add(this.infoFechaVigencia);
            this.groupBoxCursos.Controls.Add(this.infoNombre);
            this.groupBoxCursos.Controls.Add(this.buttonConsultar);
            this.groupBoxCursos.Controls.Add(this.checkBoxDadosBaja);
            this.groupBoxCursos.Controls.Add(this.comboBoxCategoria);
            this.groupBoxCursos.Controls.Add(this.maskedTextBoxFecha);
            this.groupBoxCursos.Controls.Add(this.textBoxNombre);
            this.groupBoxCursos.Controls.Add(this.labelCategoria);
            this.groupBoxCursos.Controls.Add(this.labelFechaVigencia);
            this.groupBoxCursos.Controls.Add(this.labelNombre);
            this.groupBoxCursos.Controls.Add(this.dataGridViewCursos);
            this.groupBoxCursos.Location = new System.Drawing.Point(17, 54);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(648, 485);
            this.groupBoxCursos.TabIndex = 7;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Filtros";
            // 
            // infoCategoría
            // 
            this.infoCategoría.Image = global::TP_PAVI.Properties.Resources.icons8_info_100;
            this.infoCategoría.Location = new System.Drawing.Point(201, 120);
            this.infoCategoría.Name = "infoCategoría";
            this.infoCategoría.Size = new System.Drawing.Size(28, 26);
            this.infoCategoría.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoCategoría.TabIndex = 17;
            this.infoCategoría.TabStop = false;
            // 
            // infoFechaVigencia
            // 
            this.infoFechaVigencia.Image = global::TP_PAVI.Properties.Resources.icons8_info_100;
            this.infoFechaVigencia.Location = new System.Drawing.Point(201, 188);
            this.infoFechaVigencia.Name = "infoFechaVigencia";
            this.infoFechaVigencia.Size = new System.Drawing.Size(28, 26);
            this.infoFechaVigencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoFechaVigencia.TabIndex = 16;
            this.infoFechaVigencia.TabStop = false;
            // 
            // infoNombre
            // 
            this.infoNombre.Image = global::TP_PAVI.Properties.Resources.icons8_info_100;
            this.infoNombre.Location = new System.Drawing.Point(201, 58);
            this.infoNombre.Name = "infoNombre";
            this.infoNombre.Size = new System.Drawing.Size(28, 26);
            this.infoNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoNombre.TabIndex = 15;
            this.infoNombre.TabStop = false;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(527, 211);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(113, 39);
            this.buttonConsultar.TabIndex = 14;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // checkBoxDadosBaja
            // 
            this.checkBoxDadosBaja.AutoSize = true;
            this.checkBoxDadosBaja.Location = new System.Drawing.Point(12, 229);
            this.checkBoxDadosBaja.Name = "checkBoxDadosBaja";
            this.checkBoxDadosBaja.Size = new System.Drawing.Size(161, 21);
            this.checkBoxDadosBaja.TabIndex = 13;
            this.checkBoxDadosBaja.Text = "Incluir dados de baja";
            this.checkBoxDadosBaja.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(12, 120);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(174, 28);
            this.comboBoxCategoria.TabIndex = 12;
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(12, 188);
            this.maskedTextBoxFecha.Mask = "00/00/0000";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(174, 26);
            this.maskedTextBoxFecha.TabIndex = 11;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(12, 58);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(174, 26);
            this.textBoxNombre.TabIndex = 10;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(8, 97);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(81, 20);
            this.labelCategoria.TabIndex = 9;
            this.labelCategoria.Text = "Categoría";
            // 
            // labelFechaVigencia
            // 
            this.labelFechaVigencia.AutoSize = true;
            this.labelFechaVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVigencia.Location = new System.Drawing.Point(8, 165);
            this.labelFechaVigencia.Name = "labelFechaVigencia";
            this.labelFechaVigencia.Size = new System.Drawing.Size(121, 20);
            this.labelFechaVigencia.TabIndex = 8;
            this.labelFechaVigencia.Text = "Fecha vigencia";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(8, 33);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 20);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // Form_ABMC_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 612);
            this.Controls.Add(this.groupBoxCursos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ABMC_Curso";
            this.Text = "Form_ABMC_Curso";
            this.Load += new System.EventHandler(this.Form_ABMC_Curso_Load);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.groupBoxCursos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoCategoría)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFechaVigencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelFechaVigencia;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.CheckBox checkBoxDadosBaja;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.PictureBox infoCategoría;
        private System.Windows.Forms.PictureBox infoFechaVigencia;
        private System.Windows.Forms.PictureBox infoNombre;
        private System.Windows.Forms.ToolTip toolTipInfoFiltros;
    }
}