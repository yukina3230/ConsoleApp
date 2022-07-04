using ConsoleApp;

List<Character> characterList = new List<Character>();

characterList.Add(new Wizard("Aaron", 1, "Wizard"));
characterList.Add(new Knight("Amir", 5, "Knight"));
characterList.Add(new Hobo("Herb", 5, "Hobo"));

foreach (var item in characterList)
{
    item.Attack();
    if (item is IUseUltimate)
    {
        var i = item as IUseUltimate;
        i.UseUltimate();
    }
}

Static.MaxLevel = 20;
Console.WriteLine(Static.MaxLevel);