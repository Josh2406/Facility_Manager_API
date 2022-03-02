using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacilityManager.Infrastructure.Persistence.Contexts
{
    public class FacilityManagerDbContext: DbContext
    {
        public FacilityManagerDbContext(DbContextOptions<FacilityManagerDbContext> options): base(options) { }
    }
}
