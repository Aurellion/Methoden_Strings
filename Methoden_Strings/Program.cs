using System;

namespace Methoden_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nochmal;
            Console.WriteLine("Arbeiten mit Strings!");
            do
            {
                Console.WriteLine("1: Zeichen ersetzten.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Quersumme berechnen.");//274 -> 13 

                //short 123 
                //string "dkjsfbela63468" 
                //"8"       '8'     8       8.0 
                //string    char    int     double
                ushort auswahl; //short ist eine 16Bit Ganzzahl und ushort (unsigned) nur positive Zahlen 
                auswahl = Convert.ToUInt16(Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        string eingabe, zeichenzuersetzen, ersatzzeichen, ausgabe;
                        Console.WriteLine("Text eingeben:");
                        eingabe = Console.ReadLine();
                        Console.WriteLine("Zu ersetzendes Zeichen eingeben:");
                        zeichenzuersetzen = Console.ReadLine();
                        Console.WriteLine("Ersetzen mit?");
                        ersatzzeichen = Console.ReadLine();

                        //Methode verwenden
                        ausgabe = ZeichenErsetzen(eingabe, zeichenzuersetzen, ersatzzeichen);
                        Console.WriteLine(ausgabe);
                        break;
                    case 2:                        
                        Console.WriteLine("Text eingeben:");
                        eingabe = Console.ReadLine();                        

                        //Methode verwenden
                        ausgabe = VokaleEntfernen(eingabe);
                        Console.WriteLine(ausgabe);
                        break;

                    case 3:

                        //Methode verwenden
                        break;

                    default:
                        Console.WriteLine("Falsche Auswahl!");
                        break;
                }



                Console.WriteLine("Nochmal? j/n");
                nochmal=Console.ReadLine();
            } while (nochmal=="j");

        }

        //string s = "Wort";
        //string s ist auch char[] s ={'W', 'o', 'r', 't'}
        //ersetze r mit l -> "Wort" -> "Wolt"
        // zeichenzuersetzen = r, ersatzzeichen = l
        static string ZeichenErsetzen(string text, string zeichenzuersetzen, string ersatzzeichen)
        {
            string ausgabe="";
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i].ToString() == zeichenzuersetzen)
                {
                    ausgabe += ersatzzeichen;
                }
                else
                {
                    ausgabe += text[i].ToString();
                }
            }
            return ausgabe;
        }

        // "Hallo Welt" -> "Hll Wlt"
        static string VokaleEntfernen(string text)
        {
            string ausgabe=text;
            string[] Vokale = new string[10] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
            for (int i = 0; i < Vokale.Length; i++)
            {
                ausgabe = ZeichenErsetzen(ausgabe, Vokale[i], "");
            }
            //ausgabe = ZeichenErsetzen(ausgabe, "a", "");
            //ausgabe = ZeichenErsetzen(ausgabe, "A", "");
            //ausgabe = ZeichenErsetzen(ausgabe, "e", "");
            return ausgabe;
        }

        static int QuersummeBerechnen(string Zahl)
        {
            int quersumme=0;
            //berechnen
            return quersumme;
        }       

    }
}
