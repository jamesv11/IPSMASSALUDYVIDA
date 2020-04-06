using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionCuotaModeradoraContributivo : LiquidacionCuotaModeradora
    {
        public LiquidacionCuotaModeradoraContributivo(string numeroLiquidacion , string identificacionPaciente, decimal Salario , decimal ValorServicio) 
            : base(numeroLiquidacion , identificacionPaciente, "Contributivo",Salario,ValorServicio)
        {
            
        }
        public LiquidacionCuotaModeradoraContributivo()
        {

        }

        public override void AplicacionTarifayTopeMaximo()
        {
            if(Salario < SALARIOMINIMO*2)
            {
                Tarifa = (decimal)0.15;
                TopeMaximo = 250000;
            }
            else if (Salario > SALARIOMINIMO*2 && Salario < SALARIOMINIMO*5)
            {
                Tarifa = (decimal)0.20;
                TopeMaximo = 900000;
            }
            else
            {
                Tarifa = (decimal)0.25;
                TopeMaximo = 1500000;
            }
        }
    }
}
