namespace ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework
{
    public static class BitrateReader
    {
        public static string Read(string filename, string sourceCodec)
        {
            // Logic to read the filename and de source code
            return $"{filename}_{sourceCodec}";
        }

        public static VideoConverted Convert(string buffer, CompressionCodec codec)
        {
            return new VideoConverted(buffer, codec);
        }
    }
}
