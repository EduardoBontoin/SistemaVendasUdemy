using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendasUdemy.Models;

namespace SistemaVendasUdemy.Data
{
    public class SistemaVendasUdemyContext : DbContext
    {
        public SistemaVendasUdemyContext (DbContextOptions<SistemaVendasUdemyContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaVendasUdemy.Models.Departamento> Departamento { get; set; } = default!;
    }
}
