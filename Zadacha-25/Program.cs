//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// See https://aka.ms/new-console-template for more information

void func(double A, int B)
{
  double result=A;
  //Не использую Math.pow тк в задаче просят цикл
  for (int i = 1; i <B; i++)
  {
    result = result*A;
  }
  Console.WriteLine(result);
}




Console.WriteLine("Привет, дай мне два числа!");
double A = Convert.ToDouble(Console.ReadLine());
int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));
func(A,B);
