namespace ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework
{
    public sealed class MPEG4CompressionCodec : CompressionCodec
    {
        public override string GetExtensionConverted()
        {
            return ".mp4";
        }
    }
}
