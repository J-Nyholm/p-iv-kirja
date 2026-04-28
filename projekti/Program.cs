

using System.Runtime.CompilerServices;

class Program1
{
    static void Main(string[] args)
    {
        List<DiaryEntry> merkinnat = new List<DiaryEntry>();
        bool kaynnissa = true;

        while (kaynnissa)
        {
            Console.Clear();
            Console.WriteLine("=== Päiväkirjasovellus ===");
            Console.WriteLine("1. Lisää merkintä");
            Console.WriteLine("2. Näytä merkinnät");
            Console.WriteLine("3. Muokkaa merkintää");
            Console.WriteLine("4. Poista merkintä");
            Console.WriteLine("5. Lopeta");
            Console.Write("Valitse toiminto: ");

            string? valinta = Console.ReadLine();

            switch (valinta)
            {
                case "1":
                    Console.Write("Anna otsikko: ");
                    string? otsikko = Console.ReadLine() ?? "Ei otsikkoa";

                    Console.Write("Kirjoita sisältö: ");
                    string? sisalto = Console.ReadLine() ?? "";

                    // Lasketaan ID: Jos lista on tyhjä, ID = 1. 
                    // Muuten katsotaan listan viimeisen ID ja lisätään 1.
                    int uusiId = 1;
                    if (merkinnat.Count > 0)
                    {
                        uusiId = merkinnat[merkinnat.Count - 1].Id + 1;
                    }

                    // Luodaan uusi olio ja lisätään se listaan
                    DiaryEntry uusi = new DiaryEntry(uusiId, otsikko, sisalto);
                    merkinnat.Add(uusi);

                    Console.WriteLine($"Merkintä tallennettu! ID: {uusiId}");
                    break;

                case "2":
                    Console.WriteLine("=== KAIKKI MERKINNÄT ===");
                    if (merkinnat.Count == 0)
                    {
                        Console.WriteLine("Päiväkirja on tyhjä.");
                    }
                    foreach (var m in merkinnat)
                    {
                        Console.WriteLine($"ID: {m.Id} | {m.Pvm.ToShortDateString()} | {m.Otsikko}");
                    }

                    Console.WriteLine("Haluatko lukea kirjoituksen");
                    Console.WriteLine("Y = kyllä");
                    Console.WriteLine("N = Ei");
                    string? katselmus = Console.ReadLine();
                    if (katselmus == "Y" || katselmus == "y") // Hyväksytään myös pieni y
                    {
                        Console.Write("Anna merkinnän ID, jonka haluat lukea: ");
                        string? syoteId = Console.ReadLine();

                        // Yritetään muuttaa syöte numeroksi ja etsitään se listasta
                        if (int.TryParse(syoteId, out int etsittavaId))
                        {
                            // Etsitään listasta ensimmäinen merkintä, jonka ID täsmää
                            var merkinta = merkinnat.Find(m => m.Id == etsittavaId);

                            if (merkinta != null)
                            {
                                Console.Clear();
                                Console.WriteLine("--- MERKINNÄN TIEDOT ---");
                                Console.WriteLine($"ID:      {merkinta.Id}");
                                Console.WriteLine($"Pvm:     {merkinta.Pvm.ToShortDateString()}");
                                Console.WriteLine($"Otsikko: {merkinta.Otsikko}");
                                Console.WriteLine("------------------------");
                                Console.WriteLine(merkinta.Sisalto);
                                Console.WriteLine("------------------------");
                            }
                            else
                            {
                                Console.WriteLine($"Virhe: Merkintää ID:llä {etsittavaId} ei löytynyt.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Virhe: Anna ID-numero numeerisessa muodossa.");
                        }
                    } else if (katselmus == "N")
                    {
                        
                    } else
                    {
                        Console.WriteLine("Väärä vastaus");
                    }

                    break;

                case "3":
                    Console.WriteLine("Muokkaa merkintää (ei vielä toteutettu)");
                    break;

                case "4":
                    Console.WriteLine("Poista merkintä (ei vielä toteutettu)");
                    break;

                case "5":
                    kaynnissa = false;
                    break;

                default:
                    Console.WriteLine("Virheellinen valinta");
                    break;
            }

            Console.WriteLine("\nPaina Enter jatkaaksesi...");
            Console.ReadLine();
        }
    }
}
