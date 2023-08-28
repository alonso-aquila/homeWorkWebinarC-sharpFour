// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

int GetDegreeAofB(int a, int b)

{
    int result = a;

    for (int i = 2; i <= b; i++)
      {
        result *= a;
      }

    return result;  
}

int resSum = GetDegreeAofB(2, 8);

Console.WriteLine(resSum);



// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


int GetSumOfNumb(int numb)
{
    int result = default;

    while (numb > 0)
      {
        result += numb % 10; // или result = result + numb % 10;
        numb /= 10; //  или numb = numb / 10; 
      }
    return result;
}

int res = GetSumOfNumb(452);

Console.WriteLine(res);




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] GenerateArray(int Lenght, int minValue, int maхValue) 

{
    int[] array = new int[Lenght];
    Random random = new Random();

    for (int i = 0; i < Lenght; i++)
    {
        array[i] = random.Next(minValue, maхValue +1);
    }
    return array;
}



void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i =0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");

    Console.Write("]"); 
}

int[] arrayFull = GenerateArray (8, 0, 100); // ввод переменных количества чисел в массиве, минимального и макисмального чисел в массиве

PrintArray (arrayFull); 
