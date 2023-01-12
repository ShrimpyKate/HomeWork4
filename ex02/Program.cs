//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//1.Принять число Number от пользователя
//2.Найти sum цифер в числе
//3.Печать sum цифер

//1.Принять число Number от пользователя
int GetNumberByUser()
{
  Console.WriteLine("Введите число: ");
  int Number = Convert.ToInt32(Console.ReadLine());
  return Number;
}

//2.Найти sum цифер в числе
int GetSumDigit(int Number)
{
  int Sum = 0;
  while (Number > 0)
  {
    Sum = Sum + Number % 10;
    Number = Number / 10;
  }
  //Console.WriteLine($"Cумма:  {Sum}");  //пробный вывод суммы
  return Sum;
  
}

//3.Печать sum цифер
void PrintSum(int Sum)
{
  Console.WriteLine($"Cумма цифер в числе: {Sum}");
}


int Number = GetNumberByUser();
int Summa = GetSumDigit(Number);
PrintSum(Summa);
