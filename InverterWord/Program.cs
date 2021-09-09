using System;
namespace InverterWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la palabra:");
            string wordchoose = Console.ReadLine();
            string wordinverter = InverterModel.InvertWord(wordchoose);
            Console.WriteLine(wordinverter);
        }
    }
}
