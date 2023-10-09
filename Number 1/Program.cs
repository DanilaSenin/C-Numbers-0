bool Flag = false;
while (Flag != true) {
Console.WriteLine("Введите 2 числа");
int firthN = int.Parse(Console.ReadLine());
int ThotN = int.Parse(Console.ReadLine());

if (firthN*firthN == ThotN) {
    Flag = true;
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет, повторите попытку");
}
}