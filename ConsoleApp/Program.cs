using System.Collections;

int n = 0, near = 0;
int[] arr = new int[0];
double avg = 0;
ArrayList list = new ArrayList();

Console.WriteLine("Nhap n: ");
n = int.Parse(Console.ReadLine());
arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

avg = Queryable.Average(arr.AsQueryable());
near = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (KiemTraNguyenTo(arr[i]))
    {
        list.Add(arr[i]);
    }
}
Console.WriteLine($"Trung binh cua mang: {avg}");
Console.WriteLine($"So nguyen to gan nhat: {TimSoGanNhat()}");

bool KiemTraNguyenTo(int n)
{
    if (n < 2)
    {
        return false;
    }
    else
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

int TimSoGanNhat()
{
    for (int i = 0; i < list.Count; i++)
    {
        if (Math.Abs(avg - (int)list[i]) < Math.Abs(avg - near))
        {
            near = (int)list[i];
        }
    }
    return near;
}
