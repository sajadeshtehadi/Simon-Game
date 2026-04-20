// See https://aka.ms/new-console-template for more information



using Simon_Game;

Random numberGenerator = new Random();
List<char> moves = new List<char>();
char[] colors = { 'B', 'Y', 'G', 'R' };
int score = 0;

while (true)
{
    char steps = colors[numberGenerator.Next(colors.Length)];
    moves.Add(steps);

    for (int i = 0; i < moves.Count; i++)
    {
        Console.Clear();
        Console.WriteLine("=========");
        Console.WriteLine("Simon Version");
        Console.WriteLine("=========");
        Helper.ShowHeader(true, true, moves.Count);

        char color = moves[i];

        switch (color)
        {
            case 'B':
                Console.WriteLine("blue");
                break;
            case 'Y':
                Console.WriteLine("yellow");
                break;
            case 'G':
                Console.WriteLine("green");
                break;
            case 'R':
                Console.WriteLine("red");
                break;
            default:
                break;
        }
        Thread.Sleep(1000);
        Console.Clear();
        Helper.ShowHeader(true, true, moves.Count);
        Thread.Sleep(1000);
    }

    bool correct = true;

    for (int i = 0; i < moves.Count; i++)
    {
        Console.Clear();
        Helper.ShowHeader(true, true, moves.Count);

        string input = Console.ReadLine();
        char answer = char.ToUpper(input[0]);

        if (answer != moves[i])
        {
            Console.WriteLine("Game Over :/");
            Console.WriteLine("Your Score: " + score);
            return;
        }


        score++;
    }
    Console.WriteLine("New high score: " + moves.Count);
    Thread.Sleep(2000);
}
