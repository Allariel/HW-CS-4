// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Print_array(int[] array)
{
    Console.Write("[");
    foreach (int x in array)
    {
        if (x == array.Last())
        {
            Console.Write(x);
        }
        else
        {
            Console.Write(x + ", " );
        }
    }
    Console.Write("]");
}

Console.WriteLine("Give Number");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{   //ручной ввод
    //array[i] = Convert.ToInt32(Console.ReadLine());
    array[i] = rnd.Next(52); 
}

Print_array(array);
