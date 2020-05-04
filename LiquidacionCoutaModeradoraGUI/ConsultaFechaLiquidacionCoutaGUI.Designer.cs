namespace LiquidacionCoutaModeradoraGUI
{
    partial class ConsultaFechaLiquidacionCoutaGUI
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
            this.FechaDtp = new System.Windows.Forms.DateTimePicker();
            this.TablaDgv = new System.Windows.Forms.DataGridView();
            this.BuscatTxt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.BuscatTxt);
            this.panel1.Controls.Add(this.FechaDtp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 102);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha ";
            // 
            // FechaDtp
            // 
            this.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDtp.Location = new System.Drawing.Point(265, 42);
            this.FechaDtp.Name = "FechaDtp";
            this.FechaDtp.Size = new System.Drawing.Size(106, 20);
            this.FechaDtp.TabIndex = 1;
            this.FechaDtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TablaDgv
            // 
            this.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDgv.Location = new System.Drawing.Point(86, 130);
            this.TablaDgv.Name = "TablaDgv";
            this.TablaDgv.Size = new System.Drawing.Size(601, 172);
            this.TablaDgv.TabIndex = 1;
            // 
            // BuscatTxt
            // 
            this.BuscatTxt.Location = new System.Drawing.Point(417, 42);
            this.BuscatTxt.Name = "BuscatTxt";
            this.BuscatTxt.Size = new System.Drawing.Size(75, 23);
            this.BuscatTxt.TabIndex = 2;
            this.BuscatTxt.Text = "button1";
            this.BuscatTxt.UseVisualStyleBackColor = true;
            // 
            // ConsultaFechaLiquidacionCoutaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(191)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.TablaDgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultaFechaLiquidacionCoutaGUI";
            this.Text = "ConsultaFechaLiquidacionCoutaGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker FechaDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscatTxt;
        private System.Windows.Forms.DataGridView TablaDgv;
    }
}