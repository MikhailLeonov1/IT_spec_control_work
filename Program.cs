// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется 
//  пользоваться коллекциями, лучше обойтись исключительно массивами.



Console.WriteLine("Введите колличество значений");
int countArrayValue = int.Parse(Console.ReadLine());
string[] startArray = new string[countArrayValue];
string[] FillArray(string[] array)
{
    for (int i = 0; i < countArrayValue; i++)
    {
        Console.WriteLine($"Введите {i} значение:");
        array[i] = Console.ReadLine();
    }
    return array;
}

