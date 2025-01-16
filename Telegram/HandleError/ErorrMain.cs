using Telegram.Bot;
using Telegram.Bot.Exceptions;

namespace TelegramClient {
    public partial class BotClient {
        private Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var errorMessage = exception switch
            {
                ApiRequestException apiEx => $"Ошибка API Telegram: {apiEx.ErrorCode} - {apiEx.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(errorMessage);
            return Task.CompletedTask;
        }
    }
}