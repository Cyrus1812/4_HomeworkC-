
Console.WriteLine("Введите число");
bool Number = int.TryParse(Console.ReadLine(), out int num);

if(Number != true )
{
    Console.WriteLine("Число введено не верно.");
    return;
}

int GetSum(int sum)
{
    int result = 0;
    while(sum>0)
    {
        result += sum%10;
        sum= sum/10;
    }
    return result;
}
 int res = GetSum(num);
 Console.WriteLine($"Сумма чисел = {GetSum(num)}");