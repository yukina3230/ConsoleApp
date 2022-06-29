using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class Cau3
    {
        public void Run()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] lines = File.ReadAllLines($"{desktopPath}\\test.txt");
            int row = int.Parse(lines[0]), col = int.Parse(lines[1]);
            int[,] matrix;

            matrix = TaoMaTran(row, col, lines);
            InMaTran(row, col, matrix);
            TimViTri(matrix);
            GiaTriLonNhat(matrix);
            TongTrungBinh(matrix);
        }

        int[,] TaoMaTran(int row, int col, string[] lines)
        {
            int r = 0;
            int[,] matrix = new int[row, col];
            for (int i = 2; i < lines.Length; i++)
            {
                string[] arr = lines[i].Split(' ');
                int[] numberArr = Array.ConvertAll(arr, int.Parse);
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = numberArr[c];
                }
                r++;
            }
            return matrix;
        }
        
        void InMaTran(int row, int col, int[,] matrix)
        {
            Console.WriteLine(row);
            Console.WriteLine(col);
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        void TimViTri(int[,] matrix)
        {
            int viTri = matrix[matrix.GetLength(0) - 1, 0];

            Console.WriteLine($"Vị trí cột bé nhất, dòng lớn nhất có giá trị: {viTri}");
        }

        void GiaTriLonNhat(int[,] matrix)
        {
            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Giá trị lớn nhất của ma trận là: {max}");
        }

        void TongTrungBinh(int[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine($"Tổng trung bình của ma trận là: {Math.Round(sum / matrix.Length, 2)}");
        }
    }
}
