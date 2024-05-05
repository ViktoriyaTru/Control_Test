// Вводим массив строк 

System.Console.WriteLine("Введите строки через пробел:");
string [] input = Console.ReadLine().Split(' ');

// Формируем новый массив из полученых строк, длинной меньше или = 3 символа

string[] result = new string[input.Length];
int i = 0;
for (i=0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        result[i] = input[i]
    }
}
