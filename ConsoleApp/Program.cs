using ConsoleApp;

List<IUltimate> characterList = new List<IUltimate>();
var playerControler = new Player();


characterList.Add(new Wizard("Wizard"));
characterList.Add(new Knight("Knight"));

foreach (var item in characterList)
{
    item.UseUltimate();
}

Static.MaxLevel = 20;
Console.WriteLine(Static.MaxLevel);