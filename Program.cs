//Snack 4
int somma = 0;
int media;
int n = 0;
for (int i = 2; i <= 10; i++)
{
    somma += i;
    n++;
}
Console.WriteLine(somma);
Console.WriteLine(n);
media = somma / n;
Console.WriteLine(media);


return;
//Snack 3
int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Inserisci un numero ");
    int newNum = Int32.Parse(Console.ReadLine());
    sum += newNum;
};
Console.WriteLine(sum);