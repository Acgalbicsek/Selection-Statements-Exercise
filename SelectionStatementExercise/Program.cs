namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Random r = new Random(); //This line creates a new `Random` object, which is used to generate random numbers.
            int favNumber = r.Next(1, 11);  //This line generates a random integer between 1 and 999 and assigns it to the `favNumber` variable.
            int userInput = 0;

            while (userInput != favNumber)
            {


                Console.WriteLine("Guess my favorite number:");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"Too low!\nYour guess: {userInput}");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"Too High!\nYour guess: {userInput}");
                }
                else
                {
                    Console.WriteLine($" Yup! You got it!");
                }

            }
        }
    }
}
