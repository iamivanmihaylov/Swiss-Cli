using Cocona;
using Cocona.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Swiss_Cli.Extensions
{
    public static class AutoCommandRegister
    {
        public static void AutoRegisterCommands(this ICoconaCommandsBuilder builder, Type startup)
        {
            var allCommands = startup
                .Assembly
                .GetTypes()
                .Where(x => typeof(ICliCommand).IsAssignableFrom(x) && x.IsClass);

            foreach (var command in allCommands) 
            {
                var commandAttribute = command.GetCustomAttribute(typeof(CommandNameAttribute)) as CommandNameAttribute;

                string commandName;
                if (commandAttribute is null)
                {
                    commandName = command
                    .Name
                    .Replace("Commands", string.Empty)
                    .ToLower();
                }
                else
                {
                    commandName = commandAttribute.Name.ToLower();
                }

                builder.AddSubCommand(commandName, configuration =>
                {
                    configuration.AddCommands(command);
                });
            }
        }
    }
}
