using Infraestructure.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Core.Context
{
    public class ContextSql : DbContext
    {
        public ContextSql(DbContextOptions<ContextSql> option) : base(option)
        {

        }

        public virtual DbSet<ImagenEntity> ImagenEntity { get; set; }
    }
}