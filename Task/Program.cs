// Задача.
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"] -> ["2",":-)"]
// ["1234","12567","-2","computer science"] -> ["-2"]
// ["Russia","Denwark","kazan"] -> []

string[] arrayInput = { "hello", "2", "world", ":-)" };
string[] arrayLength = new string[arrayInput.Length];

string[] ArrayPrint(string[] arrayInput)
{
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput[i].Length <= 3)
        {
            arrayLength[count] = arrayInput[i];
            count++;
        }
        

    }
    return arrayLength;
}
Console.Write(String.Join(" ",ArrayPrint(arrayInput)));



