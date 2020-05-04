namespace LiquidacionCoutaModeradoraGUI
{
    partial class Consultar_liquidaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_liquidaciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TablaDgv = new System.Windows.Forms.DataGridView();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ConsultarBtn);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 102);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(42)))));
            this.panel2.Location = new System.Drawing.Point(3, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 17);
            this.panel2.TabIndex = 1;
            // 
            // TablaDgv
            // 
            this.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TablaDgv.Location = new System.Drawing.Point(111, 118);
            this.TablaDgv.Name = "TablaDgv";
            this.TablaDgv.Size = new System.Drawing.Size(620, 220);
            this.TablaDgv.TabIndex = 1;
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Enabled = false;
            this.CantidadTxt.Location = new System.Drawing.Point(385, 344);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(100, 20);
            this.CantidadTxt.TabIndex = 2;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.ForeColor = System.Drawing.Color.Black;
            this.ConsultarBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarBtn.Image")));
            this.ConsultarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConsultarBtn.Location = new System.Drawing.Point(385, 12);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 67);
            this.ConsultarBtn.TabIndex = 0;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // Consultar_liquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(191)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.TablaDgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Consultar_liquidaciones";
            this.Text = "Consultar_liquidaciones";
            this.Load += new System.EventHandler(this.Consultar_liquidaciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView TablaDgv;
        private System.Windows.Forms.TextBox CantidadTxt;
    }
}