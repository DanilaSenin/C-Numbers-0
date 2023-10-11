Console.WriteLine("Введите числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = -99999;
int min = 99999;
int [] chisla = {a, b, c};
for (int i = 0; i < 3; i++) {
    if (chisla[i] > max) {
        max = chisla[i];
    }
    if (chisla[i] < min) {
        min = chisla[i];
    }
}
Console.Write("Ваш массив: " + min + " "+ max);