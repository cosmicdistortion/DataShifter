using Cosmicdistortion.DataShifter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cosmicdistortion.DataShifter
{
    public class ShifterContext : DbContext
    {
        public ShifterContext() : base()
        {

        }

        public DbSet<DBConnection> DBConnections { get; set; }
        public DbSet<SqlScriptTemplate> SqlScriptTemplates { get; set; }
    }
}