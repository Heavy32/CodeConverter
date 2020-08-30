using System.Text;

namespace CodeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            EncodeConverter encodeConverter = new EncodeConverter("UTF-8", "windows-1251");
            DisplayConsole displayConsole = new DisplayConsole();
            Converter converter = new Converter(encodeConverter, displayConsole);

            while (true)
            {
                converter.ConvertAndDisplay();
            }
        }
    }
}
