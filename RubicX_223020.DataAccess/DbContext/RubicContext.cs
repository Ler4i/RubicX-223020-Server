using Microsoft.EntityFrameworkCore;
using RubicX_223020DataAccess.Core.Interfaces.DbContext;
using RubicX_223020DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RubicX_223020.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) : base(options)
        {
            
        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }

    }
}
