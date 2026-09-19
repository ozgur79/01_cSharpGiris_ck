int renk = 0;
for (int i = 0; i < 16; i++)
{
    Console.BackgroundColor = (ConsoleColor)renk;
    Console.Clear();
    Thread.Sleep(400);
    renk++;
}
Console.ReadKey();
