Console.WriteLine("Введите количество чисел");
int number = Convert.ToInt32(Console.ReadLine());

void Numbers(int numb)
{
    int i = 0;
    int count = 0;
    int[] a = new int[numb]; 
    while (i <numb)
    {
        Console.Write($"Введите {i+1}-е число: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    Console.WriteLine(string.Join(" ",a));

    for (i = 0; i < numb; i++)
    {
        if (a[i] > 0)  count++;
    }
    Console.WriteLine($"Количество положительных элементов: {count}");
}
Numbers(number);


