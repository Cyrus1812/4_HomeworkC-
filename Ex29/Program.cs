Console.Write("Введите размер массива:");

bool NumberMassive = int.TryParse(Console.ReadLine(), out int num);
if (!NumberMassive || num < 1)
{
    Console.WriteLine("Число введено не верно");
    return;
}

int[] Array(int x)
{

    int[] newArray = new int[x];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под номеров {i}:\t ");
        newArray[i] = int.Parse(Console.ReadLine());
    }
    return newArray;
}
void NewArray(int[] array)
{
    Console.Write("Массив равен: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]}," );


    }
}
NewArray(Array(num));