// See https://aka.ms/new-console-template for more information
using JayLessons;

Console.WriteLine("Hello, World!");

//student called Bruce Wayna

Student BruceWayne = new Student();
Student SelinaKyle = new Student();
Student Tibi = new Student();

BruceWayne.NameOfStudent = "Bruce Wayne";
BruceWayne.StudyHoursPerWeek = 20;
BruceWayne.StudyWeeksCompleted = 0;

SelinaKyle.NameOfStudent = "Selina Kyle";
SelinaKyle.StudyHoursPerWeek = 10;
SelinaKyle.StudyWeeksCompleted = 10;

string outputForBatman = $"Student Name : {BruceWayne.NameOfStudent} Study Hours : {BruceWayne.StudyHoursPerWeek} Number of Weeks Completed : {BruceWayne.StudyWeeksCompleted}";

string outputForSelina = $"Student Name : {SelinaKyle.NameOfStudent} Study Hours : {SelinaKyle.StudyHoursPerWeek} Number of Weeks Completed : {SelinaKyle.StudyWeeksCompleted}";

Console.WriteLine(outputForBatman);

Console.WriteLine(outputForSelina);

Student KitWalker = new Student();

KitWalker.NameOfStudent = "Kit Walker";
KitWalker.StudyHoursPerWeek = 30;
KitWalker.StudyWeeksCompleted = 30;

KitWalker.BuildStudentInformation();
KitWalker.DisplayStudentInformation();

Tibi.NameOfStudent = "Tibi";
Tibi.StudyHoursPerWeek = 2;
Tibi.StudyWeeksCompleted = 10;

//500 hours is the same amount of time it takes to become
//a beginner developer.

int TotalNumberOfHoursToBecomeDeveloper = 500;

//20 hours per week
//25 weeks to become a beginner developer.
//number of weeks already completed is 0
//remaining weeks = 25-0 = 25 weeks
//ultimately, batman will become developer in 25 weeks.

//10 hours per week
//50 weeks to become a beginner developer
//10 weeks are already completed
//remaining weeks = 50-10 = 40 weeks.
//eventually, catwoman will be a developer in 40 weeks.

//int numberOfWeeksBasedOnStudentWeeklyHoursCommitment = TotalNumberOfHoursToBecomeDeveloper / BruceWayne.StudyHoursPerWeek;

//Console.WriteLine(numberOfWeeksBasedOnStudentWeeklyHoursCommitment);

//int remainingnumberOfWeeksToStudy = numberOfWeeksBasedOnStudentWeeklyHoursCommitment - BruceWayne.StudyWeeksCompleted;

//Console.WriteLine(remainingnumberOfWeeksToStudy);

//string outputforBatmanStudent = $"Student Name: {BruceWayne.NameOfStudent} will need to study for {remainingnumberOfWeeksToStudy} to become a basic beginner developer";

//Console.Write(outputforBatmanStudent);

//here, i want to start using the developer class

Developer DeveloperTesting = new Developer();

DeveloperTesting.CalculatorDeveloperEstimate(BruceWayne.StudyHoursPerWeek, BruceWayne.StudyWeeksCompleted, BruceWayne.NameOfStudent);
DeveloperTesting.DisplayDeveloperEstimate();

DeveloperTesting.CalculatorDeveloperEstimate(SelinaKyle.StudyHoursPerWeek, SelinaKyle.StudyWeeksCompleted, SelinaKyle.NameOfStudent);
DeveloperTesting.DisplayDeveloperEstimate();

DeveloperTesting.CalculatorDeveloperEstimate(KitWalker.StudyHoursPerWeek, KitWalker.StudyWeeksCompleted, KitWalker.NameOfStudent);
DeveloperTesting.DisplayDeveloperEstimate();

DeveloperTesting.CalculatorDeveloperEstimate(Tibi.StudyHoursPerWeek, Tibi.StudyWeeksCompleted, Tibi.NameOfStudent);
DeveloperTesting.DisplayDeveloperEstimate();