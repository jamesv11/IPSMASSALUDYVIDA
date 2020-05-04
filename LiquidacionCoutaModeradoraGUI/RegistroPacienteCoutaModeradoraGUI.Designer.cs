namespace LiquidacionCoutaModeradoraGUI
{
    partial class RegistroPacienteCoutaModeradoraGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPacienteCoutaModeradoraGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TipoAfilicacionCmb = new System.Windows.Forms.ComboBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.SalarioTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.FechaDtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.TipoAfilicacionCmb);
            this.panel1.Controls.Add(this.GuardarBtn);
            this.panel1.Controls.Add(this.ValorServicioTxt);
            this.panel1.Controls.Add(this.SalarioTxt);
            this.panel1.Controls.Add(this.NombreTxt);
            this.panel1.Controls.Add(this.IdentificacionTxt);
            this.panel1.Controls.Add(this.NumeroLiquidacionTxt);
            this.panel1.Controls.Add(this.FechaDtp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NombreLbl);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 379);
            this.panel1.TabIndex = 0;
            // 
            // TipoAfilicacionCmb
            // 
            this.TipoAfilicacionCmb.FormattingEnabled = true;
            this.TipoAfilicacionCmb.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo"});
            this.TipoAfilicacionCmb.Location = new System.Drawing.Point(195, 156);
            this.TipoAfilicacionCmb.Name = "TipoAfilicacionCmb";
            this.TipoAfilicacionCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoAfilicacionCmb.TabIndex = 15;
            this.TipoAfilicacionCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoAfilicacionCmb_KeyPress);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBtn.Image")));
            this.GuardarBtn.Location = new System.Drawing.Point(148, 306);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(57, 42);
            this.GuardarBtn.TabIndex = 14;
            this.GuardarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(195, 228);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorServicioTxt.TabIndex = 13;
            // 
            // SalarioTxt
            // 
            this.SalarioTxt.Location = new System.Drawing.Point(195, 193);
            this.SalarioTxt.Name = "SalarioTxt";
            this.SalarioTxt.Size = new System.Drawing.Size(100, 20);
            this.SalarioTxt.TabIndex = 12;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(195, 123);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreTxt.TabIndex = 10;
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(195, 88);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(100, 20);
            this.IdentificacionTxt.TabIndex = 9;
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(195, 53);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(100, 20);
            this.NumeroLiquidacionTxt.TabIndex = 8;
            // 
            // FechaDtp
            // 
            this.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDtp.Location = new System.Drawing.Point(195, 268);
            this.FechaDtp.Name = "FechaDtp";
            this.FechaDtp.Size = new System.Drawing.Size(100, 20);
            this.FechaDtp.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor del servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Afiliacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion ";
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLbl.Location = new System.Drawing.Point(63, 52);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(103, 18);
            this.NombreLbl.TabIndex = 0;
            this.NombreLbl.Text = "N° Liquidacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 144);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroPacienteCoutaModeradoraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(191)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistroPacienteCoutaModeradoraGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPacienteCoutaModeradoraGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.TextBox SalarioTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.DateTimePicker FechaDtp;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox TipoAfilicacionCmb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}