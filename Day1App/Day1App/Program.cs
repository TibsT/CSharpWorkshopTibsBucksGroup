//==================
//DAY 1
//==================


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//create a string variable

using Day1App;

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

int FunctionThatReturnsRandomNumber2(int lowerbound, int upperbound)
{
    Random random = new Random();
    int randomNumber = random.Next(lowerbound, upperbound);
    return randomNumber;
}

//function call
//I simply want a random number, between 1 and 100

int randomnumber = FunctionThatReturnsRandomNumber();
string somerandomsentence = $"The random number is {randomnumber} between 1 and 100, no parameters are sent";

Console.WriteLine(somerandomsentence);

//I want a random number between 500 and 800
int lowerboundvalue = 500;
int upperboundvalue = 800;
int randomnumber2 = FunctionThatReturnsRandomNumber2(500, 800);
string somerandomsentence2 = $"The random number is {randomnumber2} between {lowerboundvalue} anbd {upperboundvalue}";

Console.WriteLine(somerandomsentence2);


//==================
//DAY 4
//==================


Movie firstmovie = new Movie();

firstmovie.MovieTitle = "The Flash";
firstmovie.MovieReleaseStatus = true;
firstmovie.MovieReleaseYear = 2023;

string firstmoviestuff = $"The name of the movie is {firstmovie.MovieTitle} and it is being released in {firstmovie.MovieReleaseYear} and current status of releasing is {firstmovie.MovieReleaseStatus}";

Console.WriteLine(firstmoviestuff);

Movie secondmovie = new Movie();

secondmovie.MovieTitle = "Elemental";
secondmovie.MovieReleaseStatus = false;
secondmovie.MovieReleaseYear = 2023;

string secondmoviestuff = $"The name of the movie is {secondmovie.MovieTitle} and it is being released in {secondmovie.MovieReleaseYear} and current status of releasing is {secondmovie.MovieReleaseStatus}";

Console.WriteLine(secondmoviestuff);

Movie thirdmovie = new Movie();

thirdmovie.MovieTitle = "spiderman across the spiderverse";
thirdmovie.MovieReleaseStatus = true;
thirdmovie.MovieReleaseYear = 2023;

string thirdmoviestuff = $"The name of the movie is {thirdmovie.MovieTitle} and it is being released in {thirdmovie.MovieReleaseYear} and current status of releasing is {thirdmovie.MovieReleaseStatus}";

Console.WriteLine(thirdmoviestuff);


//lets create a video game object with Minecraft

VideoGame firstvideogame = new VideoGame();

firstvideogame.NameOfVideoGame = "Minecraft";
firstvideogame.GameReleaseYear = 2011;
firstvideogame.TypeOfGame = "Open World, Sandbox";
firstvideogame.TypeOfGamingDevice = "Every Platform";
firstvideogame.OnlineOrOffline = true;

string firstvideogamestuff = $"The name of the video game is {firstvideogame.NameOfVideoGame} and it was released in {firstvideogame.GameReleaseYear} and it is a {firstvideogame.TypeOfGame} game. It can be played on {firstvideogame.TypeOfGamingDevice} and the online status is {firstvideogame.OnlineOrOffline}.";

Console.WriteLine(firstvideogamestuff);