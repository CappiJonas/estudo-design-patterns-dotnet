namespace ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework
{
    public static class CodecFactory
    {
        public static string Extract(VideoFile videoFile)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
