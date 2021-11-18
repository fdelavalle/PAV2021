
namespace TP_PAVI.Presentación.Forms_Objetivos
{
    partial class FormObjetivosABMC
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
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.labelNombreCorto = new System.Windows.Forms.Label();
            this.labelNombreLargo = new System.Windows.Forms.Label();
            this.textBoxNombreCorto = new System.Windows.Forms.TextBox();
            this.checkBoxDadosBaja = new System.Windows.Forms.CheckBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.infoNombreCorto = new System.Windows.Forms.PictureBox();
            this.infoNombreLargo = new System.Windows.Forms.PictureBox();
            this.textBoxNombreLargo = new System.Windows.Forms.TextBox();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.toolTipNombreCorto = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNombreLargo = new System.Windows.Forms.ToolTip(this.components);
            this.btnMax = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombreCorto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombreLargo)).BeginInit();
            this.groupBoxCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
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
            this.btnExit.Location = new System.Drawing.Point(605, 3);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(620, 11);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(655, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(589, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Controls.Add(this.btnMax);
            this.panelBarraTitulo.Size = new System.Drawing.Size(692, 47);
            this.panelBarraTitulo.Controls.SetChildIndex(this.maxBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.closeBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.minBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.restoreBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.Titulo, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.btnMax, 0);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(-352, 11);
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AllowUserToAddRows = false;
            this.dgvObjetivos.AllowUserToDeleteRows = false;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Location = new System.Drawing.Point(12, 201);
            this.dgvObjetivos.MultiSelect = false;
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.ReadOnly = true;
            this.dgvObjetivos.RowHeadersWidth = 51;
            this.dgvObjetivos.RowTemplate.Height = 24;
            this.dgvObjetivos.ShowEditingIcon = false;
            this.dgvObjetivos.Size = new System.Drawing.Size(628, 299);
            this.dgvObjetivos.TabIndex = 6;
            // 
            // labelNombreCorto
            // 
            this.labelNombreCorto.AutoSize = true;
            this.labelNombreCorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCorto.Location = new System.Drawing.Point(8, 33);
            this.labelNombreCorto.Name = "labelNombreCorto";
            this.labelNombreCorto.Size = new System.Drawing.Size(114, 20);
            this.labelNombreCorto.TabIndex = 7;
            this.labelNombreCorto.Text = "Nombre Corto";
            // 
            // labelNombreLargo
            // 
            this.labelNombreLargo.AutoSize = true;
            this.labelNombreLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreLargo.Location = new System.Drawing.Point(8, 97);
            this.labelNombreLargo.Name = "labelNombreLargo";
            this.labelNombreLargo.Size = new System.Drawing.Size(116, 20);
            this.labelNombreLargo.TabIndex = 9;
            this.labelNombreLargo.Text = "Nombre Largo";
            // 
            // textBoxNombreCorto
            // 
            this.textBoxNombreCorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCorto.Location = new System.Drawing.Point(12, 58);
            this.textBoxNombreCorto.MaxLength = 50;
            this.textBoxNombreCorto.Name = "textBoxNombreCorto";
            this.textBoxNombreCorto.Size = new System.Drawing.Size(174, 26);
            this.textBoxNombreCorto.TabIndex = 10;
            // 
            // checkBoxDadosBaja
            // 
            this.checkBoxDadosBaja.AutoSize = true;
            this.checkBoxDadosBaja.Location = new System.Drawing.Point(12, 167);
            this.checkBoxDadosBaja.Name = "checkBoxDadosBaja";
            this.checkBoxDadosBaja.Size = new System.Drawing.Size(161, 21);
            this.checkBoxDadosBaja.TabIndex = 13;
            this.checkBoxDadosBaja.Text = "Incluir dados de baja";
            this.checkBoxDadosBaja.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(527, 156);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(113, 39);
            this.buttonConsultar.TabIndex = 14;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // infoNombreCorto
            // 
            this.infoNombreCorto.Image = global::TP_PAVI.Properties.Resources.icons8_info_100;
            this.infoNombreCorto.Location = new System.Drawing.Point(201, 58);
            this.infoNombreCorto.Name = "infoNombreCorto";
            this.infoNombreCorto.Size = new System.Drawing.Size(28, 26);
            this.infoNombreCorto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoNombreCorto.TabIndex = 15;
            this.infoNombreCorto.TabStop = false;
            this.infoNombreCorto.MouseHover += new System.EventHandler(this.infoNombreCorto_MouseHover);
            // 
            // infoNombreLargo
            // 
            this.infoNombreLargo.Image = global::TP_PAVI.Properties.Resources.icons8_info_100;
            this.infoNombreLargo.Location = new System.Drawing.Point(201, 120);
            this.infoNombreLargo.Name = "infoNombreLargo";
            this.infoNombreLargo.Size = new System.Drawing.Size(28, 26);
            this.infoNombreLargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoNombreLargo.TabIndex = 17;
            this.infoNombreLargo.TabStop = false;
            this.infoNombreLargo.MouseHover += new System.EventHandler(this.infoNombreLargo_MouseHover);
            // 
            // textBoxNombreLargo
            // 
            this.textBoxNombreLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreLargo.Location = new System.Drawing.Point(12, 120);
            this.textBoxNombreLargo.Name = "textBoxNombreLargo";
            this.textBoxNombreLargo.Size = new System.Drawing.Size(174, 26);
            this.textBoxNombreLargo.TabIndex = 18;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(10, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(651, 25);
            this.miniToolStrip.TabIndex = 19;
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.textBoxNombreLargo);
            this.groupBoxCursos.Controls.Add(this.infoNombreLargo);
            this.groupBoxCursos.Controls.Add(this.infoNombreCorto);
            this.groupBoxCursos.Controls.Add(this.buttonConsultar);
            this.groupBoxCursos.Controls.Add(this.checkBoxDadosBaja);
            this.groupBoxCursos.Controls.Add(this.textBoxNombreCorto);
            this.groupBoxCursos.Controls.Add(this.labelNombreLargo);
            this.groupBoxCursos.Controls.Add(this.labelNombreCorto);
            this.groupBoxCursos.Controls.Add(this.dgvObjetivos);
            this.groupBoxCursos.Location = new System.Drawing.Point(17, 53);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(657, 521);
            this.groupBoxCursos.TabIndex = 8;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Filtros";
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::TP_PAVI.Properties.Resources.max;
            this.btnMax.Location = new System.Drawing.Point(620, 11);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 23);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 5;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // FormObjetivosABMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 647);
            this.Controls.Add(this.groupBoxCursos);
            this.Name = "FormObjetivosABMC";
            this.Text = "FormObjetivos";
            this.Controls.SetChildIndex(this.groupBoxCursos, 0);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombreCorto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNombreLargo)).EndInit();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.Label labelNombreCorto;
        private System.Windows.Forms.Label labelNombreLargo;
        private System.Windows.Forms.TextBox textBoxNombreCorto;
        private System.Windows.Forms.CheckBox checkBoxDadosBaja;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.PictureBox infoNombreCorto;
        private System.Windows.Forms.PictureBox infoNombreLargo;
        private System.Windows.Forms.TextBox textBoxNombreLargo;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.ToolTip toolTipNombreCorto;
        public System.Windows.Forms.ToolTip toolTipNombreLargo;
        private System.Windows.Forms.PictureBox btnMax;
    }
}