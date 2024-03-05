using Models;
using Newtonsoft.Json;
using Services.Abstractions;

namespace Services
{
    class ConfigSevice : IConfigService
    {
        public void GenerateConfig(string configFile)
        {
            Random random = new Random();
            int randomConfigNumber = random.Next(1, 101);

            var config = new Number
            {
                ConfigNumber = randomConfigNumber
            };

            string jsonConfig = JsonConvert.SerializeObject(config, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(configFile, jsonConfig);

            Console.WriteLine($"Config file generated at: {configFile}");
        }
    }
}
