using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raute
{
    class Program
    {
        static void Main(string[] args)
        {
            int größe;

            Console.Title = "Rauten malen";
            Console.WriteLine("Bitte geben Sie die größe der Raute ein.\nSie darf zwichen 3 und 15 sein.");
            if (int.TryParse(Console.ReadLine(), out größe) == false || größe > 15 || größe < 3) { Console.WriteLine("Es wurde keine gültige Zahl angegeben!"); Console.Read(); return; }
            bool gerade = größe % 2 == 0;

            if (gerade)
            {
                for (int zeilen = 1, leer = größe, zeichen = 1; zeilen <= größe; zeilen++)
                {
                    if (zeilen < größe / 2)
                    {
                        Console.WriteLine(new string(' ', leer--) + new string('X', zeichen));
                        zeichen += 2;
                    }
                    else if (zeilen == größe / 2)
                    {
                        Console.WriteLine(new string(' ', leer) + new string('X', zeichen));
                    }
                    else
                    {
                        Console.WriteLine(new string(' ', leer++) + new string('X', zeichen));
                        zeichen -= 2;
                    }
                }
            }
            else
            {
                for (int zeilen = 1, leer = größe, zeichen = 1; zeilen <= größe; zeilen++)
                {
                    if (zeilen <= größe / 2)
                    {
                        Console.WriteLine(new string(' ', leer--) + new string('X', zeichen));
                        zeichen += 2;
                    }
                    else
                    {
                        Console.WriteLine(new string(' ', leer++) + new string('X', zeichen));
                        zeichen -= 2;
                    }
                }
            }

            Console.WriteLine();
            Console.Read();

        }
    }
}
