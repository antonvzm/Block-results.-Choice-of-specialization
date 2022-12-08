// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма
// 3. Создать файл с описанием решения (Readmi.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версии в работе
// Задача: Написать программу которая из имеющего масива строк формирует массив из строк, длина которых меньше или равна 3 символам
// Пример: 
// ["hello","2","world",":-)"] -> ["2",":-)"]

string[] CreateArrayString(int arrayLength)  // Функция для создания массива из строк.
{
string[] arrayString = new string[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"Введите строку номер {i+1}: ");
    arrayString[i] = Console.ReadLine() ?? "";
}
return arrayString;
}

void PrintArray(string[] array)  // Функция для вывода мисcива.
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

string[] ArrayConversion(string[] array) // Функция находит число элементов длинна которых меньше или равна 3 и создает новый масив.
{
    string[] newArrayFirst = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length >= 1)
        {
            newArrayFirst[temp] = array[i];
            temp++;
        }
    }
    string[] newArraySecond = new string[temp];
    for (int i = 0; i < newArraySecond.Length; i++)
    {
        newArraySecond[i] = newArrayFirst[i];
    }
    
    return newArraySecond;
}


Console.WriteLine("Данная программа формирует из вводимого массива строк массив строк, длина которых меньше или равна 3.");
Console.Write("Введите длину массива: ");  //Задаем размер массива
int arrayLength = Convert.ToInt32(Console.ReadLine());

if (arrayLength <= 0) // Проверка длины масива
Console.WriteLine("Введите целок число, которое больше 0.");
else
{
string[] array = CreateArrayString(arrayLength);
PrintArray(array);
Console.Write(" -> ");
string[] newArray = ArrayConversion(array);
PrintArray(newArray);
}
