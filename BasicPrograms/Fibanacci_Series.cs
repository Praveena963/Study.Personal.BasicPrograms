namespace BasicPrograms
{
    public class Fibanacci_Series
    {
        //static int a = 0;static int b = 1; static int c;
        static void Main()
        {
            int a = 0;  int b = 1; 
            int c;
            Console.WriteLine("Series is");
            Console.Write(a + "" + b);


            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(c);
                a = b; b = c;
            }
            Console.WriteLine();
        }
    }
}
