using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_CLIENTES.Models;

namespace MVC_CLIENTES.Data
{
    public class MVC_CLIENTESContext : DbContext
    {
        public MVC_CLIENTESContext (DbContextOptions<MVC_CLIENTESContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_CLIENTES.Models.Cliente> Cliente { get; set; }
    }
}
