// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, Riddesh!");
/*
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine("My friends are "+ firstFriend + " and " +secondFriend);
*/
//--------------------------------------------
/*
    String interpolation: 

var name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
// Both calls produce the same output that is similar to:
// Hello, Mark! Today is Wednesday, it's 19:40 now.
*/
//--------------------------------------------------------------
/*
// Trim:-

string str= "       Raviraj    ";
//string str1 = str.TrimStart();
//string str1 = str.TrimEnd();
string str1 = str.Trim();
Console.Write($"Hi,{str1} here");
Console.Write($"Hi,{str.Trim()} here");
*/
//--------------------------------------------
/*
//Replace:-

string str="Raviraj";
string friends = $"My name is {str}";
Console.WriteLine(friends);
friends = friends.Replace("Raviraj","Riddhesh");
Console.WriteLine(friends);
*/
//---------------------------------------
/*
//Contains:
string songLyrics = "You say goodbye, and I say hello";
//Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
*/
//---------------------------------------

string songLyrics = "You say goodbye, and I say hello";
//Console.WriteLine(songLyrics.StartsWith("You"));
//Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
//Console.WriteLine(songLyrics.EndsWith("goodbye"));