
Console.WriteLine("Введите первое число");
bool firstNumber = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите второе число");
bool sekondNumber= int.TryParse(Console.ReadLine(), out int y);

if(firstNumber  != true || sekondNumber != true)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}

int result = GetCube(x);
Console.WriteLine(result);
int GetCube(int num)
{
    
    for (int i = 1; i < y; i++)
{
    num = num*x;
}
return num;
}
