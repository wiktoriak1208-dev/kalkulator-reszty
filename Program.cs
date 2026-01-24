using System;

   
        // PANEL LOGOWANIA
        string login = "admin";
        int pin = 1234;

        Console.WriteLine("Podaj login:");
        string? inputLogin = Console.ReadLine();

        Console.WriteLine("Podaj pin:");
        bool pinOk = int.TryParse(Console.ReadLine(), out int inputPin);

        if (inputLogin == login && pinOk && inputPin == pin)
        {
            Console.WriteLine("Zalogowano pomyślnie");

            Console.WriteLine("Podaj kwotę zakupu:");
            bool okZakup = double.TryParse(Console.ReadLine(), out double kwotaZakupu);

            Console.WriteLine("Podaj kwotę zapłaty:");
            bool okZap = double.TryParse(Console.ReadLine(), out double kwotaZaplaty);

            if (!okZakup || !okZap)
            {
                Console.WriteLine("Błędne dane kwot.");
                return;
            }

            if (kwotaZaplaty > kwotaZakupu)
            {
                Console.WriteLine($"Reszta do wydania: {kwotaZaplaty - kwotaZakupu} zł");
            }
            else if (kwotaZaplaty == kwotaZakupu)
            {
                Console.WriteLine("Zapłacono dokładnie – bez reszty");
            }
            else
            {
                Console.WriteLine($"Brakuje do zapłaty: {kwotaZakupu - kwotaZaplaty} zł");
            }
        }
        else
        {
            Console.WriteLine("Niepoprawne dane logowania");
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    

