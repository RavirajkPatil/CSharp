/*
using System;

namespace MyAppNamespace
{
    public class MyApp
    {
        public static void Main()
        {
            Console.WriteLine("Hello, OOPs from class!");            
        }
    }
}
*/
//-------------------------------------
/*
//class with Object
Student s1= new Student(){FirstName="Raviraj",LastName="Patil",BirthDate = new DateOnly(1992,06,30)};
Student s2= new Student(){
    FirstName="Riddhesh",
    LastName="Patil",
    BirthDate = new DateOnly(2022,05,17)};

public class Student
{
    public string FirstName
    public string LastName
    public DateOnly BirthDate;
}
*/
//------------------------------
//Constructor
/*
var s1 = new Student("Raviraj","Patil",new DateOnly(1992,06,30));
var s2 = new Student("Riddhesh","Patil",new DateOnly(2022,05,17));
List<Student> students = [s1,s2];
foreach (var student in students)
{
    Console.WriteLine($"{student} {student.BirthDate}");
}
public class Student
{
    public Student(string first,string last,DateOnly date)
    {
        FirstName = first;
        LastName = last;
        BirthDate = date;
    }
    private string FirstName;   //private field 
    private string LastName;
    public DateOnly BirthDate;
}
*/
//------------------------------------------
/*
var s1 = new Student("Raviraj","Patil",new DateOnly(1992,06,30));
var s2 = new Student("Riddhesh","Patil",new DateOnly(2022,05,17));
var s3 = new Student("Riddhesh","Patil",new DateOnly(2022,05,17));
List<Student> students = [s1,s2,s3];
Console.WriteLine(students.Count);
public class Student(string first, string last, DateOnly date)
{
    public string FirstName { get;} = first ;
    public string LastName { get;} = last ; 
    public DateOnly BirthDate { get;} = date ;
}
*/
//----------------------------------------------


var s1 = new Student("Riddhesh","Patil",new DateOnly(2022,05,17));
var s2 = new Student("Raviraj","Patil",new DateOnly(2022,05,17));

s1.Pets.Add(new Dog("Moti"));
s2.Pets.Add(new Cat("Dunki"));

List<Student> students = [s1,s2];

foreach (var student in students)
{
    Console.WriteLine($"{student}");
    foreach (var pet in student.Pets)
    {
        Console.WriteLine($"   {pet}");
    }
}
public class Student(string first, string last, DateOnly date)
{
    public string FirstName { get;} = first ;
    public string LastName { get;} = last ; 
    public DateOnly BirthDate { get;} = date ;
    //public List<Pets> Pets = new();      or 
    public List<Pets> Pets = [];

    public override string ToString()
    {
        return $"Humans are {FirstName} {LastName} {BirthDate}";
    }
}
public abstract class Pets(string FirstName)     // Pet class combine the Cat and Dog class. It is concrete class.
{                                       // That's why we create it as a abstract class.
    public string First { get;} = FirstName ;
    //public string MakeNoise()=>"??";  
    public abstract string MakeNoise();    // this is the abstract field because its is vary by call of class. 
     public override string ToString()
    {
        return $"{First} I am a {GetType().Name} and I {MakeNoise()}";
    }
}
public class Cat(string FirstName) : Pets(FirstName)
{
    // public string First { get;} = FirstName ;
    // public string Meow() => "meow";
    public override string MakeNoise() =>"meow";
}
public class Dog(string FirstName) : Pets(FirstName)
{
    // public string First { get;} = FirstName ;
    // public static string Bark() { return "bark"; }
    public override string MakeNoise() => "bark";
}
