using System;



namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer1 = Add(2, 2);
            var answer2 = Add(3.55m, 32.002m);
            var answer3 = Add(2, 2, true);

            Console.WriteLine(answer1);
            Console.WriteLine(answer2); 
            Console.WriteLine(answer3);
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int x, int y, bool whatever)
        {
            if (whatever && x + y != 1)
            {
                return $"{x + y} Dollers";
            }   
            else if (whatever && x + y == 1)
            {
                return $"{x + y} Doller";
            }
            else
            {
                return x + y.ToString();
            }
        }
    }
}
