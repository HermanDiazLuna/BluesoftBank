using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluesoftBank.core.entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NumeroIdentificacion { get; set; }

        public int IdTipoCliente { get; set; }

        public string Nombre { get; set; }

        public virtual TipoCliente TipoCliente { get; set; }






    }
}
