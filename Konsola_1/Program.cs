using System;
using System.Collections.Generic;
using System.Linq; //Obsługuje zapytania
using System.Text; // Kodowanie znaków ASCII i symboli
using System.Threading.Tasks;

namespace Konsola_1
{
    internal class Program // metoda główna
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# - ");
            Console.WriteLine("Jezyk Programowania");
            Console.WriteLine("Nowa Linia");
            Console.Clear(); //Czyszczenie ekranu

            int i = 10;
            Console.WriteLine("Wartosc i wynosi: " + i); // + - Konkatynacja
            Console.WriteLine("Wartosc zmiennej i: {0}", i);
            System.Int64 j = 100;
            Console.WriteLine("Wartosc zmiennej j wynosi: {0}, a wartośćzmiennej i: {1}", j, i);

            // System.Int 64 / 32 / 16

            long l = 20;
            byte b = 255; // 0 - 255
            sbyte sb = -128; // -128 - 127

            short s = -30000; // -32768 - 32767

            int i1 = 1000000; // -2 147 483 648 - 2 147 483 647

            //Dokonczyc typy - np. uint
            Console.WriteLine("Zmienna l: {0}", l);

            Console.ReadKey(); // Console - klasa
                               // ReadKey() - Metoda
                               // Kompilator - program do przemiany zwyklego tekstu do komend rozumianych przez program
                               // C# -> CIL -> kod posredni -> kod maszynowy

            // INTERPRETER - program ktory czyta i analizuje kod programu i wykonuje go na bieząco. Python, Javascript
            // kod -> Interpreter
            
            // C:\Users\2e1\Desktop\GitHub\Objektuwka\Konsola_1
        }
    }
}
