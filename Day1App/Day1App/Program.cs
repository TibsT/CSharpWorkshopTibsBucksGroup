//==================
//DAY 1
//==================

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//create a string variable

string myName = "Sara";



//creating another variable

string superHeroName = "The Flash";
string secondMovieName = "AdiPurush";

//Console.WriteLine(superHeroName);



//building the output string
//+ is the concatenation operator

string outputString = "This thursday, I will be watching the movie, " + superHeroName;

Console.WriteLine(outputString);

string outputString2 = "This friday, I will be watching the movie, " + secondMovieName;

Console.WriteLine(outputString2);



//create a variable to store an integer

int myAge = 40;

//Console.WriteLine(myAge);



//create a decimal variable

decimal myMoney = 100.50m;

//Console.WriteLine(myMoney);



//create a double variable

double myDouble = 100.50;

//Console.WriteLine(myDouble);



//create a boolean variable

bool isRaining = true;

//Console.WriteLine(isRaining);


//==================
//Day 2
//==================

//two variables that hold two numbers

int num1 = 5;
int num2 = 10;

//use the addition operator on these two numbers

int sum = num1 + num2;

//print the sum to the console

//Console.WriteLine(sum);
string fancyoutputsum =  $"{num1} + {num2} = {sum}";
Console.WriteLine(fancyoutputsum);

//use the subtraction operator on these two numbers

int difference = num1 - num2;

//print the difference to the console

string fancyoutputdifference = $"{num1} - {num2} = {difference}";
Console.WriteLine(fancyoutputdifference);

//use the multiply operator on these two numbers

int multiply = num1 * num2;

//print the multiplication to the console

string fancyoutputmultiply = $"{num1} * {num2} = {multiply}";
Console.WriteLine(fancyoutputmultiply);

//use the divide operator on these two numbers

int divide = num1 / num2;

//print the quotinent to the console

string fancyoutputdivide = $"{num1} / {num2} = {divide}";
Console.WriteLine(fancyoutputdivide);

////lets do the same thing with functions
///

int numberOneForFunctions = 5;
int numberTwoForFunctions = 10;

//Function Definition

int AddTwoNumbers(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}

//Function Call

int storeResultOfAddTwoNumbersFunctionCall = AddTwoNumbers(numberOneForFunctions, numberTwoForFunctions);