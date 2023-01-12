// // Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N

// 2. Создание массива

// 3. Заполнение массива 0 и 1

// 4. Печать массива

// 5. Конвертация из 2-ого в 10-ое


int GetArraySize()
{
  Console.Write("Ведите количество элементов массива: ");
  int size = Convert.ToInt32(Console.ReadLine());
  return size;
}

// 2. Создание массива
int[] myArray(int size)
{
  return new int[size];
}


// 3. Заполнение массива 0 и 1
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
void PrintArray(int[] array)
{
  Console.Write("Число в двоичном представлении: ");
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]}");
  }
  Console.WriteLine();
}


// 5. Конвертация из 2-ого в 10-ое
void ConvertToDec(int[] arr)
{
  int count = arr.Length;
  int temp = count - 1;
  int sum = 0;

  for (int i = 0; i < count; i++)
  {

    sum += arr[i] * Convert.ToInt32(Math.Pow(2, temp));
    temp = temp - 1;

  }
  Console.WriteLine($"Число в десятичном представлении: {sum}");
}

int arrSize = GetArraySize();
int[] arr = myArray(arrSize);

FillArray(arr);
PrintArray(arr);
ConvertToDec(arr);


