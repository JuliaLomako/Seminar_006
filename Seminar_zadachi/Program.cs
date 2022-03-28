// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//A < B + C

void Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    } 

}

Console.WriteLine("Введите первое числа");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе числа");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье числа");
int numC = Convert.ToInt32(Console.ReadLine());
Triangle(numA, numB, numC);


//Задача 2: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.

void Binar(int numS)
{
    string answer = "";
    while(numS > 0)
    {
       answer = Convert.ToString(numS%2) + answer;
       numS = numS / 2;
    }
    Console.WriteLine(answer);
}
Console.WriteLine("Введите число");
int Num =Convert.ToInt32(Console.ReadLine());
Binar(Num);

//Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.


void Fibbon(int numA)
{
    int[] array = new int [numA];
    array[0] = 0; 
    array[1] = 1;
    Console.Write("0 1 ");
    for (int i = 2; i < numA; i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Fibbon(num);


// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

//Задача 4: Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования (3,4)

int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(0,10);
        Console.Write(matrix[i, j] + " ");
    }
Console.WriteLine();
}
