using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Euricom.Timesheets.Web.Models;

namespace Euricom.Timesheets.Web.Infrastructure
{
    public class EFContextSeedInitializer : DropCreateDatabaseIfModelChanges<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            context.Applications.Add(new Application { Name = "TimesheetsApp" });
            base.Seed(context);
        }
    }
}