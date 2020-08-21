using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogg.Models
{
    public class AppIdentitiyDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppIdentitiyDbContext(DbContextOptions<AppIdentitiyDbContext> options) : base(options)
        {

        }
    }
}
