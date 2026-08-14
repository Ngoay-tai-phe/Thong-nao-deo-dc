namespace cây_thông
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i<=n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k=1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();

            }
            int a;
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int b = 1; b <= a; b++)
            {
                for (int e = 1; e <= 2 * a - (2 * b - 1); e++)
                    Console.WriteLine("*");
                for (int d = 1; d <= b-1; d++)
                    Console.WriteLine(" ");
            }
        }
    }
}
