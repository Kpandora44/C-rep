﻿//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите число: ");

int x = Convert.ToInt32(Console.ReadLine());


int firstDigit = x / 10;
int secondDigit = x % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

Console.WriteLine(maxDigit);
