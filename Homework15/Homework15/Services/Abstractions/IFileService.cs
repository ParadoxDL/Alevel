namespace Services.Abstractions
{
    internal interface IFileService
    {
        Task<string> ReadHelloAsync();
        Task<string> ReadWorldAsync();
        Task<string> ConcatenateAsync();
    }
}
