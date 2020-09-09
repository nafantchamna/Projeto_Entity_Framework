using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaModeloEnti
{
    class ClienteContext: DbContext

    {
        DbSet<Cliente>Clientes { get; set; }
    }
}
