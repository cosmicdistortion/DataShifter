using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cosmicdistortion.DataShifter.Models
{
    public class SqlScriptTemplate
    {
        public int SqlScriptTemplateId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Template { get; set; }
    }
}