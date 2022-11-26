// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Insert number:");
int numberOfFigures = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberOfFigures];
int result = PositiveNumbersCount(array);
Console.WriteLine(result);

int PositiveNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}