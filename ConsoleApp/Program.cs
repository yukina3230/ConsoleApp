using System.Collections;
using ConsoleApp;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int index = 0;
char input = 'y';
Cau1 cau1 = new Cau1();
Cau2 cau2 = new Cau2();
Cau3 cau3 = new Cau3();

while (input == 'y')
{
    Console.WriteLine("1 - Câu 1 \n2 - Câu 2 \n3 - Câu 3 \n");
    index = cau1.ValidateNumbericInput("Chọn câu: ", index);
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

    ValidateInput("Làm lại? (y/n)", input = Console.ReadKey().KeyChar);
}

void ValidateInput(string str, char input)
{
    Console.WriteLine(str);
    while (input != 'y' || input != 'n')
    {
        Console.Write(str);
        input = Console.ReadKey().KeyChar;
    }
}
