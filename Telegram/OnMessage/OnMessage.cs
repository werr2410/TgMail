using System.Security.Cryptography.X509Certificates;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TelegramClient {
    public partial class BotClient {
        async Task OnMessage(Message msg, UpdateType type) {
            if (msg.Text == "/start")   {
                await _botClient.SendMessage(msg.Chat, "Welcome");
            } else {
                await _botClient.SendMessage(msg.Chat, "Invalid input parameters");
            }
        }
    }
}