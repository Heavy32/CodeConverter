namespace CodeConverter
{
    public interface IDisplayConverter
    {
        public string InputInfo { get; set; }

        public void Input();
        public void Output(string convertedText);
    }
}
