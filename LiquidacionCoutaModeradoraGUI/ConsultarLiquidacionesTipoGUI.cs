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
    public partial class ConsultarLiquidacionesTipoGUI : Form
    {
        public ConsultarLiquidacionesTipoGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();
            RespuestaConsulta respuestaConsulta;
            liquidacionCoutaModeradoraService.Consultar();
            string mensaje;
            try
            {
                

                if (TipoCoutaCmb.Text.Equals("Subsidiado"))
                {
                    
                    TablaDtv.DataSource = null;
                    respuestaConsulta = liquidacionCoutaModeradoraService.ObtenerCoutasModeradorasSubsidiadas();
                    TablaDtv.DataSource = respuestaConsulta.liquidacionCuotaModeradoras;
                    CantidadTxt.Text = liquidacionCoutaModeradoraService.ObtenerCantidadCoutaModeradoraSubsidiado().ToString();
                    ValorTotalTxt.Text = liquidacionCoutaModeradoraService.ObtenerValorTotalCoutaSubsidiadas(respuestaConsulta.liquidacionCuotaModeradoras).ToString();
                    
                }
                else
                {
                    
                    TablaDtv.DataSource = null;
                    respuestaConsulta = liquidacionCoutaModeradoraService.ObtenerCoutasModeradorasContributivas();
                    TablaDtv.DataSource = respuestaConsulta.liquidacionCuotaModeradoras;
                    CantidadTxt.Text = liquidacionCoutaModeradoraService.ObtenerCantidadCoutaModeradoraContributivo().ToString();
                    ValorTotalTxt.Text = liquidacionCoutaModeradoraService.ObtenerValorTotalCoutaContributivas(respuestaConsulta.liquidacionCuotaModeradoras).ToString();
                    mensaje = respuestaConsulta.Mensaje;
                    MessageBox.Show(mensaje);
                }
                

                
            }
            catch (Exception)
            {

                mensaje = "No se ha podido realizar la consulta";
                MessageBox.Show(mensaje);
            }
            



        }

        private void TipoCoutaCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
