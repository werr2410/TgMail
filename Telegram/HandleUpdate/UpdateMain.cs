using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TelegramClient {
    public partial class BotClient {
        private async Task OnUpdate(Update update) {
            if (update is { CallbackQuery: { } query }) {
                await _botClient.AnswerCallbackQuery(query.Id, $"You picked {query.Data}");
                await _botClient.SendMessage(query.Message!.Chat, $"User {query.From} clicked on {query.Data}");
            }
        }
    }
}