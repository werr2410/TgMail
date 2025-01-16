// Testing Telegram Bot

using TelegramClient;
using Microsoft.Extensions.Configuration;

Console.WriteLine(Directory.GetCurrentDirectory());

string? token = BotClient.GetTokenFromJson();
BotClient botClient;

if(token is not null) {
    botClient = new BotClient(token);
    botClient.Start();

    System.Console.WriteLine("Press any key... ");
    Console.ReadKey();
} else 
    System.Console.WriteLine("Token is null");


