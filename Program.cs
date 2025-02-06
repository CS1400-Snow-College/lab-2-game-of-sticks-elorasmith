// See https://aka.ms/new-console-template for more information

//Elora Smith, 02/05/2025, Lab 2: Game of Sticks

//Step 1:
Console.WriteLine("Welcome to Game of Sticks!");
Console.WriteLine("Players will take turns removing 1 to 3 sticks from the pile of 20 sticks. The player to pull the last stick loses!");

//Step 2:
int numberOfSticks = 20;
int maxSticks;

//Step 3:
if (numberOfSticks >= 3)
    maxSticks = 3;
else maxSticks = numberOfSticks;

bool currentPlayerIs1 = true;
bool currentPlayerIs2 = false;
string currentPlayer = "Player 1";

if (currentPlayerIs1 == true)
    currentPlayer = "Player 1";
else currentPlayer = "Player 2";
    

//Step 4:
Console.WriteLine($"Sticks left: {numberOfSticks}");
Console.WriteLine($"{currentPlayer}, how many sticks do you want to take?");
string inputText = Console.ReadLine();
int input = Convert.ToInt32(inputText);
int numberOfSticks2 = 1;

if (input <= maxSticks)
{
    numberOfSticks2 = (numberOfSticks - input);
}
else if (input > maxSticks)
{do
    {
     Console.WriteLine($"The most you can take is {maxSticks}. Try again!");
    Console.WriteLine($"{currentPlayer}, how many sticks do you want to take?");
     inputText = Console.ReadLine();
    input = Convert.ToInt32(inputText);
    }
while (input > maxSticks);
}
Console.WriteLine(numberOfSticks2);

//STEP 5:
if (currentPlayerIs1 == true)
{
    currentPlayerIs1 = false;
    currentPlayerIs2 = true;
}
if (currentPlayerIs2 == true)
{
    currentPlayerIs1 = true;
    currentPlayerIs2 = false;
}

//STEP 6:



if (numberOfSticks == 0)
{
    Console.WriteLine($"Game over. {currentPlayer} wins!");
}
