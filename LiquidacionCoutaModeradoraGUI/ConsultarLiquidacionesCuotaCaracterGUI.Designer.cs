namespace LiquidacionCoutaModeradoraGUI
{
    partial class ConsultarLiquidacionesCuotaCaracterGUI
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
            this.TablaDgv = new System.Windows.Forms.DataGridView();
            this.BuscarTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.BuscarBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BuscarTxt);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 102);
            this.panel1.TabIndex = 0;
            // 
            // TablaDgv
            // 
            this.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDgv.Location = new System.Drawing.Point(99, 140);
            this.TablaDgv.Name = "TablaDgv";
            this.TablaDgv.Size = new System.Drawing.Size(631, 201);
            this.TablaDgv.TabIndex = 1;
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(336, 40);
            this.BuscarTxt.Name = "BuscarTxt";
            this.BuscarTxt.Size = new System.Drawing.Size(100, 20);
            this.BuscarTxt.TabIndex = 0;
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
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Image = global::LiquidacionCoutaModeradoraGUI.Properties.Resources.searchzoomregular_106304;
            this.BuscarBtn.Location = new System.Drawing.Point(468, 22);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 55);
            this.BuscarBtn.TabIndex = 2;
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // ConsultarLiquidacionesCuotaCaracterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(191)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.TablaDgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarLiquidacionesCuotaCaracterGUI";
            this.Text = "ConsultarLiquidacionesCuotaModeradoraCaracter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscarTxt;
        private System.Windows.Forms.DataGridView TablaDgv;
    }
}