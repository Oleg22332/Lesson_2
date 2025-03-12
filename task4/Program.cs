int[] array = {22, 5, 213, 4, 3};
int max = 0;
foreach(int i in array)
    if (i > max)
        max = i;
Console.Write(max);     