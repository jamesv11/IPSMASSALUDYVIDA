namespace LiquidacionCoutaModeradoraGUI
{
    partial class ConsultarLiquidacionesTipoGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoCoutaCmb = new System.Windows.Forms.ComboBox();
            this.TablaDtv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorTotalTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDtv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.BuscarBtn);
            this.panel1.Controls.Add(this.TipoCoutaCmb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 102);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TipoCoutaCmb
            // 
            this.TipoCoutaCmb.FormattingEnabled = true;
            this.TipoCoutaCmb.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo"});
            this.TipoCoutaCmb.Location = new System.Drawing.Point(354, 40);
            this.TipoCoutaCmb.Name = "TipoCoutaCmb";
            this.TipoCoutaCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoCoutaCmb.TabIndex = 2;
            this.TipoCoutaCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoCoutaCmb_KeyPress);
            // 
            // TablaDtv
            // 
            this.TablaDtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDtv.Location = new System.Drawing.Point(237, 118);
            this.TablaDtv.Name = "TablaDtv";
            this.TablaDtv.Size = new System.Drawing.Size(361, 150);
            this.TablaDtv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ValorTotal";
            // 
            // ValorTotalTxt
            // 
            this.ValorTotalTxt.Enabled = false;
            this.ValorTotalTxt.Location = new System.Drawing.Point(88, 48);
            this.ValorTotalTxt.Name = "ValorTotalTxt";
            this.ValorTotalTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorTotalTxt.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(230)))), ((int)(((byte)(151)))));
            this.panel2.Controls.Add(this.CantidadTxt);
            this.panel2.Controls.Add(this.ValorTotalTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(326, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 86);
            this.panel2.TabIndex = 6;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Image = global::LiquidacionCoutaModeradoraGUI.Properties.Resources.searchzoomregular_106304;
            this.BuscarBtn.Location = new System.Drawing.Point(496, 20);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 59);
            this.BuscarBtn.TabIndex = 3;
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Enabled = false;
            this.CantidadTxt.Location = new System.Drawing.Point(88, 17);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(100, 20);
            this.CantidadTxt.TabIndex = 6;
            // 
            // ConsultarLiquidacionesTipoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(191)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TablaDtv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarLiquidacionesTipoGUI";
            this.Text = "ConsultarLiquidacionesTipoGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDtv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TipoCoutaCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.DataGridView TablaDtv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValorTotalTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CantidadTxt;
    }
}