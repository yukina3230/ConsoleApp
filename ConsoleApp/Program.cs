using ConsoleApp;

List<Character> characterList = new List<Character>();

Wizard megumin = new Wizard("Megumin", 11, "Wizard");

Character wiz = new Wizard("Wiz", 9, "Wizard");

characterList.Add(new Wizard("Aaron", 1, "Wizard"));
characterList.Add(new Sorcerer("Alexa", 20, "Sorcerer"));
characterList.Add(new Knight("Amir", 5, "Knight"));
characterList.Add(new Hobo("Herb", 9, "Hobo"));

foreach (var item in characterList)
{
    item.Walk();
    item.Attack();
    if (item is IUseUltimate)
    {
        var i = item as IUseUltimate;
        i.UseUltimate();
    }
    if (item is ICanDoAlchemy)
    {
        var i = item as ICanDoAlchemy;
        i.DoAlchemy();
    }
}

Static.MaxLevel = 20;
Static.PrintMaxLevel();