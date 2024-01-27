
Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1, 101);

while (true)
{
    Console.Write("Guess a number (1 - 100): ");
    string playrInput = Console.ReadLine();
    bool isValid = int.TryParse(playrInput, out int playerNumber);

    if (isValid)
    {
        if (computerNumber == playerNumber)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if (playerNumber > computerNumber)
        {
            Console.WriteLine("Too High");
        }
        else
        {
            Console.WriteLine("Too Low");
        }
    }


}
