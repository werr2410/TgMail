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
            using var cts = new CancellationTokenSource();
            _botClient.OnError += OnError;
            _botClient.OnMessage += OnMessage;
            _botClient.OnUpdate += OnUpdate;

            Console.WriteLine("Bot is running... Press Enter to terminate");
            Console.ReadLine();
            cts.Cancel();
        }
    }
}