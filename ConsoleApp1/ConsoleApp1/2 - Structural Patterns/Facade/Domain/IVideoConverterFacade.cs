using ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework;

namespace ConsoleApp1.StructuralPatterns.Facade.Domain
{
    public interface IVideoConverterFacade
    {
        VideoConverted Convert(string filename);
    }
}
