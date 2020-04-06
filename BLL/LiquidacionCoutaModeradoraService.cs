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
                    return $"Se ha guardado correctamente {liquidacionCuotaModeradora.ToString()}";
                }
                return $"Liquidacion Ya registrada {liquidacionCuotaModeradora.NumeroLiquidacion}";
     
            }
            catch (Exception e)
            {

                return $"Error en los datos {e.Message}";
            }
            
            
        }
        public string Consultar()
        {
            List<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();
            try
            {

               liquidacionCuotaModeradoras =  liquidacionCoutaModeradoraRepository.Consultar();
                foreach (var item in liquidacionCuotaModeradoras)
                {
                    Console.WriteLine(item.ToString());
                }
                return "Ha sido ejecutado con exito";
            }
            catch (Exception e )
            {

                return $"Error en los datos {e.Message}";
            }
        }

        public string Eliminar(string numeroLiquidacion)
        {
            
            try
            {
                if((liquidacionCoutaModeradoraRepository.Buscar(numeroLiquidacion)) != null)
                {
                    
                    liquidacionCoutaModeradoraRepository.Eliminar(numeroLiquidacion);
                    return $"EL registro ha sido eliminado con exito {liquidacionCoutaModeradoraRepository.Buscar(numeroLiquidacion).ToString()}";
                }
                return $"El registro no ha sido encontrado {numeroLiquidacion}";  
            }
            catch (Exception e)
            {

                return $"Error en los datos {e.Message}";
            }
        }
        public string Modificar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            try
            {
                if(liquidacionCoutaModeradoraRepository.Buscar(liquidacionCuotaModeradora.NumeroLiquidacion) != null)
                {

                    liquidacionCoutaModeradoraRepository.Modificar(liquidacionCuotaModeradora);
                    return $"El registro {liquidacionCuotaModeradora.ToString()} ha sido modificado";
                }
                return $"No se ha encontrado el registro {liquidacionCuotaModeradora.ToString()}";
            }
            catch (Exception e)
            {

                return $"Error en los datos {e.Message}";
            }
        }

       public LiquidacionCuotaModeradora Buscar(string numeroLiquidacion)
        {
            if(liquidacionCoutaModeradoraRepository.Buscar(numeroLiquidacion) != null)
            {
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = liquidacionCoutaModeradoraRepository.Buscar(numeroLiquidacion);
                return liquidacionCuotaModeradora;
            }

            
            return null;
        }
        public Boolean RetornarTipoAfiliacion(string numeroLiquidacion)
        {
            LiquidacionCuotaModeradora liquidacionCuotaModeradora = liquidacionCoutaModeradoraRepository.Buscar(numeroLiquidacion);
            if(liquidacionCuotaModeradora.TipoAfiliacion.Equals("Subsidiado"))
            {
                return true;
            }
            return false;
        }
    }
}
