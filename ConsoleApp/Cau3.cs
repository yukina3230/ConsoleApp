using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Cau3
    {
        public void Run()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] lines = File.ReadAllLines($"{desktopPath}\\test.txt");
            int row = int.Parse(lines[0]), col = int.Parse(lines[1]);
            int[,] matrix = new int[row, col];

            Console.WriteLine(row);
            Console.WriteLine(col);
            
            for (int i = 2; i <= lines.Length; i++)
            {
                string[] arr = lines[i].Split(' ');
                int[] numberArr = Array.ConvertAll(arr, int.Parse);
                for (int c = 0; c < matrix.Length; c++)
                {

                }
            }
        }
    }
}
