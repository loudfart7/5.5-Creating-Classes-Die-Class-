namespace _5._5_Creating_Classes__Die_Class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die();

            if (die1.Roll == die2.Roll)
                Console.WriteLine("DOUBLES");
            else
                Console.WriteLine("NOT DOUBLES");

            Console.WriteLine();

            if (die1.Roll + die2.Roll == 7)
                Console.WriteLine("THE SUM OF YOUR DIE IS SEVEN");
            else
                Console.WriteLine("THE SUM OF YOUR NUMBERS IS NOT SEVEN");

            Console.WriteLine();

            if (die1.Roll==1 && die2.Roll == 1)
                Console.WriteLine("SNAKE EYES!");

            if ((die1.Roll + die2.Roll) % 2 == 0)
                Console.WriteLine("EVEN SUM");

            Console.WriteLine();

            if (die1.Roll == die2.Roll + 1 || die2.Roll == die1.Roll + 1)
                Console.WriteLine("SEQUENTIAL ROLL");
            else
                Console.WriteLine("NOT SEQUENTIAL");

            Console.WriteLine();

            die1.DrawDie();
            die2.DrawDie();

            //die1.RollDie();
            //Console.WriteLine(die1);
            //die1.DrawDie();
            Console.ReadLine();

        }
    }
}
