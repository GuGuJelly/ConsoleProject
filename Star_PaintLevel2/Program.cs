namespace Star_PaintLevel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++) 
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
