using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionTest
{
    public class MojaZaleznoscInna : IMojaZaleznosc
    {
        public void MojaZaleznosc()
        {
            
        }

        public void NapiszWiadomosc(string message)
        {
            Console.WriteLine($"Nie wiem o co chodzi ale przekazano taką wiadomość: {message}");
        }
        //TODO: Napisz 3 klasy implementujące interfejs zawierający metodę WczytajDane:
        // 1. Klasa czytająca z XML-a
        // 2. Klasa czytająca z JSON-a
        // 3. Wstrzyknij klasy do interfejsu i zobacz, jak zmienia się wynik.
    }
}
