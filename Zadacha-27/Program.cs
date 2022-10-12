//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//1Cпособ, через цикл
void func(int A)
{
    int sum = 0;
    while(A/10 != 0)
    {
        sum = sum + (A%10);
        A = A/10;
    } 
    sum = sum + (A%10);
    Console.WriteLine(sum);
}

Console.WriteLine("Hello!");
int A = Convert.ToInt32(Console.ReadLine());
func(A);


/*2 Способ, рекурсивный
void Recursisya(int sum, int A)
{
    sum = sum + (A%10);
    A = A/10;
    if(A == 0)
    {
        sum = sum + (A%10);
        Console.WriteLine(sum);
    }
    else 
    {
        Recursisya(sum, A);
    }
}


Console.WriteLine("Hello!");
int A = Convert.ToInt32(Console.ReadLine());
Recursisya(0,A);
*/