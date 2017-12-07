using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scc.Models
{
    public class Reservas
    {
        public string Reserva_condo { get; set; }
        public string Reserva_user { get; set; }
        public string Reserva_area { get; set; }
        public string Reserva_data { get; set; }
        public string Reserva_datadv { get; set; }
        public string Reserva_id = System.Guid.NewGuid().ToString();
    }
    public class Condominio
    {
            public string Con_nome { get; set; }
            public string Con_cnpj { get; set; }
            public string Con_endereco { get; set; }
            public string Con_numero { get; set; }
            public string Con_cidade { get; set; }
            public string Con_uf { get; set; }
            public string Con_bairro { get; set; }
            public string Con_tel { get; set; }
            public List<string> Con_areas { get; set; }
    }
}

