namespace _5._5_Creating_Classes__Die_Class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            die1 = new Die();
            die2 = new Die(-10);

            Console.WriteLine(die1);
            die1.DrawDie();

            die1.RollDie();
            Console.WriteLine(die1);
            die1.DrawDie();


        }
    }
}
