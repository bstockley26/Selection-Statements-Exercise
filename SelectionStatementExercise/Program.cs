namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 30);

            Console.WriteLine("Hello!! Welcome to my game!!! Guess a number between 1-30");

            int userInput = int.Parse(Console.ReadLine());



            if (userInput == 26)
            {
                Console.WriteLine("Congrats you guessed it Correct!!");
            }
            else if (userInput < 26)
            {
                Console.WriteLine("Nope that is too low!");
            }
            else if (userInput > 26)
            {
                Console.WriteLine("Nope that is too low!!");
            }

        }

       
    }
}
