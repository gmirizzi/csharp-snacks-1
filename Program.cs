int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Inserisci un numero ");
    int newNum = Int32.Parse(Console.ReadLine());
    sum += newNum;
};
Console.WriteLine(sum);