//Написать программу , которая из имеющегося массива строк формирует массив из строк , длина которых
//меньше либо равно 3м символам.
string[] array1 = new string[5] { "1234", "1567", "-2", "computer", "res" };
string[] array2 = new string[array1.Length];
int count = 0;

void ArrayIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayIF(array1, array2);
PrintArray(array2);