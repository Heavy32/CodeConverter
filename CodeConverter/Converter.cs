namespace CodeConverter
{
    public class Converter
    {
        public IEncodeConverter EncodeConverter { get; }
        public IDisplayConverter Display { get; }

        public Converter(IEncodeConverter encodeConverter, IDisplayConverter display)
        {
            EncodeConverter = encodeConverter;
            Display = display;
        }

        public void ConvertAndDisplay()
        {
            Display.Input();
            Display.Output(EncodeConverter.Convert(Display.InputInfo));     
        }
    }
}
