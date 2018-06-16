using System;

namespace Excercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("入力された数値だけ回数を表示する");
            var inputText = Console.ReadLine();
            Console.WriteLine("入力された値（回数）" + inputText);

            int i = 0;
            if (int.TryParse(inputText, out i) && i > 0)
            {
                for (int n = 1; n <= i; n++)
                {
                    Console.WriteLine(n + "回 Hello World");
                }
            }
            else
            {
                Console.Write("※入力エラーです");
            }
        }
    }
}
