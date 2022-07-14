//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] FillArray ( int number)
{
    int [] addArray = new int [number];

    for (int i = 0; i < number; i++)
    {
        Console.Write($"Веедите {i+1}-е число : ");
        addArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return addArray;
}

int NumberPositiveNumbers ( int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

Console.Write(" Сколько чисел быдем вводить для проверки? - ");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество чисел больше нуля {NumberPositiveNumbers (FillArray(amount))}");
