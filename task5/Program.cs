//На вход натуральное число N, на выход его цифры через запятую.
string N = Console.ReadLine();
for (int i = 1; i < N.Length; i++)
    Console.Write($"{N[i - 1]}, ");
Console.Write($"{N[N.Length - 1]}");