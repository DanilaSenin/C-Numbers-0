Console.WriteLine("Введите любое число");
double a = int.Parse(Console.ReadLine());

if (a != 0) {
double b = 1 / a;
//Console.SetCursorPosition(2, 7);
Console.WriteLine("Обратное число = " + b);
}
else {
    //Console.SetCursorPosition(7, 2);
    Console.WriteLine("Обратное число от 0 = " + a);
}
