using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Euricom.Timesheets.Web.Models;

namespace Euricom.Timesheets.Web.Infrastructure
{
    public class EFContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
    }
}