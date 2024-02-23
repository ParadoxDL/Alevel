using Services.Abstractions;
using Services;

namespace Homework15
{
    internal class Program
    {
        static async Task Main()
        {
            File.WriteAllText("Hello.txt", "Hello");
            File.WriteAllText("World.txt", "World");

            IFileService fileService = new FileService();
            string result = await fileService.ConcatenateAsync();

            Console.WriteLine(result);
        }
    }
}
