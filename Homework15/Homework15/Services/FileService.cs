using Services.Abstractions;

namespace Services
{
    internal class FileService : IFileService
    {
        public async Task<string> ReadHelloAsync()
        {
            using (var reader = new StreamReader("Hello.txt"))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public async Task<string> ReadWorldAsync()
        {
            using (var reader = new StreamReader("World.txt"))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public async Task<string> ConcatenateAsync()
        {
            Task<string> helloFile = ReadHelloAsync();
            Task<string> worldFile = ReadWorldAsync();

            await Task.WhenAll(helloFile, worldFile);

            return helloFile.Result + worldFile.Result;
        }
    }
}
