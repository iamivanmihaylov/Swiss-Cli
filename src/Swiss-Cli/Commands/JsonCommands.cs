using Cocona;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swiss_Cli.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiss_Cli.Commands
{
    public class JsonCommands : ICliCommand
    {
        [Command("prettify")]
        public void Prettify([Argument] string text)
        {
            object jsonAsObject = JsonConvert.DeserializeObject(text);
            Console.WriteLine(JsonConvert.SerializeObject(jsonAsObject, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
            }));
        }
    }
}
