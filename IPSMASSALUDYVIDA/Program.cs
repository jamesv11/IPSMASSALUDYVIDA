using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;


namespace IPSMASSALUDYVIDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();

            LiquidacionCuotaModeradora Primeraliquidacion = new LiquidacionCuotaModeradoraContributivo("1","12345",750000,120000);
            LiquidacionCuotaModeradora segundaliquidacion = new LiquidacionCuotaModeradoraContributivo("2", "12345", 2500000, 120000);
            LiquidacionCuotaModeradora terceraliquidacion = new LiquidacionCuotaModeradoraContributivo("3", "12345", 900000, 120000);
            LiquidacionCuotaModeradora cuartaliquidacion = new LiquidacionCoutaModeradoraSubsidiado("4", "147852",1400000);

            Primeraliquidacion.AplicacionTarifayTopeMaximo();
            Primeraliquidacion.CalculoCoutaModeradora();
            segundaliquidacion.AplicacionTarifayTopeMaximo();
            segundaliquidacion.CalculoCoutaModeradora();
            terceraliquidacion.AplicacionTarifayTopeMaximo();
            terceraliquidacion.CalculoCoutaModeradora();
            cuartaliquidacion.AplicacionTarifayTopeMaximo();
            cuartaliquidacion.CalculoCoutaModeradora();

            liquidacionCuotaModeradoras.Add(Primeraliquidacion);
            liquidacionCuotaModeradoras.Add(segundaliquidacion);
            liquidacionCuotaModeradoras.Add(terceraliquidacion);
            liquidacionCuotaModeradoras.Add(cuartaliquidacion);

            foreach (var item in liquidacionCuotaModeradoras)
            {
                Console.WriteLine(item.ToString());
            }

            
            LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();
            
            liquidacionCoutaModeradoraService.Guardar(Primeraliquidacion);
            liquidacionCoutaModeradoraService.Guardar(segundaliquidacion);
            liquidacionCoutaModeradoraService.Guardar(terceraliquidacion);
            liquidacionCoutaModeradoraService.Guardar(cuartaliquidacion);
            Console.WriteLine("Consultas");
            Console.WriteLine(liquidacionCoutaModeradoraService.Consultar());
            Console.WriteLine("Eliminar el registro '3' ");
            liquidacionCoutaModeradoraService.Eliminar("3");
            Console.WriteLine("Modificar \n La cuenta con numero de liquidacion 1 \n ");
            liquidacionCoutaModeradoraService.Buscar("1");
            bool retornoTipoAfiliciacion = liquidacionCoutaModeradoraService.RetornarTipoAfiliacion("1");
            if(retornoTipoAfiliciacion)
            {
                LiquidacionCuotaModeradora nuevoRegistro = new LiquidacionCoutaModeradoraSubsidiado();
                nuevoRegistro.NumeroLiquidacion = liquidacionCoutaModeradoraService.Buscar("1").NumeroLiquidacion;
                nuevoRegistro.IdentificacionPaciente = liquidacionCoutaModeradoraService.Buscar("1").IdentificacionPaciente;
                nuevoRegistro.TipoAfiliacion = liquidacionCoutaModeradoraService.Buscar("1").TipoAfiliacion;
                nuevoRegistro.Salario = liquidacionCoutaModeradoraService.Buscar("1").Salario;
                nuevoRegistro.ValorServicio = 450000;
                nuevoRegistro.Tarifa = liquidacionCoutaModeradoraService.Buscar("1").Tarifa;
                nuevoRegistro.CoutaModeradoraFinal = liquidacionCoutaModeradoraService.Buscar("1").CoutaModeradoraFinal;
                nuevoRegistro.TopeMaximo = liquidacionCoutaModeradoraService.Buscar("1").TopeMaximo;
                liquidacionCoutaModeradoraService.Modificar(nuevoRegistro);
          
            }
            else
            {
                LiquidacionCuotaModeradora nuevoRegistro = new LiquidacionCuotaModeradoraContributivo();
                nuevoRegistro = liquidacionCoutaModeradoraService.Buscar("1");
                nuevoRegistro.NumeroLiquidacion = liquidacionCoutaModeradoraService.Buscar("1").NumeroLiquidacion;
                nuevoRegistro.IdentificacionPaciente = liquidacionCoutaModeradoraService.Buscar("1").IdentificacionPaciente;
                nuevoRegistro.TipoAfiliacion = liquidacionCoutaModeradoraService.Buscar("1").TipoAfiliacion;
                nuevoRegistro.Salario = liquidacionCoutaModeradoraService.Buscar("1").Salario;
                nuevoRegistro.ValorServicio = 450000;
                nuevoRegistro.Tarifa = liquidacionCoutaModeradoraService.Buscar("1").Tarifa;
                nuevoRegistro.CoutaModeradoraFinal = liquidacionCoutaModeradoraService.Buscar("1").CoutaModeradoraFinal;
                nuevoRegistro.TopeMaximo = liquidacionCoutaModeradoraService.Buscar("1").TopeMaximo;
                liquidacionCoutaModeradoraService.Modificar(nuevoRegistro);
            }


            Console.WriteLine(liquidacionCoutaModeradoraService.Consultar());
        }
    }
}
