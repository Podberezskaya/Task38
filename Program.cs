//Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Input_array(array);
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
void Input_array (double[] array)
{
      for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(new Random().NextDouble(),2);
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < array.Length; i++);
}
Console.WriteLine($"[{string.Join(" ; " , array)}]");
Console.WriteLine($"{Math.Round (max - min,2)}");
