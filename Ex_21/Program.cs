﻿/*
Задача 21 (branch task_2)
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Функция
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



int x1 = ReadInt("Введите координату первой точки по оси X: ");
int y1 = ReadInt("Введите координату первой точки по оси Y: ");
int z1 = ReadInt("Введите координату первой точки по оси Z: ");
int x2 = ReadInt("Введите координату второй точки по оси X: ");
int y2 = ReadInt("Введите координату второй точки по оси Y: ");
int z2 = ReadInt("Введите координату второй точки по оси Z: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");
