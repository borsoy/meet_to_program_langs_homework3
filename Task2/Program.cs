// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string message)                            //название метода
{
    Console.Write($"{message}> ");                      //вывод приглашения ко вводу
    int value;                                          //объявление переменой
    if (int.TryParse(Console.ReadLine(), out value))    //проверка условия корректности ввода + ввод со строки
    {                                                   //если конвертация строки прошла правильно,то мы попадаем в ветку,
        return value;                                   //которая находится в скобка после наименования функции. Если да,
    }                                                   //то выдает первое значение (ввод со строки). Нет - второе (out)
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                //елси TryParse не сработало, выходим из программы (Exit) с кодом 1
    return 0;                                           //нужна для комиляции.
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int DeltaX = x2 - x1;
    int DeltaY = y2 - y1;
    int DeltaZ = z2 - z1;
    return Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY + DeltaZ * DeltaZ);
}
int x1 = InputInt ("Введите координату Х первой точки: ");
int y1 = InputInt ("Введите координату y первой точки: ");
int z1 = InputInt ("Введите координату z первой точки: ");
int x2 = InputInt ("Введите координату Х второй точки: ");
int y2 = InputInt ("Введите координату Х второй точки: ");
int z2 = InputInt ("Введите координату z второй точки: ");

Console.WriteLine($"Расстояние между точной А({x1},{y1},{z1}) и В({x2},{y2},{z2}) равно {Distance (x1, y1, z1, x2, y2, z2):F2}"); //вывод