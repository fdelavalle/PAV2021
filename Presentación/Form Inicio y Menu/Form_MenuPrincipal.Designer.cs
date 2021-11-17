
namespace TP_PAVI.Presentación
{
    partial class Form_MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónAvancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónObjetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónDeObjetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesCursosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAvancePromedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(732, 12);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(763, 11);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(701, 11);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnMax);
            this.panelBarraTitulo.Size = new System.Drawing.Size(800, 47);
            this.panelBarraTitulo.Controls.SetChildIndex(this.btnMax, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.maxBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.closeBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.minBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.restoreBtn, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.Titulo, 0);
            this.panelBarraTitulo.Controls.SetChildIndex(this.btnMaximizar, 0);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(1372, 11);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.objetivosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeCursosToolStripMenuItem,
            this.actualizaciónAvancesToolStripMenuItem,
            this.actualizaciónObjetivosToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // gestiónDeCursosToolStripMenuItem
            // 
            this.gestiónDeCursosToolStripMenuItem.Name = "gestiónDeCursosToolStripMenuItem";
            this.gestiónDeCursosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.gestiónDeCursosToolStripMenuItem.Text = "Gestión de Cursos";
            this.gestiónDeCursosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeCursosToolStripMenuItem_Click);
            // 
            // actualizaciónAvancesToolStripMenuItem
            // 
            this.actualizaciónAvancesToolStripMenuItem.Name = "actualizaciónAvancesToolStripMenuItem";
            this.actualizaciónAvancesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.actualizaciónAvancesToolStripMenuItem.Text = "Actualización avances";
            this.actualizaciónAvancesToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónAvancesToolStripMenuItem_Click);
            // 
            // actualizaciónObjetivosToolStripMenuItem
            // 
            this.actualizaciónObjetivosToolStripMenuItem.Name = "actualizaciónObjetivosToolStripMenuItem";
            this.actualizaciónObjetivosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.actualizaciónObjetivosToolStripMenuItem.Text = "Actualización objetivos";
            this.actualizaciónObjetivosToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónObjetivosToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeCategoríasToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // gestiónDeCategoríasToolStripMenuItem
            // 
            this.gestiónDeCategoríasToolStripMenuItem.Name = "gestiónDeCategoríasToolStripMenuItem";
            this.gestiónDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.gestiónDeCategoríasToolStripMenuItem.Text = "Gestión de Categorías";
            this.gestiónDeCategoríasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeCategoríasToolStripMenuItem_Click);
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizaciónDeObjetivosToolStripMenuItem});
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            // 
            // actualizaciónDeObjetivosToolStripMenuItem
            // 
            this.actualizaciónDeObjetivosToolStripMenuItem.Name = "actualizaciónDeObjetivosToolStripMenuItem";
            this.actualizaciónDeObjetivosToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.actualizaciónDeObjetivosToolStripMenuItem.Text = "Gestión de Objetivos";
            this.actualizaciónDeObjetivosToolStripMenuItem.Click += new System.EventHandler(this.actualizaciónDeObjetivosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesCursosUsuariosToolStripMenuItem,
            this.reporteAvancePromedioToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesCursosUsuariosToolStripMenuItem
            // 
            this.reportesCursosUsuariosToolStripMenuItem.Name = "reportesCursosUsuariosToolStripMenuItem";
            this.reportesCursosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.reportesCursosUsuariosToolStripMenuItem.Text = "Reporte Cantidad Usuarios Curso";
            this.reportesCursosUsuariosToolStripMenuItem.Click += new System.EventHandler(this.reportesCursosUsuariosToolStripMenuItem_Click);
            // 
            // reporteAvancePromedioToolStripMenuItem
            // 
            this.reporteAvancePromedioToolStripMenuItem.Name = "reporteAvancePromedioToolStripMenuItem";
            this.reporteAvancePromedioToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.reporteAvancePromedioToolStripMenuItem.Text = "Reporte Avance Promedio";
            this.reporteAvancePromedioToolStripMenuItem.Click += new System.EventHandler(this.reporteAvancePromedioToolStripMenuItem_Click);
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Location = new System.Drawing.Point(732, 11);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 5;
            this.btnMax.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::TP_PAVI.Properties.Resources.max;
            this.btnMaximizar.Location = new System.Drawing.Point(732, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 22);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_PAVI.Properties.Resources.a3ea4c90a81a5713113fd42e20bb312f_diseno_de_logo_de_e_learning;
            this.pictureBox1.Location = new System.Drawing.Point(-52, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(866, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_MenuPrincipal";
            this.Text = "Form_MenuPrincipal";
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónAvancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónDeObjetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesCursosUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.ToolStripMenuItem reporteAvancePromedioToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónObjetivosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}