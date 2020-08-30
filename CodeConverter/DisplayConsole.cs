using System;
using System.Text;

namespace CodeConverter
{
    public class DisplayConsole : IDisplayConverter
    {
        public string InputInfo { get; set; }

        public void Input()
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("windows-1251");
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.WriteLine("To convert, write text and press Enter: ");
            InputInfo = Console.ReadLine();

            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
        }

        public void Output(string convertedText)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.WriteLine("Converted text: ");
            Console.WriteLine(convertedText);
            Console.WriteLine();
        }
    }
}
