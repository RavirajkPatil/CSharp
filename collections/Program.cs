/*var names= new List<string>
{
    "Raviraj",
    "Ridu",
    "Anu",
    "Mady",
    "Raviraj"
}; */
/*
var names= new List<string>{"Raviraj","Ridu","Anu"};
names.Add("Mady");
names.Add("Raj");

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()} !");
}

//Console.WriteLine(names[0]);
Console.WriteLine(names[^2]);
----------
var numbers= new List<int>{33,76,23,99,45,19};
Console.WriteLine($"index of 99 is {numbers.IndexOf(99)}");
numbers.Sort();
Console.WriteLine($"index of 99 is {numbers.IndexOf(99)}");

// foreach (var name in numbers)
// {
//     Console.WriteLine($"{name}");
// }
*/
//---------------------------------------
//Array
/*
var names = new string[]{"Ridu","Shyam","Shambhu"};
//names = [..names,"Adu"]; in c# 12.0
foreach (var name in numbers)
{
    Console.WriteLine($"Hello {name.ToUpper()} !");
}
*/

/*
StudentLinq();

static void StudentLinq(){
    // FibonacciNumbers
    var fibonacciNumbers = new List<int> {1, 1};
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);

    foreach(var item in fibonacciNumbers) 
    {
        Console.WriteLine(item);
    }
}
*/
//var str = new List<int>{14,74,24,86,55};
List<int> scores = [14,74,24,86,55,98,89];
for (int i = 0; i < scores.Count; i++)
{
    if(scores[i] > 80)
    {
        Console.WriteLine($"str abouve 80 is {scores[i]}");
    }    
}


