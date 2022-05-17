int[] array = { 7, 24, 3, 1, 30 };
// This makes it run thru all of the numbers
for (int j = 0; j < 3; j++)
{
    // This loops the comparision of the two numbers

    for (int i = j + 1; i < 3-1; i++)
    {
        // Puts the first number to compare in num 1 and the 2nd number its being compard to in num2
        int num1 = array[j];
        int num2 = array[i];
        // Swaps Num1 and num2 if num one is bigger than num2
        if (num1 >= num2)
        {
            int tempINT = array[j];
            array[j] = array[i];
            array[i] = tempINT;
        }
    }
}
for (int i = 0; i < array.Length; i++)
{
    // Prints out all the numbers
    Console.WriteLine(array[i]);
}