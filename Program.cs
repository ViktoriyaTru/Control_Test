// Вводим массив строк 

Console.WriteLine("Введите строки через пробел:");
string[] input = Console.ReadLine().Split(' ');

// Формируем новый массив из полученых строк, длинной меньше или = 3 символа

string[] result = new string[input.Length];
int i = 0;
for (i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        result[i] = input[i];
    }
}

// Вывод нового массива на экран

Console.WriteLine("Строки длинной меньше или равной 3 символам:");
for (int j = 0; j < result.Length; j++)
{
    Console.Write(result[j] + " ");

}
