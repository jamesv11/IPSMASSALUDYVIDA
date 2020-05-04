using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class FactoriaLiquidacionCoutaModeradora: IFactoriaLiquidacionCoutaModeradora
    {
        public LiquidacionCuotaModeradora CreacionLiquidacionCoutaModeradora(string numeroLiquidacion,
               string identificacionPaciente, string tipoAfiliacion, decimal salario, decimal valorServicio, DateTime fecha,string nombre)
        {
            if (tipoAfiliacion == "Contributivo")
            {
                return new LiquidacionCuotaModeradoraContributivo(numeroLiquidacion, identificacionPaciente, salario, valorServicio, fecha,nombre);
            }
            else
            {
                return new LiquidacionCoutaModeradoraSubsidiado(numeroLiquidacion, identificacionPaciente, valorServicio, fecha,nombre);
            }
        }
    }
    interface IFactoriaLiquidacionCoutaModeradora
    {
        LiquidacionCuotaModeradora CreacionLiquidacionCoutaModeradora(string numeroLiquidacion,
            string identificacionPaciente, string tipoAfiliacion, decimal salario, decimal valorServicio, DateTime fecha,string nombre);
    }
}
