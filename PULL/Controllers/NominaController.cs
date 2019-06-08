using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PULL.Controllers
{
    public class NominaController : Controller
    {
        tssDBEntities db = new tssDBEntities();
        // GET: Nomina
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:53231/empleado");

            ClaseEsquema clase = JsonConvert.DeserializeObject<ClaseEsquema>(json);



            Nomina cabecera = new Nomina
            {
                Periodo = Convert.ToDateTime(clase.Periodo),
                Rnc = clase.Rnc,
                Nomina_Detalle = clase.Empleados

            };

            db.Nomina.Add(cabecera);
            db.SaveChanges();


            return Content("Datos guardados correctamente");
        }
    }
    class ClaseEsquema
    {
        public int Id { get; set; }
        public string Rnc { get; set; }
        public string Periodo { get; set; }
        public int CantEmpleados { get; set; }
        public ICollection<Nomina_Detalle> Empleados { get; set; }


    }
}