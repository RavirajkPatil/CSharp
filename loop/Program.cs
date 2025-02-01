/*
//while-loop
int a = 0;
while (a < 5)
{
     a++;
    Console.WriteLine($"{a}");
}
*/
//-----------------------------
/*
//do..while-loop

int a =0;
do
{
    a++;
    Console.WriteLine($"While{a}");
} while (a < 5);
*/

//for loop
    int a =0;
    for (int i = 1; i <= 20; i++)
    {
        if (i%3==0)
        {
            a=a+i;
        }
        
    }
    Console.WriteLine(a);
    

/*for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}*/