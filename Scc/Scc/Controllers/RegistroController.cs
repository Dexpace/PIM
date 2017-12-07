using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Scc.Controllers
{
    // CONTROLES DE REGISTRO

    public class RegistroController : Controller
    {
        // POST: api/Registrar
        [HttpPost]
        [Route("api/Registrar/User")]
        public object Post([FromBody]Models.User value)
        {

            var json = System.IO.File.ReadAllText(@"Data\dbUser.json");
            var user = JsonConvert.DeserializeObject<List<Models.User>>(json);

            user.Add(value);

            var json_w = JsonConvert.SerializeObject(user, Formatting.Indented);
            System.IO.File.WriteAllText(@"Data\dbUser.json", json_w);

            string a = ("Usuario Cadatrado com Sucesso");

            return a;
        }
        [HttpPost]
        [Route("api/Registrar/Empresas")]
        public object Post1([FromBody]Models.Empresa value)
        {

            var json = System.IO.File.ReadAllText(@"Data\dbEmpresas.json");
            var empresa = JsonConvert.DeserializeObject<List<Models.Empresa>>(json);

            empresa.Add(value);

            var json_w = JsonConvert.SerializeObject(empresa, Formatting.Indented);
            System.IO.File.WriteAllText(@"Data\dbEmpresas.json", json_w);

            string a = ("Empresa Cadatrada com Sucesso");

            System.Console.WriteLine("Empresa Cadatrada com Sucesso");

            return a;
        }
        [HttpPost]
        [Route("api/Registrar/Condo")]
        public object Post2([FromBody]Models.Condominio value)
        {

            var json = System.IO.File.ReadAllText(@"Data\dbCondo.json");
            var condo = JsonConvert.DeserializeObject<List<Models.Condominio>>(json);

            condo.Add(value);

            var json_w = JsonConvert.SerializeObject(condo, Formatting.Indented);
            System.IO.File.WriteAllText(@"Data\dbCondo.json", json_w);

            string a = ("Condominio Cadatrado com Sucesso");

            return a;
        }
        [HttpPost]
        [Route("api/Registrar/Reserva")]
        public object Post3([FromBody]Models.Reservas value)
        {

            var json = System.IO.File.ReadAllText(@"Data\dbReservas.json");
            var reserva = JsonConvert.DeserializeObject<List<Models.Reservas>>(json);

            reserva.Add(value);

            var json_w = JsonConvert.SerializeObject(reserva, Formatting.Indented);
            System.IO.File.WriteAllText(@"Data\dbReservas.json", json_w);

            string a = ("Condominio Cadatrado com Sucesso");

            return a;
        }
    }
}
