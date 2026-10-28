int sum = 0;
float average;
int n = 1; //Looping variable
do
{
    if (n < 10)
    {
        System.out.print(n + ", ");
    }
    else
    {
        System.out.print(n + ".\n");
    }
    sum += n;
    n++;
} while (n <= 10);
average = sum / (float)10;//Compute mean/average
                          //Display the results
System.out.printf("The sum of the first ten integers is "
        + sum + " and their average is %.2f%n", average)