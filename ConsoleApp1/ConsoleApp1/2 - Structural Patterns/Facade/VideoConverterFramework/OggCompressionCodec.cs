namespace ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework
{
    public sealed class OggCompressionCodec : CompressionCodec
    {
        public override string GetExtensionConverted()
        {
            return ".ogg";
        }
    }
}
