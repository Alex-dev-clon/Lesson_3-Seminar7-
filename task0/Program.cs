// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d
Console.WriteLine("Enter string: ");
string value = Console.ReadLine();
string consonants = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYzZ";

void CheckLetter (string text){
    if (text == string.Empty) return;
    if (consonants.Contains(text[0])) Console.Write(text[0] + " ");
    CheckLetter(text.Substring(1));
}

CheckLetter(value);