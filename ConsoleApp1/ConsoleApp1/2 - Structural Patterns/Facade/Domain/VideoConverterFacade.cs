using ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework;

namespace ConsoleApp1.StructuralPatterns.Facade.Domain
{
    public sealed class VideoConverterFacade : IVideoConverterFacade
    {
        public VideoConverted Convert(string filename)
        {
            var videoFile = new VideoFile(filename);
            var sourceCodec = CodecFactory.Extract(videoFile);
            var buffer = BitrateReader.Read(filename, sourceCodec);
            var extension = filename.Split('.').Last();
            CompressionCodec codec;

            if (extension == "mp4")
            {
                codec = new OggCompressionCodec();
            }
            else
            {
                codec = new MPEG4CompressionCodec();
            }

            var result = BitrateReader.Convert(buffer, codec);
            AudioMixer.Fix(result);

            return result;
        }
    }
}
