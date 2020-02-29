using System;
using System.Text;
using System.IO;

namespace sonictxt
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                return;
            }

            string text = File.ReadAllText(args[0]);
            string[] arr = text.Split("\r\n\r\n");

            string data = "";
            for (int i = 0; i < arr.Length; i++) {
                data += $"[{i}]\n{arr[i]}\n";
            }
            File.WriteAllText(Path.GetFileName(args[0]) + "_count.txt", data);
        }
    }
}
