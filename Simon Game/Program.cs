// See https://aka.ms/new-console-template for more information



Random numberGenerator = new Random();

int userWins = 0;
int computerWins = 0;

while (userWins < 3 && computerWins < 3)
{
    Console.WriteLine("Write R(Rock), P(Paper), S(Scissors)");

    char user = char.ToUpper(Console.ReadLine()[0]);
    int computerNumber = numberGenerator.Next(3);
    char computer = 'R';

    string[] computerMove = { "Rock", "Paper", "Scissors" };

    switch (computerNumber)
    {
        case 0:
            computer = 'R';
            break;
        case 1:
            computer = 'P';
            break;
        case 2:
            computer = 'S';
            break;
        default:
            Console.WriteLine("Game");
            break;
    }
    Console.WriteLine("Computer Move: " + computerMove[computerNumber]);

    if (user == computer)
    {
        Console.WriteLine("It's A Draw :|");
    }
    else if ((user == 'P' && computer == 'R') || (user == 'R' && computer == 'S') || (user == 'S' && computer == 'P'))
    {
        Console.WriteLine("You Win ;)");
        userWins++;
    }
    else
    {
        Console.WriteLine("Computer Wins :(");
        computerWins++;
    }
    Console.WriteLine("Your Score: " + userWins + " Computers Score: " + computerWins);
}
