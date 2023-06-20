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
//DAY 2
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


//==================
//DAY 3
//==================


//i wish to write a function that
//does not take any arguments
//does not return anything

void FunctionTypeOne()
{
    string someString1 = "Hey guys, the Flash movie is not that good";
    Console.WriteLine(someString1);
}

//Function Call+
FunctionTypeOne();

//Type Two
//i wish to write a function that
//that will take single integer parameter
//and does not return anything

//function definition
void FunctionTypeTwo(int numberofmovies)
{
    string outputSentence = $"I have watched {numberofmovies} movies this year";
    Console.WriteLine(outputSentence);
}

int tobeSentToFunctionMovieCount = 200;

FunctionTypeTwo(tobeSentToFunctionMovieCount);

FunctionTypeTwo(10);

//same as type two but with more than one parameter

void FunctionTypeTwoPart8(int one, string two, bool three)
{
    string someOutput = $"The values are {one}, {two}, {three}";
    Console.WriteLine(someOutput);
}

int one = 1;
string two = "yes";
bool three = true;

FunctionTypeTwoPart8(one, two, three);

//Type Three
//a function that is taking some parameters
//and returning some value

//function definition

//function that will add two numbers
int FunctionThatAddsTwoNumbers(int numberOne, int numberTwo)
{
    int sum = numberOne + numberTwo;
    return sum;
}

int doubleooseven = 7;
int randomagent = 50;

//function call

int result = FunctionThatAddsTwoNumbers(doubleooseven, randomagent);

string outputofAgents = $"The sum of {doubleooseven} and {randomagent} is {result}";
Console.WriteLine(outputofAgents);

//Type Four

//a function that is NOT taking any parameters
//and returning a value

//function definition
int FunctionThatReturnsRandomNumber()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100);
    return randomNumber;
}

//function call
//i simply want a random number, between 1 and 100

int randomnumber = FunctionThatReturnsRandomNumber();
string somerandomsentence = $"The random number is {randomnumber} between 1 and 100, no parameters are sent";

//i want a random number betwen 500 and 800
int lowerboundvalue = 500;
int upperboundvalue = 800;
//int randomnumber2 = FunctionThatReturnsRandomNumber(500, 800);

