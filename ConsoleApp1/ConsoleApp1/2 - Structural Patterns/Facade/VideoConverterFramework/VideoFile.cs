namespace ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework
{
    public sealed class VideoFile
    {
        public string Filename { get; }

        public VideoFile(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentNullException("O nome do arquivo deve ser passado.");
            }

            Filename = filename;
        }
    }
}
