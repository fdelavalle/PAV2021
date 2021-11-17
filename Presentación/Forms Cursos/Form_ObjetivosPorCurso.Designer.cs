
namespace TP_PAVI.Presentación.Forms_Cursos
{
    partial class Form_ObjetivosPorCurso
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
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.labelCursos = new System.Windows.Forms.Label();
            this.dataGridViewObjetivosCurso = new System.Windows.Forms.DataGridView();
            this.dataGridViewObjetivos = new System.Windows.Forms.DataGridView();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.PictureBox();
            this.groupBoxObjetivos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetivosCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetivos)).BeginInit();
            this.groupBoxCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitar)).BeginInit();
            this.groupBoxObjetivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(632, 11);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(663, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(601, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Size = new System.Drawing.Size(700, 47);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(632, 11);
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(44, 100);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(179, 24);
            this.comboBoxCursos.TabIndex = 1;
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.Location = new System.Drawing.Point(41, 80);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(52, 17);
            this.labelCursos.TabIndex = 2;
            this.labelCursos.Text = "Cursos";
            // 
            // dataGridViewObjetivosCurso
            // 
            this.dataGridViewObjetivosCurso.AllowUserToAddRows = false;
            this.dataGridViewObjetivosCurso.AllowUserToDeleteRows = false;
            this.dataGridViewObjetivosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjetivosCurso.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewObjetivosCurso.Name = "dataGridViewObjetivosCurso";
            this.dataGridViewObjetivosCurso.ReadOnly = true;
            this.dataGridViewObjetivosCurso.RowHeadersWidth = 51;
            this.dataGridViewObjetivosCurso.RowTemplate.Height = 24;
            this.dataGridViewObjetivosCurso.Size = new System.Drawing.Size(296, 199);
            this.dataGridViewObjetivosCurso.TabIndex = 3;
            // 
            // dataGridViewObjetivos
            // 
            this.dataGridViewObjetivos.AllowUserToAddRows = false;
            this.dataGridViewObjetivos.AllowUserToDeleteRows = false;
            this.dataGridViewObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjetivos.Location = new System.Drawing.Point(16, 21);
            this.dataGridViewObjetivos.Name = "dataGridViewObjetivos";
            this.dataGridViewObjetivos.ReadOnly = true;
            this.dataGridViewObjetivos.RowHeadersWidth = 51;
            this.dataGridViewObjetivos.RowTemplate.Height = 24;
            this.dataGridViewObjetivos.Size = new System.Drawing.Size(309, 199);
            this.dataGridViewObjetivos.TabIndex = 4;
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.btnQuitar);
            this.groupBoxCursos.Controls.Add(this.dataGridViewObjetivosCurso);
            this.groupBoxCursos.Location = new System.Drawing.Point(44, 130);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(308, 289);
            this.groupBoxCursos.TabIndex = 5;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Objetivos del curso";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::TP_PAVI.Properties.Resources.minus;
            this.btnQuitar.Location = new System.Drawing.Point(7, 227);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 50);
            this.btnQuitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.TabStop = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // groupBoxObjetivos
            // 
            this.groupBoxObjetivos.Controls.Add(this.btnAgregar);
            this.groupBoxObjetivos.Controls.Add(this.dataGridViewObjetivos);
            this.groupBoxObjetivos.Location = new System.Drawing.Point(358, 130);
            this.groupBoxObjetivos.Name = "groupBoxObjetivos";
            this.groupBoxObjetivos.Size = new System.Drawing.Size(331, 289);
            this.groupBoxObjetivos.TabIndex = 6;
            this.groupBoxObjetivos.TabStop = false;
            this.groupBoxObjetivos.Text = "Todos los objetivos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::TP_PAVI.Properties.Resources.plus;
            this.btnAgregar.Location = new System.Drawing.Point(16, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 50);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TP_PAVI.Properties.Resources.salir;
            this.pictureBox3.Location = new System.Drawing.Point(588, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(230, 100);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(82, 24);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // Form_ObjetivosPorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 489);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBoxObjetivos);
            this.Controls.Add(this.groupBoxCursos);
            this.Controls.Add(this.labelCursos);
            this.Controls.Add(this.comboBoxCursos);
            this.Name = "Form_ObjetivosPorCurso";
            this.Text = "Form_ObjetivosPorCurso";
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.comboBoxCursos, 0);
            this.Controls.SetChildIndex(this.labelCursos, 0);
            this.Controls.SetChildIndex(this.groupBoxCursos, 0);
            this.Controls.SetChildIndex(this.groupBoxObjetivos, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.buttonAceptar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetivosCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetivos)).EndInit();
            this.groupBoxCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuitar)).EndInit();
            this.groupBoxObjetivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.DataGridView dataGridViewObjetivosCurso;
        private System.Windows.Forms.DataGridView dataGridViewObjetivos;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.PictureBox btnQuitar;
        private System.Windows.Forms.GroupBox groupBoxObjetivos;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonAceptar;
    }
}