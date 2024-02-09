using System;

//Napisz aplikację z zastosowaniem pętli while, która będzie pobierać wartości liczbowe od użytkownika w zakresie 0-10,
//dopóki nie poda on wartości 5. Po wpisaniu przez użytkownika wartości 5, aplikacja powinna:
//obliczyć sumę wszystkich elementów podniesioną do kwadratu
//znaleźć najmniejszy element (minimum)
//Wyniki obliczeń wypisz w konsoli.

namespace PetlaWhile {
    class PetlaWhile {
        static void Main(string[] args)
        {
            int sum = 0;
            int minimum = int.MaxValue;
            int input;

            Console.WriteLine("Wprowadzaj liczby z zakresu od 0 do 10. Wprowadź wartość '5' aby zakończyć.");

            while(true)
            {
                string inputStr = Console.ReadLine();
                Console.WriteLine("Wprowadzona liczba: " + inputStr);

                if (inputStr == "5")
                {
                    Console.WriteLine("Wartość '5' została wprowadzona.");
                    break;
                }
                
                if (!int.TryParse(inputStr, out input) || input < 0 || input > 10)
                {
                    Console.WriteLine("Wprowadzona wartość jest nieprawidłowa. Wprowadź liczbę z zakresu od 0 do 10.");
                    continue;
                }

                sum += input;
                if (input < minimum)
                    minimum = input;
            }

            int squaredSum = sum * sum;
            Console.WriteLine($"Suma wszystkich liczb podniesiona do kwadratu: {squaredSum}");
            Console.WriteLine($"Najmniejsza liczba: {minimum}");
        }
    }
}