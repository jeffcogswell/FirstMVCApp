using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace FirstWebApp.Models
{
    public class WebUser
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
