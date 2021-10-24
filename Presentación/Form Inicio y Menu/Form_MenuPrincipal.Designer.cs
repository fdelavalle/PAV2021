
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónAvancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónDeObjetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(732, 11);
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(800, 47);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(732, 11);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.objetivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeCursosToolStripMenuItem,
            this.actualizaciónAvancesToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // gestiónDeCursosToolStripMenuItem
            // 
            this.gestiónDeCursosToolStripMenuItem.Name = "gestiónDeCursosToolStripMenuItem";
            this.gestiónDeCursosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.gestiónDeCursosToolStripMenuItem.Text = "Gestión de Cursos";
            this.gestiónDeCursosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeCursosToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeCategoríasToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizaciónDeObjetivosToolStripMenuItem});
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            // 
            // gestiónDeCategoríasToolStripMenuItem
            // 
            this.gestiónDeCategoríasToolStripMenuItem.Name = "gestiónDeCategoríasToolStripMenuItem";
            this.gestiónDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.gestiónDeCategoríasToolStripMenuItem.Text = "Gestión de Categorías";
            // 
            // actualizaciónAvancesToolStripMenuItem
            // 
            this.actualizaciónAvancesToolStripMenuItem.Name = "actualizaciónAvancesToolStripMenuItem";
            this.actualizaciónAvancesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.actualizaciónAvancesToolStripMenuItem.Text = "Actualización avances";
            // 
            // actualizaciónDeObjetivosToolStripMenuItem
            // 
            this.actualizaciónDeObjetivosToolStripMenuItem.Name = "actualizaciónDeObjetivosToolStripMenuItem";
            this.actualizaciónDeObjetivosToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.actualizaciónDeObjetivosToolStripMenuItem.Text = "Actualización de Objetivos";
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_MenuPrincipal";
            this.Text = "Form_MenuPrincipal";
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.panelBarraTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}