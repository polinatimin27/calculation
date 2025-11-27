namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sulgude kasutamine");
            Console.WriteLine("kui palju on :3 + 5 / (4-2) * 4 =");

            double calculationi = 3 + 8 / (4-2) * 4;
            Console.WriteLine("Vaastus" + calculationi);
            double calculation2 = 3 + 8 / 4 - 2 * 4;
            Console.WriteLine("Vastus teise variant: " + calculation2);
            double calculation3 = (3 + 8) / (4 - 2) * 4;
            Console.WriteLine("Vastus teise variant: " + calculation3);
            double calculation4 = 3 + 8 / ((4 - 2) * 4);
            Console.WriteLine("Vastus teise variant: " + calculation4);

        }   
    }
}
