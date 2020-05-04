namespace LiquidacionCoutaModeradoraGUI
{
    partial class PrincipalForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLiquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorTipoDeLiquidacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasEspecificasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultarPorCaracterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(42)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultasGeneralesToolStripMenuItem,
            this.consultasEspecificasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // consultasGeneralesToolStripMenuItem
            // 
            this.consultasGeneralesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLiquidacionesToolStripMenuItem,
            this.consultarPorTipoDeLiquidacionToolStripMenuItem});
            this.consultasGeneralesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasGeneralesToolStripMenuItem.Name = "consultasGeneralesToolStripMenuItem";
            this.consultasGeneralesToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.consultasGeneralesToolStripMenuItem.Text = "ConsultasGenerales";
            this.consultasGeneralesToolStripMenuItem.Click += new System.EventHandler(this.consultasGeneralesToolStripMenuItem_Click);
            // 
            // consultarLiquidacionesToolStripMenuItem
            // 
            this.consultarLiquidacionesToolStripMenuItem.Name = "consultarLiquidacionesToolStripMenuItem";
            this.consultarLiquidacionesToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
            this.consultarLiquidacionesToolStripMenuItem.Text = "Consultar liquidaciones";
            this.consultarLiquidacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarLiquidacionesToolStripMenuItem_Click);
            // 
            // consultarPorTipoDeLiquidacionToolStripMenuItem
            // 
            this.consultarPorTipoDeLiquidacionToolStripMenuItem.Name = "consultarPorTipoDeLiquidacionToolStripMenuItem";
            this.consultarPorTipoDeLiquidacionToolStripMenuItem.Size = new System.Drawing.Size(306, 24);
            this.consultarPorTipoDeLiquidacionToolStripMenuItem.Text = "Consultar por tipo de liquidacion";
            this.consultarPorTipoDeLiquidacionToolStripMenuItem.Click += new System.EventHandler(this.consultarPorTipoDeLiquidacionToolStripMenuItem_Click);
            // 
            // consultasEspecificasToolStripMenuItem
            // 
            this.consultasEspecificasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPorCaracterToolStripMenuItem,
            this.consultarPorFechaToolStripMenuItem});
            this.consultasEspecificasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasEspecificasToolStripMenuItem.Name = "consultasEspecificasToolStripMenuItem";
            this.consultasEspecificasToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.consultasEspecificasToolStripMenuItem.Text = "ConsultasEspecificas";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // consultarPorCaracterToolStripMenuItem
            // 
            this.consultarPorCaracterToolStripMenuItem.Name = "consultarPorCaracterToolStripMenuItem";
            this.consultarPorCaracterToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.consultarPorCaracterToolStripMenuItem.Text = "Consultar por caracter";
            this.consultarPorCaracterToolStripMenuItem.Click += new System.EventHandler(this.consultarPorCaracterToolStripMenuItem_Click);
            // 
            // consultarPorFechaToolStripMenuItem
            // 
            this.consultarPorFechaToolStripMenuItem.Name = "consultarPorFechaToolStripMenuItem";
            this.consultarPorFechaToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.consultarPorFechaToolStripMenuItem.Text = "Consultar por fecha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LiquidacionCoutaModeradoraGUI.Properties.Resources.IpsName;
            this.pictureBox2.Location = new System.Drawing.Point(229, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 140);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LiquidacionCoutaModeradoraGUI.Properties.Resources.hospital_icon_icons_com_54428;
            this.pictureBox1.Location = new System.Drawing.Point(362, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 115);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(191)))), ((int)(((byte)(126)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPS-Mas salud y vida";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasEspecificasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem consultarLiquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorTipoDeLiquidacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorCaracterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorFechaToolStripMenuItem;
    }
}

