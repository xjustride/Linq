using System.Linq;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;

namespace Linq

{
    internal class Program
    {
        //record osoba(string imie, string nazwisko);

        static void Main(string[] args)
        {
            string s = "Krzysztof Molenda,  Jan Kowalski, Anna Abacka , Józef Kabacki, Kazimierz Moksa";
            var query = s
                .Split(',')
                .Select(x => x.Trim())
                .Select(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                .Select(x => (imie: x[0].Trim(), nazwisko: x[1].Trim()))
                .OrderBy(x => x.nazwisko)
                .ThenBy(x => x.imie)
                .Select(x => $"{x.imie} {x.nazwisko}");
            //.Select(x => new osoba(x[0], x[1]));
            //var dane = query.ToArray();

            //Array.ForEach(dane, x =>
            //{
            //    Console.Write(x + " ");

            //});
            string wynik = string.Join(", ", query);
            Console.WriteLine(wynik);

        }           
    }
}