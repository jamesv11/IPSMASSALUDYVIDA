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
        private List<LiquidacionCuotaModeradora> liquidacionCuotaModeradoras = new List<LiquidacionCuotaModeradora>();

        public void Guardar(LiquidacionCuotaModeradora liquidacionCuotaModeradora)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);
            escritor.WriteLine(liquidacionCuotaModeradora.ToString());
            escritor.Close();
            fileStream.Close();
        }
        public List<LiquidacionCuotaModeradora> Consultar()
        {
            liquidacionCuotaModeradoras.Clear();
            string linea = string.Empty;
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            while ((linea = lector.ReadLine()) != null)
            {
                LiquidacionCuotaModeradora liquidacionCuotaModeradora = new LiquidacionCuotaModeradoraContributivo();
                String[] matrizLiquidacionCoutaModeradora = linea.Split(';');
                liquidacionCuotaModeradora.NumeroLiquidacion = matrizLiquidacionCoutaModeradora[0];
                liquidacionCuotaModeradora.IdentificacionPaciente = matrizLiquidacionCoutaModeradora[1];
                liquidacionCuotaModeradora.TipoAfiliacion = matrizLiquidacionCoutaModeradora[2];
                liquidacionCuotaModeradora.Salario = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[3]);
                liquidacionCuotaModeradora.ValorServicio = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[4]);
                liquidacionCuotaModeradora.Tarifa = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[5]);
                liquidacionCuotaModeradora.CoutaModeradoraFinal = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[6]);
                liquidacionCuotaModeradora.TopeMaximo = Convert.ToDecimal(matrizLiquidacionCoutaModeradora[7]);


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
            

            foreach (var item in liquidacionCuotaModeradoras)
            {
                if (item.NumeroLiquidacion.Equals(numeroLiquidacion))
                {
                    return item;
                }

            }
            return null;
        }
        public void Eliminar(string numeroLiquidacion)
        {
            liquidacionCuotaModeradoras.Clear();
            liquidacionCuotaModeradoras = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();

            foreach (var item in liquidacionCuotaModeradoras)
            {
                if(item.NumeroLiquidacion != numeroLiquidacion)
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
    }
    }
    
