// Задача 1.
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// char [ , ] charsMatrix = { {'a', 'b', 'c'} , {'d', 'e', 'f'}};
// string GetStringFromCharsMatrix (char[,] array)
// {
//     string result = string.Empty;
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {
//         result += array[i, j];
//         }
//     }
//     return result;
// }

// string res = GetStringFromCharsMatrix (charsMatrix);
// Console.WriteLine($"Result: {res}");


// Задача 2.
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.WriteLine("Write big and small letters: ");
// string str = Console.ReadLine();

// string result = string.Empty; 
// foreach(char c in str)
// {
//     if(char.IsUpper(c))
//     {
//         result += char.ToLower(c);
//     }
//     else 
//     {
//         result += c;
//     }
// }
// Console.WriteLine(result);

// Задача 3. 
// Задайте произвольную строку. Выясните, является ли она палиндромом.
//  Console.Write("Write word: ");
// string str = Console.ReadLine();

// bool WordIsPalindrom (string str)
// {
//     for(int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
//     {
//         if(str[i] != str[j])
//         {
//             Console.WriteLine("Слово не является палиндромом!");
//             return false;
//         }
//     } 
//         Console.WriteLine("Слово является палиндромом!");
//         return true;
// }

// bool res = WordIsPalindrom(str);
// Console.WriteLine($"Result: {res}");

// Задача 4*(не обязательная).
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

Console.Write("Write phars: ");
string str = Console.ReadLine();

string[] Words = str.Split(' ');
Array.Reverse(Words);

string reversedString = string.Join(" ", Words);
Console.WriteLine(reversedString);

// Array.Reverse - почему нам раньше не рассказывали про эту функцию???