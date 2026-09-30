using System ;
int [] marks = new int[5];
marks = new int[] { 10, 20, 30, 40, 50 };

// to print all marks in the array


Console.WriteLine("The marks are:");
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

// to find the maximum mark in the array

for (int i = 0; i < marks.Length; i++)
{
    if (marks[i]>= marks[0])
    {
        marks[0] = marks[i];
    }
   
}

Console.WriteLine("The maximum mark is: " + marks[0]);

// to find the minimum mark in the array

for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] < marks[0])
    {
        marks[0] = marks[i];
    }
   
}
Console.WriteLine("The minimum mark is: " + marks[0]);


// find average of marks in the array
int sum = 0;
for (int i = 0 ; i < marks.Length; i++)
{
    sum += marks[i];
}
Console.WriteLine("The sum of marks is: " + sum);
Console.WriteLine("The average mark is: " + (double)sum / marks.Length);


// find the second maximum mark in the array
int max = marks[0];
int secondMax = marks[1];
for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] > max)
    {
        secondMax = max;
        max = marks[i];
    }
    else if (marks[i] > secondMax && marks[i] != max)
    {
        secondMax = marks[i];
    }
}
Console.WriteLine("The second maximum mark is: " + secondMax);