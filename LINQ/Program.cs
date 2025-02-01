// Specify the data source.
/*
int[] scores = [97, 92, 100, 21, 81, 60];

// Define the query expression.

IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $"score is {score}";

    //Console.WriteLine($"Count is {scoreQuery.Count()}"); 
*/
/*
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

List<int> myScores = scoreQuery.ToList();
// Execute the query.
foreach (var i in scoreQuery)
{
    Console.WriteLine(i + " ");
}
*/
//------------------------------------------
int[] scores = [97, 92, 100, 21, 81, 60];

var scoreQuery = scores.Where(x => x > 80).OrderByDescending(x => x );

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.WriteLine($"{i}");
}