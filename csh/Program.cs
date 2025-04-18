using System;

class Program
{
    static void Main()
    {
        bool dziala = true;
        // MENU
        while (dziala)
        {
            Console.WriteLine("\n=== MENU GŁÓWNE ===");
            Console.WriteLine("1 - Kalkulator");
            Console.WriteLine("2 - Konwerter temperatur");
            Console.WriteLine("3 - Średnia ocen");
            Console.WriteLine("4 - Zamknij aplikację");
            Console.Write("Wybierz opcję: ");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;

                case "2":
                    KonwerterTemperatur();
                    break;

                case "3":
                    SredniaOcen();
                    break;

                case "4":
                    dziala = false;
                    Console.WriteLine("Zamykanie aplikacji...");
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }

    static double WczytajDouble(string komunikat)
    {
        double liczba;
        while (true)
        {
            Console.Write(komunikat);
            if (double.TryParse(Console.ReadLine(), out liczba))
                return liczba;
            else
                Console.WriteLine("Nieprawidłowa wartość. Spróbuj ponownie.");
        }
    }

    static int WczytajInt(string komunikat)
    {
        int liczba;
        while (true)
        {
            Console.Write(komunikat);
            if (int.TryParse(Console.ReadLine(), out liczba))
                return liczba;
            else
                Console.WriteLine("Nieprawidłowa wartość. Spróbuj ponownie.");
        }
    }
    // KALKULATOR
    static void Kalkulator()
    {
        Console.WriteLine("\n=== KALKULATOR ===");

        double liczba1 = WczytajDouble("Podaj pierwszą liczbę: ");
        double liczba2 = WczytajDouble("Podaj drugą liczbę: ");

        string operacja;
        double wynik = 0;
        bool poprawnaOperacja = false;

        while (!poprawnaOperacja)
        {
            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("1 - Dodawanie (+)");
            Console.WriteLine("2 - Odejmowanie (-)");
            Console.WriteLine("3 - Mnożenie (*)");
            Console.WriteLine("4 - Dzielenie (/)");

            operacja = Console.ReadLine();

            if (operacja == "1" || operacja == "+")
            {
                wynik = liczba1 + liczba2;
                poprawnaOperacja = true;
            }
            else if (operacja == "2" || operacja == "-")
            {
                wynik = liczba1 - liczba2;
                poprawnaOperacja = true;
            }
            else if (operacja == "3" || operacja == "*")
            {
                wynik = liczba1 * liczba2;
                poprawnaOperacja = true;
            }
            else if (operacja == "4" || operacja == "/")
            {
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                    poprawnaOperacja = true;
                }
                else
                {
                    Console.WriteLine("Błąd: Dzielenie przez zero! Wprowadź ponownie dane.");
                    liczba2 = WczytajDouble("Podaj drugą liczbę: ");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór operacji. Spróbuj ponownie.");
            }
        }
        Console.WriteLine($"Wynik: {wynik}");
    }
    // TEMPERATURY
    static void KonwerterTemperatur()
    {
        Console.WriteLine("\n=== KONWERTER TEMPERATUR ===");

        while (true)
        {
            Console.WriteLine("Wybierz kierunek konwersji:");
            Console.WriteLine("1 (C) - Celsjusz → Fahrenheit");
            Console.WriteLine("2 (F) - Fahrenheit → Celsjusz");
            Console.Write("Twój wybór: ");
            string wybor = Console.ReadLine().ToUpper();

            double temp;

            if (wybor == "1" || wybor == "C")
            {
                temp = WczytajDouble("Podaj temperaturę w °C: ");
                double wynik = temp * 1.8 + 32;
                Console.WriteLine($"{temp}°C = {wynik:F2}°F");
                break;
            }
            else if (wybor == "2" || wybor == "F")
            {
                temp = WczytajDouble("Podaj temperaturę w °F: ");
                double wynik = (temp - 32) / 1.8;
                Console.WriteLine($"{temp}°F = {wynik:F2}°C");
                break;
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
            }
        }
    }
    // SREDNIA OCEN
    static void SredniaOcen()
    {
        Console.WriteLine("\n=== ŚREDNIA OCEN ===");

        int ilosc = WczytajInt("Podaj liczbę ocen: ");
        double suma = 0;

        for (int i = 1; i <= ilosc; i++)
        {
            double ocena;

            while (true)
            {
                ocena = WczytajDouble($"Podaj ocenę {i}: ");
                if (ocena >= 1 && ocena <= 6)
                    break;
                else
                    Console.WriteLine("Ocena musi być w zakresie 1–6.");
            }

            suma += ocena;
        }

        double srednia = suma / ilosc;
        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }
}