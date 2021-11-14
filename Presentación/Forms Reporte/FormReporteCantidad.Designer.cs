
namespace TP_PAVI.Presentación.Forms_Reporte
{
    partial class FormReporteCantidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteCantidad));
            this.rpvCursos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFechaDesde1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerar1 = new System.Windows.Forms.Button();
            this.txtFechaHasta1 = new System.Windows.Forms.MaskedTextBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(873, 10);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(904, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(842, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Size = new System.Drawing.Size(941, 46);
            this.panelBarraTitulo.Controls.SetChildIndex(this.maxBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.closeBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.minBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.restoreBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.Titulo, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.btnMaximizar, 0);
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(15, 9);
            this.Titulo.Size = new System.Drawing.Size(115, 29);
            this.Titulo.Text = "Reportes";
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(2683, 11);
            // 
            // rpvCursos
            // 
            this.rpvCursos.LocalReport.ReportEmbeddedResource = "TP_PAVI.Presentación.Reportes.ReportCursos.rdlc";
            this.rpvCursos.Location = new System.Drawing.Point(15, 97);
            this.rpvCursos.Name = "rpvCursos";
            this.rpvCursos.ServerReport.BearerToken = null;
            this.rpvCursos.Size = new System.Drawing.Size(914, 479);
            this.rpvCursos.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(874, 582);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtFechaDesde1
            // 
            this.txtFechaDesde1.Location = new System.Drawing.Point(117, 66);
            this.txtFechaDesde1.Mask = "0000/00/00";
            this.txtFechaDesde1.Name = "txtFechaDesde1";
            this.txtFechaDesde1.Size = new System.Drawing.Size(237, 22);
            this.txtFechaDesde1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha hasta:";
            // 
            // btnGenerar1
            // 
            this.btnGenerar1.Location = new System.Drawing.Point(842, 63);
            this.btnGenerar1.Name = "btnGenerar1";
            this.btnGenerar1.Size = new System.Drawing.Size(87, 28);
            this.btnGenerar1.TabIndex = 11;
            this.btnGenerar1.Text = "Generar";
            this.btnGenerar1.UseVisualStyleBackColor = true;
            this.btnGenerar1.Click += new System.EventHandler(this.btnGenerar1_Click);
            // 
            // txtFechaHasta1
            // 
            this.txtFechaHasta1.Location = new System.Drawing.Point(472, 66);
            this.txtFechaHasta1.Mask = "0000/00/00";
            this.txtFechaHasta1.Name = "txtFechaHasta1";
            this.txtFechaHasta1.Size = new System.Drawing.Size(237, 22);
            this.txtFechaHasta1.TabIndex = 12;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(874, 11);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 638);
            this.Controls.Add(this.txtFechaHasta1);
            this.Controls.Add(this.btnGenerar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaDesde1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rpvCursos);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.Controls.SetChildIndex(this.rpvCursos, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtFechaDesde1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnGenerar1, 0);
            this.Controls.SetChildIndex(this.txtFechaHasta1, 0);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rpvCursos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerar1;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta1;
        private System.Windows.Forms.PictureBox btnMaximizar;
    }
}