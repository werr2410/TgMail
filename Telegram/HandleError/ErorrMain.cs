using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;

namespace TelegramClient {
    public partial class BotClient {
        private static async Task OnError(Exception exception, HandleErrorSource source) {
            await Task.Delay(0);
            
            Console.WriteLine(exception);
        }
    }
}