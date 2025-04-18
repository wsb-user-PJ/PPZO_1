def wczytaj_float(komunikat):
    while True:
        try:
            return float(input(komunikat))
        except ValueError:
            print("Nieprawidłowa wartość. Spróbuj ponownie.")

def wczytaj_int(komunikat):
    while True:
        try:
            return int(input(komunikat))
        except ValueError:
            print("Nieprawidłowa wartość. Spróbuj ponownie.")

def kalkulator():
    print("\n=== KALKULATOR ===")
    liczba1 = wczytaj_float("Podaj pierwszą liczbę: ")
    liczba2 = wczytaj_float("Podaj drugą liczbę: ")

    poprawna_operacja = False
    while not poprawna_operacja:
        print("Wybierz operację:")
        print("1 - Dodawanie (+)")
        print("2 - Odejmowanie (-)")
        print("3 - Mnożenie (*)")
        print("4 - Dzielenie (/)")
        operacja = input("Twój wybór: ")

        if operacja in ["1", "+"]:
            wynik = liczba1 + liczba2
            poprawna_operacja = True
        elif operacja in ["2", "-"]:
            wynik = liczba1 - liczba2
            poprawna_operacja = True
        elif operacja in ["3", "*"]:
            wynik = liczba1 * liczba2
            poprawna_operacja = True
        elif operacja in ["4", "/"]:
            if liczba2 != 0:
                wynik = liczba1 / liczba2
                poprawna_operacja = True
            else:
                print("Błąd: Dzielenie przez zero! Wprowadź ponownie dane.")
                liczba2 = wczytaj_float("Podaj drugą liczbę: ")
        else:
            print("Nieprawidłowy wybór operacji. Spróbuj ponownie.")

    print(f"Wynik: {wynik}")

def konwerter_temperatur():
    print("\n=== KONWERTER TEMPERATUR ===")
    while True:
        print("Wybierz kierunek konwersji:")
        print("1 (C) - Celsjusz → Fahrenheit")
        print("2 (F) - Fahrenheit → Celsjusz")
        wybor = input("Twój wybór: ").strip().upper()

        if wybor in ["1", "C"]:
            temp = wczytaj_float("Podaj temperaturę w °C: ")
            wynik = temp * 1.8 + 32
            print(f"{temp}°C = {wynik:.2f}°F")
            break
        elif wybor in ["2", "F"]:
            temp = wczytaj_float("Podaj temperaturę w °F: ")
            wynik = (temp - 32) / 1.8
            print(f"{temp}°F = {wynik:.2f}°C")
            break
        else:
            print("Nieprawidłowy wybór. Spróbuj ponownie.")

def srednia_ocen():
    print("\n=== ŚREDNIA OCEN ===")
    ilosc = wczytaj_int("Podaj liczbę ocen: ")
    suma = 0

    for i in range(1, ilosc + 1):
        while True:
            ocena = wczytaj_float(f"Podaj ocenę {i}: ")
            if 1 <= ocena <= 6:
                suma += ocena
                break
            else:
                print("Ocena musi być w zakresie 1–6.")

    srednia = suma / ilosc
    print(f"Średnia: {srednia:.2f}")
    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")

def main():
    dziala = True
    while dziala:
        print("\n=== MENU GŁÓWNE ===")
        print("1 - Kalkulator")
        print("2 - Konwerter temperatur")
        print("3 - Średnia ocen")
        print("4 - Zamknij aplikację")
        wybor = input("Wybierz opcję: ")

        if wybor == "1":
            kalkulator()
        elif wybor == "2":
            konwerter_temperatur()
        elif wybor == "3":
            srednia_ocen()
        elif wybor == "4":
            dziala = False
            print("Zamykanie aplikacji...")
        else:
            print("Nieprawidłowy wybór. Spróbuj ponownie.")

if __name__ == "__main__":
    main()


