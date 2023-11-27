// Перевести число в двоичное представление
uint number = 44;

string BinaryView (uint sourceNumber){
    if (sourceNumber == 0) return string.Empty;
    return BinaryView (sourceNumber / 2) + sourceNumber % 2;
}

string result = BinaryView (number);

Console.WriteLine(result);
