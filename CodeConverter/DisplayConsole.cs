using System;

namespace CodeConverter
{
    public class DisplayConsole : IDisplayConverter
    {
        public string InputInfo { get; set; }

        public void Input()
        {
            Console.WriteLine("To convert, write text and press Enter: ");
            InputInfo = Console.ReadLine();

            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
        }

        public void Output(string convertedText)
        {
            Console.WriteLine("Converted text: ");
            Console.WriteLine(convertedText);
            Console.WriteLine();
        }
    }
}
