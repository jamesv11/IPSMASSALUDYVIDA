using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
        public class LiquidacionCoutaModeradoraSubsidiado : LiquidacionCuotaModeradora
        {
        public LiquidacionCoutaModeradoraSubsidiado(string numeroLiquidacion,string identificacionPaciente,decimal ValorServicio)
            :base(numeroLiquidacion,identificacionPaciente,"Subsidiado",0,ValorServicio)
        {

        }
        public LiquidacionCoutaModeradoraSubsidiado()
        {

        }
        public override void AplicacionTarifayTopeMaximo()
        {
            Tarifa = (decimal)0.05;
            TopeMaximo = 200000;
        }
    }
}
