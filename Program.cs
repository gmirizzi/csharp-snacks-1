//Snack 11
{
    Console.Write("Inserisci una parola ");
    string firstWord = Console.ReadLine();
    Console.Write("Inserisci una parola ");
    string secondWord = Console.ReadLine();
    string PrintWord (string word1, string word2)
    {
        if (word1.Length == word2.Length)
        {
            return $"{word1} e {word2}";
        } else if (word1.Length > word2.Length)
        {
            return word1;
        } else
        {
            return word2;
        }
    }
    Console.WriteLine(PrintWord(firstWord, secondWord));
}

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
            arrNum[j] = rnd.Next(1, 101);
            Console.WriteLine($"{j+1}. {arrNum[j]}");
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