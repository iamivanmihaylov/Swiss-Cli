using Swiss_Cli.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiss_Cli.Commands
{
    public class JsonCommands : ICommand
    {
        public void Format(string inputJson)
        {
            Console.WriteLine(inputJson);
        }
    }
}
