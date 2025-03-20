using ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework;

namespace ConsoleApp1.StructuralPatterns.Facade.Domain
{
    public sealed class VideoConverterController
    {
        private readonly IVideoConverterFacade _facade;

        public VideoConverterController(IVideoConverterFacade facade)
        {
            _facade = facade;
        }

        public VideoConverted Convert(string filename)
        {
            return _facade.Convert(filename);
        }
    }
}
