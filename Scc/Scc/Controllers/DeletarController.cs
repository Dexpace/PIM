using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Scc.Controllers
{
    [Produces("application/json")]
    public class DeletarController : Controller
    {
        // POST: api/User
        //UPDATE
        [HttpPost]
        [Route("api/Delet/User")]
        public object Post([FromBody]Models.User value)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbUser.json");
            var user = JsonConvert.DeserializeObject<List<Models.User>>(json);
            try
            {
                int y = user.IndexOf(user.First(x => x.Pes_cpf.Equals(value.Pes_cpf)));
                user.Remove(user[y]);
                var json_w = JsonConvert.SerializeObject(user, Formatting.Indented);
                System.IO.File.WriteAllText(@"Data\dbUser.json", json_w);
                return "erro";
            }
            catch (System.InvalidOperationException)
            {
                string a = ("erro usuario inexistente");
                return a;
            }

        }
        [HttpPost]
        [Route("api/Delet/Reserva")]
        public object Post1([FromBody]Models.Reservas value)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbReservas.json");
            var user = JsonConvert.DeserializeObject<List<Models.Reservas>>(json);
            try
            {
                int y = user.IndexOf(user.First(x => x.Reserva_user.Equals(value.Reserva_user) && x.Reserva_area.Equals(value.Reserva_area) && x.Reserva_data.Equals(value.Reserva_data)));
                user.Remove(user[y]);
                var json_w = JsonConvert.SerializeObject(user, Formatting.Indented);
                System.IO.File.WriteAllText(@"Data\dbReservas.json", json_w);
                return "erro";
            }
            catch (System.InvalidOperationException)
            {
                string a = ("erro usuario inexistente");
                return a;
            }

        }

    }
}
