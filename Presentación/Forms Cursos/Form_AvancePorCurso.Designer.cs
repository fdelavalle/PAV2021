
namespace TP_PAVI.Presentación.Forms_Cursos
{
    partial class Form_AvancePorCurso
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
            this.pictureBoxRegresar = new System.Windows.Forms.PictureBox();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.labelCursos = new System.Windows.Forms.Label();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBoxAlumnos = new System.Windows.Forms.GroupBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.labelAvance = new System.Windows.Forms.Label();
            this.maskedTextBoxAvance = new System.Windows.Forms.MaskedTextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.groupBoxAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(643, 11);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(674, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(612, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Controls.Add(this.btnMax);
            this.panelBarraTitulo.Size = new System.Drawing.Size(711, 47);
            this.panelBarraTitulo.Controls.SetChildIndex(this.maxBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.closeBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.minBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.restoreBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.Titulo, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.btnMax, 0);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(714, 11);
            // 
            // pictureBoxRegresar
            // 
            this.pictureBoxRegresar.Image = global::TP_PAVI.Properties.Resources.salir;
            this.pictureBoxRegresar.Location = new System.Drawing.Point(599, 468);
            this.pictureBoxRegresar.Name = "pictureBoxRegresar";
            this.pictureBoxRegresar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegresar.TabIndex = 1;
            this.pictureBoxRegresar.TabStop = false;
            this.pictureBoxRegresar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxRegresar.MouseEnter += new System.EventHandler(this.pictureBoxRegresar_MouseEnter);
            this.pictureBoxRegresar.MouseLeave += new System.EventHandler(this.pictureBoxRegresar_MouseLeave);
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(35, 115);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(190, 28);
            this.comboBoxCursos.TabIndex = 2;
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.Location = new System.Drawing.Point(31, 92);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(63, 20);
            this.labelCursos.TabIndex = 3;
            this.labelCursos.Text = "Cursos";
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.ReadOnly = true;
            this.dataGridViewAlumnos.RowHeadersWidth = 51;
            this.dataGridViewAlumnos.RowTemplate.Height = 24;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(657, 252);
            this.dataGridViewAlumnos.TabIndex = 4;
            // 
            // groupBoxAlumnos
            // 
            this.groupBoxAlumnos.Controls.Add(this.dataGridViewAlumnos);
            this.groupBoxAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAlumnos.Location = new System.Drawing.Point(35, 149);
            this.groupBoxAlumnos.Name = "groupBoxAlumnos";
            this.groupBoxAlumnos.Size = new System.Drawing.Size(669, 283);
            this.groupBoxAlumnos.TabIndex = 5;
            this.groupBoxAlumnos.TabStop = false;
            this.groupBoxAlumnos.Text = "Alumnos";
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(41, 438);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(234, 21);
            this.checkBoxTodos.TabIndex = 6;
            this.checkBoxTodos.Text = "Seleccionar a todos los alumnos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // labelAvance
            // 
            this.labelAvance.AutoSize = true;
            this.labelAvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvance.Location = new System.Drawing.Point(85, 474);
            this.labelAvance.Name = "labelAvance";
            this.labelAvance.Size = new System.Drawing.Size(64, 20);
            this.labelAvance.TabIndex = 7;
            this.labelAvance.Text = "Avance";
            // 
            // maskedTextBoxAvance
            // 
            this.maskedTextBoxAvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxAvance.Location = new System.Drawing.Point(41, 468);
            this.maskedTextBoxAvance.Mask = "000";
            this.maskedTextBoxAvance.Name = "maskedTextBoxAvance";
            this.maskedTextBoxAvance.Size = new System.Drawing.Size(38, 28);
            this.maskedTextBoxAvance.TabIndex = 8;
            this.maskedTextBoxAvance.ValidatingType = typeof(int);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(295, 459);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(120, 35);
            this.buttonConfirmar.TabIndex = 9;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(231, 115);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(104, 28);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::TP_PAVI.Properties.Resources.max;
            this.btnMax.Location = new System.Drawing.Point(643, 11);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 23);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 5;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // Form_AvancePorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 530);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.maskedTextBoxAvance);
            this.Controls.Add(this.labelAvance);
            this.Controls.Add(this.checkBoxTodos);
            this.Controls.Add(this.groupBoxAlumnos);
            this.Controls.Add(this.labelCursos);
            this.Controls.Add(this.comboBoxCursos);
            this.Controls.Add(this.pictureBoxRegresar);
            this.Name = "Form_AvancePorCurso";
            this.Text = "Form_AvancePorCurso";
            this.Load += new System.EventHandler(this.Form_AvancePorCurso_Load);
            this.Controls.SetChildIndex(this.pictureBoxRegresar, 0);
            this.Controls.SetChildIndex(this.comboBoxCursos, 0);
            this.Controls.SetChildIndex(this.labelCursos, 0);
            this.Controls.SetChildIndex(this.groupBoxAlumnos, 0);
            this.Controls.SetChildIndex(this.checkBoxTodos, 0);
            this.Controls.SetChildIndex(this.labelAvance, 0);
            this.Controls.SetChildIndex(this.maskedTextBoxAvance, 0);
            this.Controls.SetChildIndex(this.buttonConfirmar, 0);
            this.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.groupBoxAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRegresar;
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.GroupBox groupBoxAlumnos;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.Label labelAvance;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAvance;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.PictureBox btnMax;
    }
}