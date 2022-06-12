using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMME_Acabados_.Data.DatosGaleria.GaleriaResidencial
{
    public class Residencial
    {
        public async Task<List<ListResidencial>> ImgVer(string nombre)
        {
            List<ListResidencial> Nombres = new List<ListResidencial>();

            try
            {
                string URL = System.IO.Directory.GetCurrentDirectory();
                string[] img = System.IO.Directory.GetFiles(@"wwwroot\phosen\images\Residencial\" + nombre);

                foreach (string Archivo in img)
                {
                    ListResidencial cargar = new ListResidencial();
                    cargar.UrlImg = "/phosen/images/Residencial/" + nombre + "/" + System.IO.Path.GetFileName(Archivo);

                    Nombres.Add(cargar);
                }
            }
            catch (Exception ex)
            {

            }


            return await Task.FromResult(Nombres);
        }
    }
}
