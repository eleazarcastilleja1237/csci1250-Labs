/*
Name: Eleazar Castilleja
Course: CSCI 1250, Section 001
Assignment: Lab 03, The Badge Office
Date: September 30, 2026
Description: Builds a student badge from a name, two random assignments, and the walking
distane to a first class.
*/

string fullName = Console.ReadLine ();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf (" ");
string firstName = fullName.Substring (0, spacePosition);
string lastName = fullName.Substring (spacePosition + 1);

string badgeName = fullName.ToUpper();
string username = (firstName.Substring(0,1) + lastName).ToLower(); 
string intials = firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(0,1).ToUpper() + ".";

Random rng = new Random (); 

int studentID = rng.Next (100000,999999);
int locker = rng.Next (1, 50);


int checkDigit = studentID % 9;
string bar = new string('=', 34);

Console.WriteLine("\nFull name:".PadRight(10) + fullName);
Console.WriteLine ("Name on Badge:".PadRight(10) + badgeName);
Console.WriteLine("username".PadRight(10) + username);
Console.WriteLine("Intials:".PadRight(10) + intials);
Console.WriteLine("Letters in Last Name:".PadRight(10) + lastName.Length);

Console.WriteLine("\nStudent ID:".PadRight(10) + studentID);
Console.WriteLine("Locker:".PadRight(10) + locker);

Console.Write("\nDorm x: ");
double dormX = Convert.ToDouble (Console.ReadLine());

Console.Write ("Dorm y: ");
double dormY = Convert.ToDouble (Console.ReadLine());

Console.Write ("Class x: ");
double classroomX = Convert.ToDouble (Console.ReadLine());

Console.Write ("Class y: ");
double classroomY = Convert.ToDouble (Console.ReadLine());

Console.Write ("Walking speed in feet per second: ");
double walkingSpeed = Convert.ToDouble (Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(classroomX - dormX, 2) + Math.Pow(classroomY - dormY, 2));
int totalSeconds = (int)Math.Round(distance / walkingSpeed);
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

Console.Write("\nDistance:".PadRight(10) + distance);
Console.Write("\nWalk time:".PadRight(10) + minutes + " minutes " + seconds + " seconds \n");


Console.WriteLine(bar);
Console.WriteLine("ETSU STUDENT BADGE".PadLeft(26));
Console.WriteLine(bar);
Console.WriteLine("NAME".PadRight(10) + fullName.ToUpper());
Console.WriteLine("USERNAME".PadRight(10) + username);
Console.WriteLine("ID".PadRight(10) + studentID + "-" + checkDigit);
Console.WriteLine("LOCKER".PadRight(10) + locker);
Console.WriteLine("WALK".PadRight(10) + minutes + " Minutes " + seconds + " Seconds ");
Console.WriteLine(bar);




