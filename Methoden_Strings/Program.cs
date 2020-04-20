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
                Console.WriteLine("4: Passwortstärke prüfen.");
                Console.WriteLine("5: Würfel");

                //short 123 
                //string "dkjsfbela63468" 
                //"8"       '8'     8       8.0 
                //string    char    int     double
                ushort auswahl; //short ist eine 16Bit Ganzzahl und ushort (unsigned) nur positive Zahlen 
                auswahl = Convert.ToUInt16(Console.ReadLine());

                //Zufallszahlengenerator
                Random rnd = new Random();

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
                        Console.WriteLine("Zahl eingeben:");
                        eingabe = Console.ReadLine();
                        ausgabe = QuersummeBerechnen(eingabe).ToString();
                        Console.WriteLine("Die Quersumme von "+eingabe + " ist " +ausgabe);
                        //Methode verwenden
                        break;

                    case 4:
                        Console.WriteLine("Das Passwort soll mindestens acht Zeichen lang sein und mindestens einen kleinen und einen großen Buchstaben, sowie mindestens eine Ziffer enthalten und Sonderzeichen sind nicht erlaubt!");
                        Console.WriteLine("Passwort eingeben:");
                        eingabe = Console.ReadLine();

                        if(eingabe.Length < 8)
                        {
                            Console.WriteLine("Das Passwort ist zu kurz!");
                        }
                        else if (ContainsLowerCase(eingabe)==false)
                        {
                            Console.WriteLine("Das Passwort enthält keine Kleinbuchstaben!");
                        }
                        else if (ContainsUpperCase(eingabe) == false)
                        {
                            Console.WriteLine("Das Passwort enthält keine Großbuchstaben!");
                        }
                        else if (ContainsNumber(eingabe) == false)
                        {
                            Console.WriteLine("Das Passwort enthält keine Ziffern!");
                        }
                        else if (ContainsSpecial(eingabe) == true)
                        {
                            Console.WriteLine("Das Passwort enthält Sonderzeichen!");
                        }
                        else
                        {
                            Console.WriteLine("Gutes Passwort.");
                        }
                        break;

                    case 5:
                        //int Zufallszahl;
                        for (int i = 0; i < 10; i++)
                        {
                            //Zufallszahl = rnd.Next(1, 7);
                            //Console.WriteLine(Zufallszahl);
                            // kurz:
                           // Console.WriteLine(rnd.Next(1,7));

                            //Console.WriteLine(rnd.NextDouble()*10);
                            //Würfel beeinflussen, sodass die 1 dreimal häufiger als die anderen Zahlen geworfen wird:
                            //Würfel mit acht Seiten davon dreimal 1 -> p(1)=3/8 und p(2)=p(3)=...=p(6)=1/8
                            int wurf = rnd.Next(1, 9);
                            if(wurf==7 || wurf==8)
                            {
                                wurf = 1;
                            }
                            Console.WriteLine(wurf);
                        }
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
            for (int i = 0; i < Zahl.Length; i++)
            {
                quersumme += Convert.ToInt32( Zahl[i].ToString());
            }
            return quersumme;

            //char -> int: gibt die Nummer aus der ASCII Tabelle
            //string -> int: gibt den Wert der Zahl
        }  
        
        static bool ContainsLowerCase(string s)
        {
            bool bedingung=false;
            for (int i = 0; i < s.Length; i++)
            {
                if(Char.IsLower(s[i]) )
                {
                    bedingung = true;
                    break;
                }
            }
            return bedingung;
        }

        static bool ContainsUpperCase(string s)
        {
            bool bedingung = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    bedingung = true;
                    break;
                }
            }
            return bedingung;
        }

        static bool ContainsNumber(string s)
        {
            bool bedingung = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsNumber(s[i]))
                {
                    bedingung = true;
                    break;
                }
            }
            return bedingung;
        }

        static bool ContainsSpecial(string s)
        {
            bool bedingung = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetterOrDigit(s[i])==false)
                {
                    bedingung = true;
                    break;
                }
            }
            return bedingung;
        }

    }
}
