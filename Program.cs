// See https://aka.ms/new-console-template for more information
Console.WriteLine("I miei cibi preferiti!");

string[] favoriteFoods = { "Pasta", "Carne", "Pollo", "Mottini", "Patatine" };

Console.WriteLine("Lunghezza classifica: " + favoriteFoods.Length);

Console.WriteLine("cibi in classifica: ");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine((i + 1)  + "=> " + favoriteFoods[i]);
}

Console.WriteLine("Primo cibo in classifica: " + favoriteFoods[0]);

Console.WriteLine("Ultimo cibo in classifica: " + favoriteFoods[favoriteFoods.Length - 1]);
