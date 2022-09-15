// See https://aka.ms/new-console-template for more information
Console.WriteLine("I miei cibi preferiti!");

string[] favoriteFoods = { "Pasta", "Carne", "Pollo", "Mottini", "Patatine", "patate", "giacomo", "blabla" };

Console.WriteLine("Lunghezza classifica: " + favoriteFoods.Length);

Console.WriteLine("cibi in classifica: ");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine((i + 1)  + "=> " + favoriteFoods[i]);
}

Console.WriteLine("Primo cibo in classifica: " + favoriteFoods[0]);

Console.WriteLine("Ultimo cibo in classifica: " + favoriteFoods[favoriteFoods.Length - 1]);

double median = (double)favoriteFoods.Length / 2;

if (median % 2 == 0)
{
    Console.WriteLine("2 Cibi in posizione mediana: " + favoriteFoods[(int)median - 1] + ", " + favoriteFoods[(int)median]);
}
else
{
    Console.WriteLine("3 Cibi in posizione mediana: " + favoriteFoods[(int)median- 1] + ", " + favoriteFoods[(int)median] + ", " + favoriteFoods[(int)median + 1]);
}
