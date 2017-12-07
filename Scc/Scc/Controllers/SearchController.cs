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
    public class SearchController : Controller
    {
        // GET: api/api/Search/User/id"
        [HttpGet("{condo}")]
        [Route("api/Search/User")]
        public object Get(string condo)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbUser.json");
            var user = JsonConvert.DeserializeObject<List<Models.User>>(json);
            try
            {
                var y = user.FindAll(x => x.Pes_condo.Equals(condo));
                return y;
            }
            catch
            {
                string a = ("erro usuario inexistente");
                return a;
            }
        }
        // GET: api/Search/List/User
        [HttpGet]
        [Route("api/Search/List/User")]
        public List<Models.User> Get()
        {
            var json = System.IO.File.ReadAllText(@"Data\dbUser.json");
            var user = JsonConvert.DeserializeObject<List<Models.User>>(json);

            return user;
        }
        [HttpGet]
        [Route("api/Search/List/Condo")]
        public List<Models.Condominio> Get1()
        {
            var json = System.IO.File.ReadAllText(@"Data\dbCondo.json");
            var condo = JsonConvert.DeserializeObject<List<Models.Condominio>>(json);

            return condo;
        }

        [HttpGet]
        [Route("api/Search/List/Empresa")]
        public List<Models.Empresa> Get2()
        {
            var json = System.IO.File.ReadAllText(@"Data\dbEmpresas.json");
            var empresa = JsonConvert.DeserializeObject<List<Models.Empresa>>(json);

            return empresa;
        }
        // GET: api/api/Search/User/id"
        [HttpGet("{user}")]
        [Route("api/Search/Reservas")]
        public object Get2(string user)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbReservas.json");
            var reser = JsonConvert.DeserializeObject<List<Models.Reservas>>(json);
            try
            {
                var y = reser.FindAll(x => x.Reserva_user.Equals(user));
                return y;
            }
            catch
            {
                return 0;
            }
        }
        [HttpGet("{user}")]
        [Route("api/Search/List/Reservas")]
        public object Get3(string user)
        {
            var json = System.IO.File.ReadAllText(@"Data\dbCondo.json");
            var reser = JsonConvert.DeserializeObject<List<Models.Condominio>>(json);
            try
            {
                var y = reser.IndexOf(reser.First(x => x.Con_nome.Equals(user)));
                return reser[y].Con_areas;
            }
            catch
            {
                return 0;
            }
        }
    }
}