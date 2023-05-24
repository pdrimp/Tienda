using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Shared.Modelos
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public float Total { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual ICollection<Producto>? Productos { get; set; }
    }
}
