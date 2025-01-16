using TelegramClient;

Console.WriteLine(Directory.GetCurrentDirectory());

string? token = BotClient.GetTokenFromJson();
BotClient botClient;

if(token is not null) {
    botClient = new BotClient(token);
    botClient.Start();
} else 
    System.Console.WriteLine("Token is null");


