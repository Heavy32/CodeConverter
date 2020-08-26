using System.Text;

namespace CodeConverter
{
    public class EncodeConverter : IEncodeConverter
    {
        public string InputEncode { get; set; }
        public string OutputEncode { get; set; }

        public EncodeConverter(string inputEncode, string outputEncode)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InputEncode = inputEncode;
            OutputEncode = outputEncode;
        }
      
        public string Convert(string input)
        {
            Encoding inputFormat = Encoding.GetEncoding(InputEncode);
            Encoding ouputFormat = Encoding.GetEncoding(OutputEncode);

            byte[] inputFormatBytes = ouputFormat.GetBytes(input);
            byte[] outputFormatBytes = Encoding.Convert(inputFormat, ouputFormat, inputFormatBytes);

            return ouputFormat.GetString(outputFormatBytes);
        }
    }
}
