using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TelegramClient {
    public partial class BotClient {
        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken) {
            if(update.Message is not null && update.Message.Text is not null) {
                var message = update.Message;

                await botClient.SendMessage(
                    chatId: message.Chat.Id,
                    text: message.Text,
                    cancellationToken: cancellationToken
                );    
            }
        }
    }
}