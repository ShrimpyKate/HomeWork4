//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Принять число Number от пользователя
// Найти sum цифер в числе
//Печать sum цифер

int GetNumberByUser()
{
  Console.WriteLine("Введите число: ");
  int Number = Convert.ToInt32(Console.ReadLine());
  return Number;
}

int GetSumDigit(int Number)
{
  int Sum = 0;
  while (Number > 0)
  {
    Sum = Sum + Number % 10;
    Number = Number / 10;
  }
  //Console.WriteLine($"Cумма:  {Sum}");
  return Sum;
  
}

void PrintSum();
{
  Console.WriteLine($"Cумма цифер в числе: {}");
}


int Number = GetNumberByUser();
int Summa = GetSumDigit(Number);
PrintSum(Summa);
