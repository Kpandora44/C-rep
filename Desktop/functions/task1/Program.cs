double CalculataFormula(int a, int b, int c, int d)  // int - целочисленный тип данныйх
{
    double numenator = a * b;  // double - более вместительный тип данных, дробный
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

double result = CalculataFormula(1, 2, 3, 4);

// double result- создаем переменную

Console.Write(result);