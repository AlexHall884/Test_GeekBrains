/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует массив строк, 
длинна которых меньше либо равна 3 символа.
*/

Console.WriteLine("Здравствуйте, давайте создадим массив строк. Введите длинну массива: ");
int num = Convert.ToInt32(Console.ReadLine());

string [] array = new string [num]; // создаём массив строк (пустой)

string [] FillArray (string [] arr1)  // метод заполнения массива
{
    for(int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine("Введите любое слово: ");
        arr1[i] = Console.ReadLine();
    }
    return arr1;
}

FillArray(array);

int n = 0; // размер нового массива
for (int i = 0; i < array.Length; i++) // определяем размер нового массива
{
    if (array[i].Length <= 3) n++;
}

string [] GetArray (string [] arr1) // меняем массив согласно условию(заполняем его строками не длиннее трёх символов)
{
    string [] arr2 = new string [n];
    int temp = 0;
    for (int j = 0; j < arr1.Length; j++)
    {
        if(arr1[j].Length <= 3)
        {
            arr2[temp] = arr1[j];
            temp++;
        }
    }
    return arr2; // возвращаем изменённый массив
}

string [] newArray = GetArray(array); // создаём новый массив 
Console.WriteLine();
Console.WriteLine(string.Join(", ", newArray)); // выводим новый массив на экран