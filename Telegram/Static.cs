using Microsoft.Extensions.Configuration;

namespace TelegramClient {
    public partial class BotClient {
        public static string? GetTokenFromJson() {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("Settings/appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile("Settings/appsettings.local.json", optional: true, reloadOnChange: true)
            .Build();

            return configuration["BotToken"];
        }
    }
}