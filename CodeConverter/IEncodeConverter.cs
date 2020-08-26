namespace CodeConverter
{
    public interface IEncodeConverter
    {
        public string InputEncode { get; set; }
        public string OutputEncode { get; set; }
        public string Convert(string input);
    }
}
