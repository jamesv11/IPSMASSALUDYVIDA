using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace LiquidacionCoutaModeradoraGUI
{
    public partial class Consultar_liquidaciones : Form
    {
        public Consultar_liquidaciones()
        {
            InitializeComponent();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();

            TablaDgv.DataSource = null;
            respuestaConsulta = liquidacionCoutaModeradoraService.Consultar();
            TablaDgv.DataSource = respuestaConsulta.liquidacionCuotaModeradoras;
            CantidadTxt.Text = liquidacionCoutaModeradoraService.ObtenerCantidadTotalCoutasModeradoras().ToString();
            MessageBox.Show(respuestaConsulta.Mensaje);
        }

        private void Consultar_liquidaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
