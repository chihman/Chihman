﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Пользователь вводит координаты точки x и y.
/// Программа проверяет, принадлежит ли эта точка закрашенной области.
/// Изображение областей можно найти по адресу:
/// ${папка с заданиями}/images/Области 1.png
/// 
/// В исходном коде решения намеренно допущена логическая ошибка.
/// 
/// Чтобы выполнить задание, нужно:
/// - Подобрать исходные данные для проверки задачи.
/// - Выяснить в каком случае программа работает неверно.
/// - Оформить отчет о тестировании.
/// 
/// Исправлять ошибку не нужно.
/// 
/// </summary>

// ОТЧЕТ О ТЕСТИРОВАНИИ
// В программе присутствует ограничения:
// 1) X <= -2
// 2) Y >= 1
// Эти ограничения образуют 4 области.
// Результаты проверки:
// Точки внутри областей.
// (-3;2) - верно
// (0;2)  - верно
// (-3;0) - верно
// (0;0)  - ожидается "Не принадлежит". получилось "Принадлежит"
// Точки на границах:
// (-3;1) - верно
// (-2;2) - верно
// (0;1)  - верно
// (-2;0) - верно
// Точки на пересечении границ:
// (-2;1) - верно

namespace Lab05_Task1999
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());
            if (x <= -2)
            {
                if (y >= 1)
                {
                    Console.WriteLine("Принадлежит");
                }
                else {
                    Console.WriteLine("Не принадлежит");
                }
            }
            else {
                if (y >= 1)
                {
                    Console.WriteLine("Не принадлежит");
                }
                else {
                    Console.WriteLine("Принадлежит");
                }
            }
        }
    }
}
