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
            DateTime fecha = DateTime.Today;
            
            LiquidacionCuotaModeradora Primeraliquidacion = new LiquidacionCuotaModeradoraContributivo("1","12345",750000,12000, fecha,"James");
            LiquidacionCuotaModeradora segundaliquidacion = new LiquidacionCuotaModeradoraContributivo("2", "12345", 2500000, 120000, fecha,"Natalia");
            LiquidacionCuotaModeradora terceraliquidacion = new LiquidacionCuotaModeradoraContributivo("3", "12345", 1200000, 120000, fecha,"Nebis");
            LiquidacionCuotaModeradora cuartaliquidacion = new LiquidacionCoutaModeradoraSubsidiado("4", "147852",1400000, fecha,"Neftali");
            LiquidacionCuotaModeradora Quintaliquidacion = new LiquidacionCoutaModeradoraSubsidiado("5", "1003316933", 5000000, DateTime.Now,"Dilson");


            Quintaliquidacion.AplicacionTarifayTopeMaximo();
            Quintaliquidacion.CalculoCoutaModeradora();
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
            liquidacionCuotaModeradoras.Add(Quintaliquidacion);

            foreach (var item in liquidacionCuotaModeradoras)
            {
                Console.WriteLine(item.ToString());
            }

            
            LiquidacionCoutaModeradoraService liquidacionCoutaModeradoraService = new LiquidacionCoutaModeradoraService();

            
            Console.WriteLine(liquidacionCoutaModeradoraService.Guardar(Primeraliquidacion));
            Console.WriteLine(liquidacionCoutaModeradoraService.Guardar(segundaliquidacion));
            Console.WriteLine(liquidacionCoutaModeradoraService.Guardar(terceraliquidacion));
            Console.WriteLine(liquidacionCoutaModeradoraService.Guardar(cuartaliquidacion));
            Console.WriteLine(liquidacionCoutaModeradoraService.Guardar(Quintaliquidacion));

            Console.WriteLine(liquidacionCoutaModeradoraService.Consultar());
            Console.WriteLine(liquidacionCoutaModeradoraService.ObtenerCantidadCoutaModeradoraSubsidiado());
            Console.WriteLine(liquidacionCoutaModeradoraService.ObtenerValorTotalCoutaContributiva
                (liquidacionCoutaModeradoraService.ObtenerCoutasModeradorasContributivas()));
            Console.WriteLine(liquidacionCoutaModeradoraService.Eliminar("1"));
            Console.WriteLine(liquidacionCoutaModeradoraService.Consultar());
            foreach (var item in liquidacionCoutaModeradoraService.ObtenerNombresFiltrados("i"))
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
