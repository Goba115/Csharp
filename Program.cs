void Izpis() //izpiše vsako črko posebi in na koncu pove število znakov
{
    string vhod;
    Console.WriteLine("vpišite besedo:");
    vhod = Console.ReadLine();

    string resnica = vhod;
    int dolzina = vhod.Length;

    Console.WriteLine("\n");

    for (int i = 0; i < dolzina; i++)
    {
        Console.WriteLine(vhod[i]);
    }

    Console.WriteLine("\n" + dolzina);
}


Izpis();
Console.ReadLine();