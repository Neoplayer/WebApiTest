// See https://aka.ms/new-console-template for more information

using Home.Core.Models;

Console.WriteLine(string.Join('\n', Enum.GetNames(typeof(EModule)).ToList().Select(x => $"EModule.{x} => new {x}(pin),")));

foreach (var a in Enum.GetNames(typeof(EModule)))
{
}

// foreach (var a in Enum.GetNames(typeof(EModule)))
// {
//     File.WriteAllText("/home/neerd/RiderProjects/WebApiTest/Home.Core/Modules/" + a + ".cs", @"using Home.Core.Models;
//
// namespace Home.Core.Modules
// {
//     public class " + a + @" : ModuleBase 
//     {
//         public " + a + @" (string pin) : base(pin)
//         {
//             ModuleType = EModule." + a + @";
//             Name = """ + a + @""";
// }
//
// public string GetPin() => Pin;
// public EModule GetType() => ModuleType;
// public string GetName() => Name;
// }
// }");
// }