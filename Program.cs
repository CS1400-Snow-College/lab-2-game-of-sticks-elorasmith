// See https://aka.ms/new-console-template for more information

//Elora Smith, 02/05/2025, Lab 2: Game of Sticks

//Step 1: Display instructions
Console.WriteLine("Welcome to Game of Sticks!");
Console.WriteLine("Players will take turns removing 1 to 3 sticks from the pile of 20 sticks. The player to pull the last stick loses!");

//Step 2: Set variables outside of block
int numberOfSticks = 20;
int maxSticks;
int currentPlayer = 1;

//Step 3:
while (numberOfSticks > 0)
{
    if (numberOfSticks >= 3)
    maxSticks = 3;
    else maxSticks = numberOfSticks;

    //Step 4:
    Console.WriteLine($"Sticks left: {numberOfSticks}");
    Console.WriteLine($"Player {currentPlayer}, how many sticks do you want to take?");
    string inputText = Console.ReadLine();
    int input = Convert.ToInt32(inputText);
   

    if (input <= maxSticks)
    {
        numberOfSticks -= input;
    }
    else if (input > maxSticks)
    {do
    {
        Console.WriteLine($"The most you can take is {maxSticks}. Try again!");
        Console.WriteLine($"Player {currentPlayer}, how many sticks do you want to take?");
         inputText = Console.ReadLine();
         input = Convert.ToInt32(inputText);
    }
    while (input > maxSticks);
    }

    //STEP 5:
    if (currentPlayer == 1)
        currentPlayer = 2;
    else currentPlayer = 1;
}


//STEP 6:
Console.WriteLine($"Game over. Player {currentPlayer} wins!");

