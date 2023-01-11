// // Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)

// 2. Создание массива
// int[] <- (int)

// 3. Заполнение массива 0 и 1
// void <- (int[])

// 4. Печать массива
// string <- (int[])

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])

// 6. 10110100 >> 180

// int GetNumberByUser(string text)
// {
//   int number = Convert.ToInt32(Console.ReadLine());
//   return number;
// }
int GetArraySize()
{
  Console.WriteLine("ВВедите количество элементов массива: ");
  int size = Convert.ToInt32(Console.ReadLine());
  return size;
}


int[] myArray(int size)
{
  return new int[size];
}


// 3. Заполнение массива 0 и 1
// void <- (int[])

void FillArray(int[] myarr)
{
  int index = 0;
  int lenght = myarr.Length;
  while (index < lenght)
  {
    myarr[index] = new Random().Next(0, 2);
    index++;
  }
  if (myarr[0] == 0) myarr[0] = 1;
}

// 4. Печать массива
// string <- (int[])

void PrintArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]}");
  }
  Console.WriteLine();
}

void ConvertToDec(int[] arr)
{
  int count = arr.Length;
  int temp = count - 1;
  int sum = 0;

  for (int i = 0; i < count; i++)
  {

    sum += arr[i] * Convert.ToInt32(Math.Pow(2, temp));
    temp = temp - 1;
    Console.WriteLine($"шаг {sum}");
  }
  Console.WriteLine($"десятич {sum}");
}

int arrSize = GetArraySize();
int[] arr = myArray(arrSize);

FillArray(arr);
PrintArray(arr);
ConvertToDec(arr);

