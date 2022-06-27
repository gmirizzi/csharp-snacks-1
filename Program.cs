//Snack 10
{
    Console.Write("Inserisci un numero ");
    int n = Int32.Parse(Console.ReadLine());
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        int[] arrNum = new int[10];
        Console.WriteLine($"Array {i+1}:");
        for (int j = 0; j < 10; j++)
        {
            arrNum[j] = rnd.Next(1, 100);
            Console.WriteLine($"{j}. {arrNum[j]}");
        }
    }

}

//Snack 5
{
    Console.Write("Inserisci un numero ");
    int newNum = Int32.Parse(Console.ReadLine());
    if (newNum % 2 == 0)
    {
        Console.WriteLine(newNum);
    } else
    {
        Console.WriteLine(newNum+1);
    }
}

//Snack 4
{
    int sum = 0;
    int media;
    int n = 0;
    for (int i = 2; i <= 10; i++)
    {
        sum += i;
        n++;
    }
    Console.WriteLine(sum);
    Console.WriteLine(n);
    media = sum / n;
    Console.WriteLine(media);
};

//Snack 3
{
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.Write("Inserisci un numero ");
        int newNum = Int32.Parse(Console.ReadLine());
        sum += newNum;
    };
    Console.WriteLine(sum);
}