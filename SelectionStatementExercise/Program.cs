namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.Write("What is your favorite number?: ");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("Really, human? This is your favorite number?");
            }
            else 
            { 
                Console.WriteLine("Hmmm... I thought it was your favorite number...");
            }

        }
    }
}
