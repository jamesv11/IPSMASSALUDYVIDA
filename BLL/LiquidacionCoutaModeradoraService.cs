using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.IO;

namespace BLL
{
    public class LiquidacionCoutaModeradoraService
    {

        LiquidacionCoutaModeradoraRepository liquidacionCoutaModeradoraRepository;


        public LiquidacionCoutaModeradoraService()
        {
            liquidacionCoutaModeradoraRepository = new LiquidacionCoutaModeradoraRepository();

        }

        public string Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                if (liquidacionCoutaModeradoraRepository.Buscar(liquidacionCuotaModeradora.NumeroLiquidacion) == null)
                {
                    liquidacionCoutaModeradoraRepository.Guardar(liquidacionCuotaModeradora);
                    return $"Se ha guardado correctamente ";
                }
                return $"Liquidacion Ya registrada {liquidacionCuotaModeradora.NumeroLiquidacion}";

            }
            catch (Exception e)
            {

                return $"Error en los datos {e.Message}";
            }


        }
        public RespuestaConsulta Consultar()
        {
            //IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {

                respuestaConsulta.liquidacionCuotaModeradoras = liquidacionCoutaModeradoraRepository.Consultar();
                foreach (var item in respuestaConsulta.liquidacionCuotaModeradoras)
                {
                    Console.WriteLine(item.ToString());
                }
                respuestaConsulta.Mensaje = "Consulta realizada con exito";
                return respuestaConsulta;
            }
            catch (Exception )
            {

                return null;
            }
        }

        public string Eliminar(string numeroLiquidacion)
        {
            try
            {
                LiquidacionCuotaModeradora cuotaModeradora = liquidacionCoutaModeradoraRepository.Buscar(numeroLiquidacion);
                if (cuotaModeradora != null)
                {
                    liquidacionCoutaModeradoraRepository.Eliminar(numeroLiquidacion);
                    return $"La cuenta {cuotaModeradora.NumeroLiquidacion} ha sido eliminada";
                }
                return $"La cuenta {cuotaModeradora.ToString()} no se encuentra registrada";
            }
            catch (Exception E)
            {
                return "Error al eliminar : " + E.Message;
            }
        }
        public string Modificar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                if (liquidacionCoutaModeradoraRepository.Buscar(liquidacionCuotaModeradora.NumeroLiquidacion) != null)
                {

                    liquidacionCoutaModeradoraRepository.Modificar(liquidacionCuotaModeradora);
                    return $"El registro {liquidacionCuotaModeradora.ToString()} ha sido modificado";
                }
                return $"No se ha encontrado el registro {liquidacionCuotaModeradora.ToString()}";
            }
            catch (Exception e)
            {

                return $"Error al modificar : {e.Message}";
            }
        }

        public LiquidacionCuotaModeradora Buscar(string numeroLiquidacion)
        {
            IFactoriaLiquidacionCoutaModeradora factoriaLiquidacionCoutaModeradora = new FactoriaLiquidacionCoutaModeradora();
            LiquidacionCuotaModeradora liquidacionCuota;
            try
            {
                if ((liquidacionCuota = liquidacionCoutaModeradoraRepository.Buscar(numeroLiquidacion)) != null)
                {
                    return factoriaLiquidacionCoutaModeradora.CreacionLiquidacionCoutaModeradora(liquidacionCuota.NumeroLiquidacion,
                         liquidacionCuota.IdentificacionPaciente, liquidacionCuota.TipoAfiliacion, liquidacionCuota.Salario,
                         liquidacionCuota.ValorServicio,liquidacionCuota.FechaLiquidacion,liquidacionCuota.NombrePaciente);

                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public LiquidacionCuotaModeradora CreacionLiquidacionModeradora(string numeroLiquidacion,
                string identificacionPaciente, string tipoAfiliacion, decimal salario, decimal valorServicio,DateTime fecha,string nombre)
        {
            try
            {
                IFactoriaLiquidacionCoutaModeradora factoriaLiquidacionCoutaModeradora = new FactoriaLiquidacionCoutaModeradora();
                return factoriaLiquidacionCoutaModeradora.CreacionLiquidacionCoutaModeradora(numeroLiquidacion,
                    identificacionPaciente, tipoAfiliacion, salario, valorServicio,fecha,nombre);
            }
            catch (Exception)
            {

                return null;
            }


        }
        public int ObtenerCantidadCoutaModeradoraSubsidiado()
        {
            return liquidacionCoutaModeradoraRepository.ObtenerCantidadCoutaModeradoraSubsidiado();
        }
        public int ObtenerCantidadCoutaModeradoraContributivo()
        {
            return liquidacionCoutaModeradoraRepository.ObtenerCantidadCoutaModeradoraContributivo();
        }
        public RespuestaConsulta ObtenerCoutasModeradorasSubsidiadas()
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
                respuestaConsulta.liquidacionCuotaModeradoras = liquidacionCoutaModeradoraRepository.ObtenerCoutasModeradorasSubsidiadas();
                respuestaConsulta.Mensaje = "La consulta ha sido realizada con extio";
                return respuestaConsulta;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public RespuestaConsulta ObtenerCoutasModeradorasContributivas()
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
                respuestaConsulta.liquidacionCuotaModeradoras = liquidacionCoutaModeradoraRepository.ObtenerCoutasModeradorasContributivas();
                respuestaConsulta.Mensaje = "La consulta ha sido realizada con exito";
                return respuestaConsulta;
            }
            catch (Exception)
            {

                return null;
            }
           
        }
        public decimal ObtenerValorTotalCoutaSubsidiadas(IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras)
        {
            return liquidacionCoutaModeradoraRepository.ValorTotalCoutaModeradoraSubsidiado(liquidacionCuotaModeradoras);
        }
        public decimal ObtenerValorTotalCoutaContributivas(IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras)
        {
            return liquidacionCoutaModeradoraRepository.ValorTotalCoutaModeradoraSubsidiado(liquidacionCuotaModeradoras);
        }
        public RespuestaConsulta ObtenerNombresFiltrados(string caracter)
        {
            IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras;
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
                 liquidacionCuotaModeradoras = liquidacionCoutaModeradoraRepository.ObtenerNombresFiltrados(caracter);
                if (liquidacionCuotaModeradoras != null)
                {
                    respuestaConsulta.liquidacionCuotaModeradoras = liquidacionCuotaModeradoras;
                    respuestaConsulta.Mensaje = "La consulta ha sido realizada con exito";
                    return respuestaConsulta;
                }              
                else
                {
                    respuestaConsulta.liquidacionCuotaModeradoras = null;
                    respuestaConsulta.Mensaje = "No se ha encontrado ninguna similitud";
                    return respuestaConsulta;
                }
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public int ObtenerCantidadTotalCoutasModeradoras()
        {
            return liquidacionCoutaModeradoraRepository.ObtenerCantidadTotalCoutasModeradoras();
        }


    }
    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras { get; set; }
       
    }


}

