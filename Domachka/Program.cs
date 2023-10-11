Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b) {
    max = a;
    min = b;
}
else {
    max = b;
    min = a;
}
Console.WriteLine("a = " + a + " " + "b = " + b + " " + "->" + " max = " + max + " " + "min = "+ min);