using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiquidacionCoutaModeradoraGUI
{
    public partial class PrincipalForm : Form
    {
        int control = 0;
        public PrincipalForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            
                RegistroPacienteCoutaModeradoraGUI registroPacienteCoutaModeradoraGUI = new RegistroPacienteCoutaModeradoraGUI();

                registroPacienteCoutaModeradoraGUI.Show();
                
            
        }

        private void consultasGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_liquidaciones consultar_Liquidaciones = new Consultar_liquidaciones();
            consultar_Liquidaciones.Show();
        }

        private void consultarPorTipoDeLiquidacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLiquidacionesTipoGUI consultarLiquidacionesTipoGUI = new ConsultarLiquidacionesTipoGUI();
            consultarLiquidacionesTipoGUI.Show();
        }

        private void consultarPorCaracterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLiquidacionesCuotaCaracterGUI consultarLiquidacionesCuotaCaracterGUI = new ConsultarLiquidacionesCuotaCaracterGUI();
            consultarLiquidacionesCuotaCaracterGUI.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCoutaModeradoraGUI eliminarCoutaModeradoraGUI = new EliminarCoutaModeradoraGUI();
            eliminarCoutaModeradoraGUI.Show();
        }

        private void consultarPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFechaLiquidacionCoutaGUI consultaFechaLiquidacionCoutaGUI = new ConsultaFechaLiquidacionCoutaGUI();

            consultaFechaLiquidacionCoutaGUI.Show();
        }
    }
}
