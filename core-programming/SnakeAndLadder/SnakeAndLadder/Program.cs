using System;

class SnakeAndLadder
{
    const int WINNING_POSITION = 100;

    static void Main()
    {
        Console.WriteLine("=== Snake and Ladder Game ===");

        int player1Position = 0;
        int player2Position = 0;

        int diceCount = 0;
        bool isPlayer1Turn = true;

        Random random = new Random();

        while (player1Position < WINNING_POSITION && player2Position < WINNING_POSITION)
        {
            int dice = random.Next(1, 7);
            diceCount++;

            int option = random.Next(0, 3); 

            if (isPlayer1Turn)
            {
                Console.WriteLine($"\nPlayer 1 rolls dice: {dice}");
                player1Position = MovePlayer(player1Position, dice, option);
                Console.WriteLine($"Player 1 position: {player1Position}");

                if (option != 1) 
                    isPlayer1Turn = false;
            }
            else
            {
                Console.WriteLine($"\nPlayer 2 rolls dice: {dice}");
                player2Position = MovePlayer(player2Position, dice, option);
                Console.WriteLine($"Player 2 position: {player2Position}");

                if (option != 1)
                    isPlayer1Turn = true;
            }
        }

        Console.WriteLine("\n=== Game Over ===");
        Console.WriteLine(player1Position == WINNING_POSITION ? "Player 1 Wins!" : "Player 2 Wins!");
        Console.WriteLine($"Total Dice Rolls: {diceCount}");
    }

    static int MovePlayer(int position, int dice, int option)
    {
        switch (option)
        {
            case 0:
                Console.WriteLine("No Play");
                break;

            case 1: 
                Console.WriteLine("Ladder");
                if (position + dice <= WINNING_POSITION)
                    position += dice;
                break;

            case 2: 
                Console.WriteLine("Snake");
                position -= dice;
                if (position < 0)
                    position = 0;
                break;
        }

        return position;
    }
}
