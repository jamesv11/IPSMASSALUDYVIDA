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
    public partial class ConsultarLiquidacionesCuotaCaracterGUI : Form
    {
        public ConsultarLiquidacionesCuotaCaracterGUI()
        {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {

            LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();
            string mensaje;
            try
            {
                
                if (BuscarTxt.Text != null)
                {
                    RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
                    liquidacionCoutaModeradoraService.Consultar();
                    string caracter = BuscarTxt.Text;
                    respuestaConsulta = liquidacionCoutaModeradoraService.ObtenerNombresFiltrados(caracter);
                    TablaDgv.DataSource = null;
                    TablaDgv.DataSource = respuestaConsulta.liquidacionCuotaModeradoras;
                    mensaje = respuestaConsulta.Mensaje;
                    MessageBox.Show(mensaje);
                }
                else
                {
                    mensaje = "Por favor llenar el espacio";
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
