var a = 2;
Console.WriteLine("drókuje liczby");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i*a);
}
Console.WriteLine("koniec prógramu");

static double Average(int[] nums)
{
    int suma = 0;
    foreach (var number in nums)
    {
        suma += number;
    }

    return suma / nums.Length;
}

static double Max(int[] nums)
{
    return nums.Max();
}