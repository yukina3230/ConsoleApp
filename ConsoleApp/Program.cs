using System.Collections;
using ConsoleApp;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int index = 0;
string input = "y";
Cau1 cau1 = new Cau1();
Cau2 cau2 = new Cau2();
Cau3 cau3 = new Cau3();

while (input == "y")
{
    Console.WriteLine("1 - Câu 1 \n2 - Câu 2 \n3 - Câu 3 \n");
    ValidateIndexInput("Chọn câu: ");
    Console.WriteLine();

    switch (index)
    {
        case 1:
            cau1.Run();
            break;

        case 2:
            cau2.Run();
            break;

        case 3:
            cau3.Run();
            break;
    }

    ValidateInput("Làm lại? (y/n)");
}

void ValidateIndexInput(string str)
{
    index = cau1.ValidateNumbericInput(str, index);
    if (index != 1 && index != 2 && index != 3)
    {
        ValidateIndexInput(str);
    }
}

void ValidateInput(string str)
{
    Console.Write($"\n{str} - ");
    input = Console.ReadLine();
    Console.WriteLine();
    if (input != "y" && input != "n")
    {
        ValidateInput(str);
    }
}
