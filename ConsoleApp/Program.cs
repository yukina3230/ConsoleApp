using ConsoleApp;

List<Character> characterList = new List<Character>();
var playerControler = new Player();


characterList.Add(new Wizard());
characterList.Add(new Knight());
characterList.Add(new Hobo());

playerControler.DoingStuff(characterList);