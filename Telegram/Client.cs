using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace TelegramClient {
    public partial class BotClient {
        private readonly TelegramBotClient _botClient;

        public BotClient(string token) {
            _botClient = new TelegramBotClient(token);
        }

        public void Start() {

            var receiverOptions = new ReceiverOptions {
                AllowedUpdates = Array.Empty<UpdateType>()
            };

            _botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions
            );

            System.Console.WriteLine("Telegram-Bot have been started");
        }
    }
}