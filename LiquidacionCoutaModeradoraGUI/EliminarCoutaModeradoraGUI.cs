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
    
    public partial class EliminarCoutaModeradoraGUI : Form
    {
        public EliminarCoutaModeradoraGUI()
        {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            RespuestaBusqueda respuestaBusqueda;
            LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();
            liquidacionCoutaModeradoraService.Consultar();
            LimpiarCampos();
            

            try
            {
                string buscar;
                buscar = BuscarTxt.Text;
                respuestaBusqueda = liquidacionCoutaModeradoraService.Buscar(buscar);
                NumeroLiquidacionTxt.Text = respuestaBusqueda.liquidacionCuotaModeradora.NumeroLiquidacion;
                IdentificacionTxt.Text = respuestaBusqueda.liquidacionCuotaModeradora.IdentificacionPaciente;
                SalarioTxt.Text = respuestaBusqueda.liquidacionCuotaModeradora.Salario.ToString();
                ValorServicioTxt.Text = respuestaBusqueda.liquidacionCuotaModeradora.ValorServicio.ToString();
                FechaTxt.Text = respuestaBusqueda.liquidacionCuotaModeradora.FechaLiquidacion.ToString();
                NombreTxt.Text = respuestaBusqueda.liquidacionCuotaModeradora.NombrePaciente;
               
            }
            catch (Exception)
            {
                string buscar;
                buscar = "No se ha encontrado!";
                MessageBox.Show(buscar);
            }

        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            string mensaje;
            try
            {               
                string buscar;

                buscar = BuscarTxt.Text;
                LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();

                mensaje = liquidacionCoutaModeradoraService.Eliminar(buscar);
                MessageBox.Show(mensaje);
                LimpiarCampos();
            }
            catch(Exception)
            {
                mensaje = "Por favor rellene el campo";
                MessageBox.Show(mensaje);
            }
            
        }
        public void LimpiarCampos()
        {
            
            NumeroLiquidacionTxt.Text = null;
            IdentificacionTxt.Text = null; ;
            SalarioTxt.Text = null;
            ValorServicioTxt.Text = null;
            FechaTxt.Text = null;
            NombreTxt.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();




            respuestaBusqueda = liquidacionCoutaModeradoraService.Buscar(BuscarTxt.Text);
            if (respuestaBusqueda.liquidacionCuotaModeradora != null)
            {
                decimal valorServicioModificado = Convert.ToDecimal(ValorServicioTxt.Text);
                string numeroLiquidacion = respuestaBusqueda.liquidacionCuotaModeradora.NumeroLiquidacion;
                string identificacionPaciente = respuestaBusqueda.liquidacionCuotaModeradora.IdentificacionPaciente;
                string tipoAfiliacion = respuestaBusqueda.liquidacionCuotaModeradora.TipoAfiliacion;
                decimal salario = respuestaBusqueda.liquidacionCuotaModeradora.Salario;
                DateTime fecha = respuestaBusqueda.liquidacionCuotaModeradora.FechaLiquidacion;
                string nombre = respuestaBusqueda.liquidacionCuotaModeradora.NombrePaciente;

               LiquidacionCuotaModeradora liquidacionCuotaModeradora = liquidacionCoutaModeradoraService.CreacionLiquidacionModeradora(numeroLiquidacion, 
                   identificacionPaciente, tipoAfiliacion,
                    salario, valorServicioModificado, fecha, nombre);
                liquidacionCuotaModeradora.AplicacionTarifayTopeMaximo();
                liquidacionCuotaModeradora.CalculoCoutaModeradora();


                string mensaje = liquidacionCoutaModeradoraService.Modificar(liquidacionCuotaModeradora);
                MessageBox.Show(mensaje);

            }
        }
    }
}
