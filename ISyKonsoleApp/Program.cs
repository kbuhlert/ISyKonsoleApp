using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISyKonsoleApp
{
    class Program
    {
        //hier wird neuer Datentyp "ZeigerAufAddMethod"e (Delegate) nicht als Klasse sonder als Delegate gespeichert. kompiler erstellt dann neuen Datentyp
        delegate int ZeigerAufAddMethode(int z1, int z2);

        static void Main(string[] args)
        {
            Math m1 = new Math();
            int ergebnis = m1.Add(12, 5);

            //delegate - Variable (vom Typ dieser Methoden Adresse, hier: Var die int zurückliefer und 2 int als Übergabeparameter) die Methoden-Adressen speichert
            //-> Datentyp variable = m1.Add;        Variable die Methodenadresse speichert, aber die Methode noch nicht aufruft
            ZeigerAufAddMethode z1 = m1.Add;    //= m1.Add()

            int ergebnis2 = z1(12, 5);

            //delegate jetzt auf andere Methode richten
            z1 = m1.Subtr;
            int ergebnis3 = z1(10, 2);
        }
    }
}
