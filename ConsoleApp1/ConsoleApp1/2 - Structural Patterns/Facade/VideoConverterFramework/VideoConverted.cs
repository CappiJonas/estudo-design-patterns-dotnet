namespace ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework
{
    public sealed class VideoConverted
    {
        public string Filename { get; }
        public CompressionCodec CompressionCodec { get; }
        public bool AudioFixed { get; private set; }

        public VideoConverted(string buffer, CompressionCodec compressionCodec)
        {
            string[] partsOfBuffer = buffer.Split('_');
            CompressionCodec = compressionCodec;
            string extension = CompressionCodec.GetExtensionConverted();
            Filename = $"{partsOfBuffer[0].Split('.')[0]}{extension}";
        }

        public void FixAudio()
        {
            AudioFixed = true;
        }
    }
}
