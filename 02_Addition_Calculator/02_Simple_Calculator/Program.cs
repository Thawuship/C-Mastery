// See https://aka.ms/new-console-template for more information

// Prints out whatever is in side of ()
Console.WriteLine("Enter First Number");

// takes the user input and store it
// variable with the name "userInput and the data type "string"
// strings are used for text
string userInput1 = Console.ReadLine(); 
Console.WriteLine("Enter Second Number");
string userInput2 = Console.ReadLine();

// Convert the string inputs to integers
int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);

// Add the numbers and print the total
int total = number1 + number2;
Console.WriteLine("Total: " + total);
Console.ReadKey();