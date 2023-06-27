// See https://aka.ms/new-console-template for more information
using JayLessons;

Console.WriteLine("Hello, World!");

//student called Bruce Wayna

Student BruceWayne = new Student();
Student SelinaKyle = new Student();

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