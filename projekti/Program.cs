

class Program1
{
    static void Main(string[] args)
    {
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
                    Console.WriteLine("Lisää merkintä (ei vielä toteutettu)");
                    break;

                case "2":
                    Console.WriteLine("Näytä merkinnät (ei vielä toteutettu)");
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
