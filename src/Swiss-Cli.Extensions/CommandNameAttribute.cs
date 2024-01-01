using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiss_Cli.Extensions
{
    public class CommandNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
