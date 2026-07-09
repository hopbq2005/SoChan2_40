public class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 2; i <= 40; i += 2)
        {
            sum += i;
        }
        Console.WriteLine($"Tong so chan tu 2 den 40 la: {sum}");
    }
}