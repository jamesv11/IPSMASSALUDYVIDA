using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;


namespace DAL
{
    public class LiquidacionCoutaModeradoraRepository
    {
        private string ruta = @"LiquidacionCoutaModeradora.txt";
        private IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();

        public void Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {

            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);
            escritor.WriteLine(liquidacionCuotaModeradora.ToString());

            escritor.Close();
            fileStream.Close();

        }
        public IList<LiquidacionCuotaModeradora> Consultar()
        {


            liquidacionCuotaModeradoras.Clear();

            string linea = string.Empty;
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);

            while ((linea = lector.ReadLine()) != null)
            {
                LiquidacionCuotaModeradora liquidacionCuotaModeradora;
                String[] matrizLiquidacionCoutaModeradora = linea.Split(';');

                if (matrizLiquidacionCoutaModeradora[2] == "Contributivo")
                {
                    liquidacionCuotaModeradora = new LiquidacionCuotaModeradoraContributivo()
                    {
                        NumeroLiquidacion = matrizLiquidacionCoutaModeradora[0],
                        IdentificacionPaciente = matrizLiquidacionCoutaModeradora[1],
                        TipoAfiliacion = matrizLiquidacionCoutaModeradora[2],
                        Salario = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[3]),
                        ValorServicio = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[4]),
                        Tarifa = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[5]),
                        CoutaModeradoraFinal = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[6]),
                        TopeMaximo = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[7]),
                        FechaLiquidacion = Convert.ToDateTime(matrizLiquidacionCoutaModeradora[8]),
                        NombrePaciente = matrizLiquidacionCoutaModeradora[9]
                        
                    };

                }
                else
                {
                    liquidacionCuotaModeradora = new LiquidacionCoutaModeradoraSubsidiado()
                    {
                        NumeroLiquidacion = matrizLiquidacionCoutaModeradora[0],
                        IdentificacionPaciente = matrizLiquidacionCoutaModeradora[1],
                        TipoAfiliacion = matrizLiquidacionCoutaModeradora[2],
                        Salario = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[3]),
                        ValorServicio = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[4]),
                        Tarifa = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[5]),
                        CoutaModeradoraFinal = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[6]),
                        TopeMaximo = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[7]),
                        FechaLiquidacion = Convert.ToDateTime(matrizLiquidacionCoutaModeradora[8]),
                        NombrePaciente = matrizLiquidacionCoutaModeradora[9]
                    };

                }
                liquidacionCuotaModeradoras.Add(liquidacionCuotaModeradora);
            }

            lector.Close();
            fileStream.Close();
            return liquidacionCuotaModeradoras;


        }

        public LiquidacionCuotaModeradora Buscar(string numeroLiquidacion)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = Consultar();

            return liquidacionCuotaModeradoras.Where(l => l.NumeroLiquidacion.Equals(numeroLiquidacion)).FirstOrDefault();
            
        }
        public void Eliminar(string numeroLiquidacion)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in liquidacionCuotaModeradoras)
            {
                if (item.NumeroLiquidacion != numeroLiquidacion)
                {
                    Guardar(item);
                }
            }
        }


        public void Modificar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();


            foreach (var item in liquidacionCuotaModeradoras)
            {
                if (item.NumeroLiquidacion != liquidacionCuotaModeradora.NumeroLiquidacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(liquidacionCuotaModeradora);
                }
            }
        }

        public int ObtenerCantidadCoutaModeradoraSubsidiado()
        {
            return liquidacionCuotaModeradoras.Where(l => l.TipoAfiliacion == "Subsidiado").Count();
        }
        public int ObtenerCantidadCoutaModeradoraContributivo()
        {
            return liquidacionCuotaModeradoras.Where(l => l.TipoAfiliacion == "Contributivo").Count();
        }
        public IList<LiquidacionCuotaModeradora> ObtenerCoutasModeradorasSubsidiadas()
        {
            return liquidacionCuotaModeradoras.Where(l => l.TipoAfiliacion == "Subsidiado").ToList();
        }
        public IList<LiquidacionCuotaModeradora> ObtenerCoutasModeradorasContributivas()
        {
            return liquidacionCuotaModeradoras.Where(l => l.TipoAfiliacion == "Contributivo").ToList();
        }
        public decimal ValorTotalCoutaModeradoraSubsidiado(IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras)
        {
            return liquidacionCuotaModeradoras.Sum(l => l.CoutaModeradoraFinal);
        }
        public decimal ValorTotalCoutaModeradoraContributivo(IList<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras)
        {
            return liquidacionCuotaModeradoras.Sum(l => l.CoutaModeradoraFinal);
        }
        public IList<LiquidacionCuotaModeradora> ObtenerFiltroCoutaModeradoraFecha(DateTime dateTime)
        {
            return null;
        }
        public IList<LiquidacionCuotaModeradora> ObtenerNombresFiltrados(string caracter)
        {
            return liquidacionCuotaModeradoras.Where(l => l.NombrePaciente.Contains(caracter)).ToList();
        }
        public int ObtenerCantidadTotalCoutasModeradoras()
        {
            return liquidacionCuotaModeradoras.Count();
        }
    }
    }
    
