for (; ; )
{
    for (int i = 0; i < 100; i += 10)
    {
        Console.Write(i);
        Thread.Sleep(250);
        Console.Clear();
    }
    for (int i = 90; i > 0; i -= 10)
    {
        Console.Write(i);
        Thread.Sleep(250);
        Console.Clear();
    }
}
