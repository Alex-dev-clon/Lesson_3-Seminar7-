// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9
uint number = 123;

uint SummOfElement (uint number){
    if (number < 10) return number;
    return SummOfElement(number/ 10) + number % 10;
}

Console.WriteLine(SummOfElement(number));
