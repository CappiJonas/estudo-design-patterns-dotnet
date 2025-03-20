using ConsoleApp1.StructuralPatterns.Facade.Domain;
using ConsoleApp1.StructuralPatterns.Facade.VideoConverterFramework;

namespace ConsoleApp1.StructuralPatterns.Facade
{
    public static class FacadeExecutor
    {
        public static void Execute()
        {
            string filename1 = "dogs.ogg";
            string filename2 = "cats.mp4";

            Console.WriteLine($"Começando a conversão dos vídeos '{filename1}' e '{filename2}'");

            var controller = new VideoConverterController(new VideoConverterFacade());
            
            var videoConverted1 = controller.Convert(filename1);
            var videoConverted2 = controller.Convert(filename2);

            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("Vídeos convertidos.");
            Console.WriteLine($"Vídeo {filename1} convertido para {videoConverted1.Filename} e audio {IsFixed(videoConverted1)}");
            Console.WriteLine($"Vídeo {filename2} convertido para {videoConverted2.Filename} e audio {IsFixed(videoConverted2)}");
        }

        private static string IsFixed(VideoConverted videoConverted)
        {
            return videoConverted.AudioFixed ? "consertado" : "não consertado";
        }
    }
}
