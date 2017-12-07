using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Scc.Controllers
{
    /// CONTROLES DE LOGIN WEB E DESK
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        // POST: api/Login
        [HttpPost]
        public object Post([FromBody]Models.User value)
        {
                var json = System.IO.File.ReadAllText(@"Data\dbUser.json");
                var user = JsonConvert.DeserializeObject<List<Models.User>>(json);
            try
            {
                var y = user.Find((x => x.Pes_cpf.Equals(value.Pes_cpf) && x.Pes_senha.Equals(value.Pes_senha)));
                return y;
            }
            catch (System.NullReferenceException)
            {
                return null;
            }
              
        }

    }
        
}

