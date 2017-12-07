using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Scc.Controllers
{

    [Produces("application/json")]
    public class ChangerController : Controller
    {

        // POST: api/User
        //UPDATE
        [HttpPost]
        [Route("api/Alterar/User")]
        public object Post1([FromBody]Models.User value)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbUser.json");
            var user = JsonConvert.DeserializeObject<List<Models.User>>(json);
            try
            {
                int y = user.IndexOf(user.First(x => x.Pes_cpf.Equals(value.Pes_cpf)));
                user[y] = value;
                var json_w = JsonConvert.SerializeObject(user, Formatting.Indented);
                System.IO.File.WriteAllText(@"Data\dbUser.json", json_w);
                return user[y];
            }
            catch (System.InvalidOperationException)
            {
                string a = ("erro usuario inexistente");
                return a;
            }

        }
        [HttpPost]
        [Route("api/Alterar/Empresa")]
        public object Post([FromBody]Models.Empresa value)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbEmpresas.json");
            var user = JsonConvert.DeserializeObject<List<Models.Empresa>>(json);
            try
            {
                int y = user.IndexOf(user.First(x => x.Em_cnpj.Equals(value.Em_cnpj)));
                user[y] = value;
                var json_w = JsonConvert.SerializeObject(user, Formatting.Indented);
                System.IO.File.WriteAllText(@"Data\dbEmpresas.json", json_w);
                return user[y];
            }
            catch (System.InvalidOperationException)
            {
                string a = ("erro usuario inexistente");
                return a;
            }

        }
        [HttpPost]
        [Route("api/Alterar/Condo")]
        public object Post2([FromBody]Models.Condominio value)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbCondo.json");
            var user = JsonConvert.DeserializeObject<List<Models.Condominio>>(json);
            try
            {
                int y = user.IndexOf(user.First(x => x.Con_cnpj.Equals(value.Con_cnpj)));
                user[y] = value;
                var json_w = JsonConvert.SerializeObject(user, Formatting.Indented);
                System.IO.File.WriteAllText(@"Data\dbCondo.json", json_w);
                return user[y];
            }
            catch (System.InvalidOperationException)
            {
                string a = ("erro usuario inexistente");
                return a;
            }

        }
        [HttpPost]
        [Route("api/Alterar/Reserva")]
        public object Post3([FromBody]Models.Reservas value)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbReservas.json");
            var user = JsonConvert.DeserializeObject<List<Models.Reservas>>(json);
            try
            {
                int y = user.IndexOf(user.First(x => x.Reserva_id.Equals(value.Reserva_id)));
                user[y] = value;
                var json_w = JsonConvert.SerializeObject(user, Formatting.Indented);
                System.IO.File.WriteAllText(@"Data\dbReservas.json", json_w);
                return user[y];
            }
            catch (System.InvalidOperationException)
            {
                string a = ("erro usuario inexistente");
                return a;
            }

        }

    }

}
