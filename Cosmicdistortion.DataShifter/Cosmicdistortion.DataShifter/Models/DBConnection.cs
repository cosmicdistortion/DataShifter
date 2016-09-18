using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cosmicdistortion.DataShifter.Models
{
    public class DBConnection
    {
        public int DBConnectionId { get; set; }
        public string Name { get; set; }
        public string DataSource { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string InitialCatalog { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}