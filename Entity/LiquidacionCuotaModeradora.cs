using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public decimal CoutaModeradora { get; set; }
        public string NumeroLiquidacion { get; set; }
        public string IdentificacionPaciente { get; set; }
        public string TipoAfiliacion { get; set; }
        public decimal Salario { get; set; }
        public decimal Tarifa { get; set; }
        public decimal ValorServicio { get; set; }
        public decimal TopeMaximo { get; set; }
        public decimal CoutaModeradoraFinal { get; set; }
        public decimal SALARIOMINIMO = 980657;

        public LiquidacionCuotaModeradora(string numeroLiquidacion, string identificacionPaciente, string tipoAfiliacion, decimal salario, decimal valorServicio)
        {
            NumeroLiquidacion = numeroLiquidacion;
            IdentificacionPaciente = identificacionPaciente;
            TipoAfiliacion = tipoAfiliacion;
            Salario = salario;
            ValorServicio = valorServicio;
        }
        public LiquidacionCuotaModeradora()
        {

        }

        public void CalculoCoutaModeradora()
        {
            CoutaModeradora =  ValorServicio * Tarifa;
            if(CoutaModeradora > TopeMaximo )
            {
                CoutaModeradoraFinal = TopeMaximo;
            }
            else
            {
                CoutaModeradoraFinal = CoutaModeradora;
            }
            
        }

        public abstract void AplicacionTarifayTopeMaximo();
        

        public override string ToString()
        {
            return $"{NumeroLiquidacion};{IdentificacionPaciente};{TipoAfiliacion};{Salario};{ValorServicio};{Tarifa};{CoutaModeradoraFinal};{TopeMaximo}";
        }
    }
}
