using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Cau1
    {
        int n = 0, near = 0;
        int[] arr;
        double avg = 0;
        List<int> list = new List<int>();
        
        public void Run()
        {
            n = ValidateNumbericInput("Nhập số phần tử: ", n);
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            avg = Queryable.Average(arr.AsQueryable());
            NguyenTo(arr, 0);

            Console.WriteLine($"Số trung bình của mảng: {avg}");
            Console.WriteLine($"Số nguyên tố trong mảng: {InMang(list)}");
            Console.WriteLine($"Số nguyên tố gần trung binh nhất: {near}");
        }

        void NguyenTo(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return;
            }
            if (KiemTraNguyenTo(arr[index]))
            {
                list.Add(arr[index]);
                if (Math.Abs(avg - arr[index]) < Math.Abs(avg - near))
                {
                    near = arr[index];
                }
            }
            NguyenTo(arr, index + 1);
        }

        bool KiemTraNguyenTo(int n)
        {
            if (n <= 2)
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

        string InMang(List<int> list)
        {
            string srtBuilder = "";
            foreach (var item in list)
            {
                srtBuilder += $"{item} ";
            }
            return srtBuilder;
        }

        public int ValidateNumbericInput(string str, int n)
        {
            Console.Write(str);
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write(str);
            }
            return n;
        }
    }
}