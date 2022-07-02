using ConsoleApp;

List<Character> characterList = new List<Character>();

Character testChar = new Wizard();

characterList.Add(new Wizard("Aaron", 1, "Wizard"));
characterList.Add(new Knight("Amir", 5, "Knight"));

foreach (var item in characterList)
{
    item.UseUltimate();
}

Static.MaxLevel = 20;
Console.WriteLine(Static.MaxLevel);