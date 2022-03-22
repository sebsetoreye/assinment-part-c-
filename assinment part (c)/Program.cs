
int WL;

WL = 0;

string WC, aw;

Console.Write("Please Input You're String : ");
WC = Console.ReadLine();


string[] words = WC.Split(' ');

foreach (var word in words)
{
    WL += 1;
    Console.WriteLine(WL);
    if (WL == 8)
    {
        goto ASCII_code;
    }
    else if (WL == 9)
    {
        Console.WriteLine("This String is to big");
        System.Environment.Exit(0);
    }
}
ASCII_code:
Console.WriteLine("hello");