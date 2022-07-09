using System;
using RPG.ViewModels.Servies;
using Terminal.Gui;

void MainGameHandler()
{
    Application.Init();
    var main = Application.Top;

    var window = new Window("RPG")
    {
        X = 0,
        Y = 0,
        Width = Dim.Fill(),
        Height = Dim.Fill()
    };
    main.Add(window);


    Application.Run();
    Application.Shutdown();
}

MainGameHandler();