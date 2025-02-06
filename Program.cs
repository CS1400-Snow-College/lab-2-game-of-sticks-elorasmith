// See https://aka.ms/new-console-template for more information

//Elora Smith, 02/05/2025, Lab 2: Game of Sticks

//Step 1:
Console.WriteLine("Welcome to Game of Sticks!");
Console.WriteLine("Players will take turns removing from 1 to 3 sticks from the pile of 20 sticks. The player to pull the last stick loses!");

//Step 2:
int numberOfSticks = 20;
string currentPlayer = "Player 1";
int maxSticks;

//Step 3:
if (numberOfSticks >= 3)
    maxSticks = 3;
else maxSticks = numberOfSticks;

//Step 4:
Console.WriteLine($"Sticks left: {numberOfSticks}");
Console.WriteLine($"{currentPlayer}, how many sticks do you want to take?");
string inputText = Console.ReadLine();
int input = Convert.ToInt32(inputText);

while (input > maxSticks)
{
Console.WriteLine($"There are only {numberOfSticks} left. Try again!");
Console.WriteLine($"{currentPlayer}, how many sticks do you want to take?");
 inputText = Console.ReadLine();
 input = Convert.ToInt32(inputText);
}

while (input <= maxSticks)
{
    numberOfSticks = numberOfSticks - input;
}

Console.WriteLine(numberOfSticks);

    