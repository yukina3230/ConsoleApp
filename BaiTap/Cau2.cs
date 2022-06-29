using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class Cau2
    {
        string str = "", strSpace = "", strCase = "", strASCII = "";
        int characterCount = 0, wordCount = 0;
        public void Run()
        {
            DoingStuff();
        }
        
        void DoingStuff()
        {
            Console.Write("Nhập chuỗi: ");
            str = Console.ReadLine();
            strCase = "";

            characterCount = str.Count(c => !Char.IsWhiteSpace(c));
            str.Split(' ').ToList().ForEach(x =>
            {
                if (x != "")
                {
                    strSpace += x + " ";
                    strCase += ChangeCase(x) + " ";
                    strASCII += MoveToNextASCII(x) + " ";
                    wordCount++;
                }
            });
            Console.WriteLine($"Chuỗi đã xoá khoảng trắng thừa: {strSpace}");
            Console.WriteLine($"Chuỗi đã chuyển Case: {strCase}");
            Console.WriteLine($"Chuỗi đã mã hoá ASCII: {strASCII}");
            Console.WriteLine($"Số ký tự: {characterCount}");
            Console.WriteLine($"Số từ: {wordCount}");
        }

        string ChangeCase(string str)
        {
            return str.Substring(0, 1).ToLower() + str.Substring(1).ToUpper();
        }

        string MoveToNextASCII(string str)
        {
            string _str = "";
            byte[] asciiBytes = Encoding.ASCII.GetBytes(str);

            foreach (var chr in asciiBytes)
            {
                _str += (char)(chr + 3);
            }
            return _str;
        }
    }
}
