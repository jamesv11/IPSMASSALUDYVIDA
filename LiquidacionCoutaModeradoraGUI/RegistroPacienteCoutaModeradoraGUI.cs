using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace LiquidacionCoutaModeradoraGUI
{
    public partial class RegistroPacienteCoutaModeradoraGUI : Form
    {
        public RegistroPacienteCoutaModeradoraGUI()
        {
            InitializeComponent();
        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            string mensaje;
            try
            {
                
                LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();
                LiquidacionCuotaModeradora liquidacionCuotaModeradora;

                liquidacionCuotaModeradora = liquidacionCoutaModeradoraService.CreacionLiquidacionModeradora(
                    NumeroLiquidacionTxt.Text, IdentificacionTxt.Text, TipoAfilicacionCmb.Text,
                    Convert.ToDecimal(SalarioTxt.Text), Convert.ToDecimal(ValorServicioTxt.Text), FechaDtp.Value, NombreTxt.Text
                    );

                liquidacionCuotaModeradora.AplicacionTarifayTopeMaximo();
                liquidacionCuotaModeradora.CalculoCoutaModeradora();
                mensaje = liquidacionCoutaModeradoraService.Guardar(liquidacionCuotaModeradora);
                MessageBox.Show(mensaje);
                LimpiarCampos();
            }
            catch (Exception excepcion)
            {

                mensaje = $"Por favor rellenar todos los campos {excepcion.Message}";
                MessageBox.Show(mensaje);
            }
                
           
            
            
        }
        public void LimpiarCampos()
        {
            NumeroLiquidacionTxt.Clear();
            IdentificacionTxt.Clear();
            SalarioTxt.Clear();
            ValorServicioTxt.Clear();
            TipoAfilicacionCmb.Text = null;
            ValorServicioTxt.Clear();
            NombreTxt.Clear();
                
        }

        private void TipoAfilicacionCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
