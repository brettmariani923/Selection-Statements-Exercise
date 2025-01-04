namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 23;

            Console.WriteLine("Guess my favorite number?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput <= 22)
            {
                Console.WriteLine("Too low, buddy!");
            }
            else if (userInput >= 24)
            {
                Console.WriteLine("Too high, buckwheat");
            }
            else
            {
                Console.WriteLine("YOU DID IT!!!");
            }
        }
    }
}
