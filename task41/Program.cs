// Задача 41.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Array1(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input number{i+1}:");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}

void PrintArray (int [] arrayToPrint)
{
    Console.Write("Your nput numbers is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        if (i != arrayToPrint.Length - 1)
            Console.Write(arrayToPrint[i] + ", ");
        else
            Console.Write(arrayToPrint[i]);

    Console.WriteLine();
}

int CountOfPosElems (int [] arrayCount)
{
    int countPos = 0;
    for (int i = 0; i < arrayCount.Length; i++)
    {
        if (arrayCount[i] > 0)
            countPos++;
    }
    return countPos;
}

Console.WriteLine("How many numbers will you input?");
int m = Convert.ToInt32(Console.ReadLine());
if (m <= 0)
    Console.WriteLine("Incorrect number. Try again");
else
{
    int [] array = Array1(m);
    PrintArray(array);
    Console.WriteLine("Counting positions satisfying the principle Number > 0 ...");
    Console.WriteLine($"Your result is {CountOfPosElems(array)}");
}