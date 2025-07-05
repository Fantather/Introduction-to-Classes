// Задание 1
// Напишите метод, который отображает квадрат из некоторого символа
// Метод принимает в качестве параметра: длину стороны квадрата, символ

// Задание 2
// Напишите метод, который проверяет является ли переданное число «палиндромом»
// Число передаётся в качестве параметра
// Если число палиндром нужно вернуть из метода true, иначе false

//Задание 3
// Напишите метод, фильтрующий массив на основании переданных параметров
// Метод принимает параметры: оригинальный_массив, массив_с_данными_для_фильтрации
// Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации

void PrintSquare(int size, char simbol)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(new string(simbol, size));
    }
}

bool IsPalindrome(int number)
{
    string temp = number.ToString();
    string reverse = new string(temp.Reverse().ToArray());

    return temp.Equals(reverse);
}

int[] Filter(int[] array, int[] exception_array)
{
    return array.Where(x => exception_array.Contains(x) == false).ToArray();
}