using Cocona;
using Swiss_Cli.Extensions;
using System.Text.Json;

var builder = CoconaApp.CreateBuilder();

var app = builder.Build();

app.AutoRegisterCommands(typeof(Program));

app.Run();