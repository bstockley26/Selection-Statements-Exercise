namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 5);

            Console.WriteLine("Hello!! Welcome to my game!!!Try and guess the correct number between 1-5");

            int userInput = int.Parse(Console.ReadLine());



            if (userInput == favNumber)
            {
                Console.WriteLine("Congrats you guessed it Correct!!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Nope that is too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Nope that is too high!!");
            }

        }

       
    }
}
