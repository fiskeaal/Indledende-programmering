using System;

namespace Indledende_programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int swi = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hilken opgave vil du gerne se, skriv et tal fra 1 til 9.");
                Console.WriteLine("Hvis du ikke vil se flere opgaver skal du bare skrive \"stop\".");
                String opgave = Console.ReadLine().ToLower();
                if (opgave == "stop")
                {
                    break;
                }
                try
                {
                    swi = Convert.ToInt32(opgave);
                }
                catch (Exception)
                {
                    Console.WriteLine("Du kan kun skrive tal fra 1 til 10 eller stop");
                    Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                    Console.ReadKey();
                }
                switch (swi)
                {
                    case 1:
                        double modstand = 0; 
                        double volt = 0;
                        double amp = 0;
                        double ohm = 0;
                        Console.WriteLine("Ohms lov");
                        Console.WriteLine("Hvad vil du regne ud, for strømstyrke (i ampare) skriv 1, for spænding (i volt) skriv 2, for modstand (i ohm) skriv 3");
                        string udregn1 = Console.ReadLine();
                        if (udregn1 == "1")
                        {
                            try
                            {
                                Console.WriteLine("Hvor mange volt?");
                                volt = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Hvor stor en modstand");
                                modstand = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(volt / modstand + " ampere");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du kan kun skrive tal");
                                
                            }
                        }
                        else if (udregn1 == "2")
                        {
                            try
                            {
                                Console.WriteLine("Hvor stor en modstand?");
                                ohm = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Hvor mange amps");
                                amp = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(ohm * amp + " volt");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du kan kun skrive tal");
                            }
                        }
                        else if (udregn1 == "3")
                        {
                            try
                            {
                                Console.WriteLine("Hvor mange volt");
                                volt = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Hvor mange amps");
                                amp = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(volt / amp + " ohm");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du kan kun skrive tal");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Du kan kun skrive tal");
                        }
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Cirkelberegninger");
                        Console.WriteLine("Hvad vil du regne ud, for omkreds skriv \"o\", for areal skriv \"a\".");
                        string udregn2 = Console.ReadLine().ToLower();
                        if (udregn2 == "o")
                        {
                            Console.WriteLine("Hvor stor er diameteren?");
                            Console.WriteLine(Convert.ToDouble(Console.ReadLine()) * Math.PI);
                        }
                        else if (udregn2 == "a")
                        {
                            Console.WriteLine("Hvor stor er diameteren?");
                            try
                            {
                                Console.WriteLine(Math.Pow(Convert.ToDouble(Console.ReadLine()), 2) * Math.PI);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du kan kun skrive tal");
                            }
                        }
                        else
                        {
                            
                            Console.WriteLine("Du kan kun skrive o eller a");
                            
                        }
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Befordringsfradrag");
                        Console.WriteLine("Hvor mange km har du kørt?");
                        try
                        {
                            double km = Convert.ToDouble(Console.ReadLine());
                            if (km >= 0 && km < 25)
                            {
                                Console.WriteLine("Ingen fradrag.");
                            }
                            else if (km >= 25 && km <= 100)
                            {
                                Console.WriteLine((km - 24) * 1.54 + " kr.");
                            }
                            else if (km > 100)
                            {
                                double pris = 76 * 1.54;
                                pris += ((km - 100) * 0.77);
                                Console.WriteLine("{0:0.00} kr.", pris);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du kan kun skrive tal");
                        }
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Billetpriser");
                        Console.WriteLine("Skal du købe en eller flere billetter? Skriv \"en\" eller \"flere\"");
                        string en_eller_flere = Console.ReadLine().ToLower();
                        if (en_eller_flere == "en")
                        {
                            Console.WriteLine("Hvor gammel er du?");
                            try
                            {
                                double alder = Convert.ToDouble(Console.ReadLine());
                                if (alder < 18)
                                {
                                    Console.WriteLine("35 kr.");
                                }
                                else if (alder > 18 && alder < 60)
                                {
                                    Console.WriteLine("65 kr.");
                                }
                                else if (alder > 60)
                                {
                                    Console.WriteLine("30 kr.");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du kan kun skrive tal");
                            }
                        }
                        else if (en_eller_flere == "flere")
                        {
                            Console.WriteLine("Hvor gammel er i? Skriv 0 hvis der er tomme felter");
                            Console.WriteLine("Antal under 18 år:");
                            Console.WriteLine("Antal over 18 år :");
                            Console.WriteLine("Antal over 60 år :");
                            try
                            {
                                Console.SetCursorPosition(19, 7);
                                int under18 = Convert.ToInt32(Console.ReadLine());
                                Console.SetCursorPosition(19, 8);
                                int over18 = Convert.ToInt32(Console.ReadLine());
                                Console.SetCursorPosition(19, 9);
                                int over60 = Convert.ToInt32(Console.ReadLine());
                                int pris = (under18 * 35) + (over18 * 65) + (over60 * 30);
                                Console.WriteLine($"Prisen bliver {pris} kr.");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du kan kun skrive tal");
                            }
                        }
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Talrække");
                        Console.WriteLine("Skal talrækken være positiv eller negativ? (p/n)");
                        string p_n = Console.ReadLine().ToLower();
                        try
                        {
                            if (p_n == "n")
                            {
                                Console.WriteLine("Hvor lang skal den være?");
                                string længde1 = Console.ReadLine();
                                int tal1 = Convert.ToInt32(længde1);
                                for (int i = tal1; i > 0; i--)
                                {
                                    Console.Write(i + ", ");
                                }
                            }
                            else if (p_n == "p")
                            {
                                Console.WriteLine("Hvor lang skal den være?");
                                string længde2 = Console.ReadLine();
                                int tal2 = Convert.ToInt32(længde2);
                                for (int i = 1; i <= tal2; i++)
                                {
                                    Console.Write(i + ", ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Du kan kun skrive p eller n");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du kan kun skrive tal");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Enkelt ramme");
                        Console.WriteLine("Hvor stor skal rammen være? Skriv x og y kordinat for første hjørne, derefter x og y for andet hjørne.");
                        Console.WriteLine("første kordinat skal være mindre end andet kordinat");
                        int hjørne1x;
                        int hjørne1y;
                        int hjørne2x;
                        int hjørne2y;
                        try
                        {
                            swi = Convert.ToInt32(opgave);
                            hjørne1x = Convert.ToInt32(Console.ReadLine());
                            hjørne1y = Convert.ToInt32(Console.ReadLine());
                            hjørne2x = Convert.ToInt32(Console.ReadLine());
                            hjørne2y = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du kan kun skrive tal");
                            Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                            Console.ReadKey();
                            break;
                        }
                        int x = hjørne1x;
                        int y = hjørne1y;
                        int interval = 0;
                        
                        Console.SetCursorPosition(4,4);
                        for (y = hjørne1y; y < hjørne2y - 1; y++)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("║");
                        }
                        //y++;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("╚");
                        for (x = hjørne1x + 1; x < hjørne2x - 2; x++)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("═");
                        }
                        Console.SetCursorPosition(x, y);
                        //x++;
                        Console.WriteLine("╝");
                        for (y = hjørne2y - 2; y > hjørne1y; y--)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("║");
                        }
                        //y --;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("╗");
                        for (x = hjørne2x - 3; x > hjørne1x; x--)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("═");
                        }
                        //x--;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("╔");
                        Console.SetCursorPosition(1, hjørne2y + 5);
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Opgave 7: Tabel");
                        Console.WriteLine("Hvilken tabel vil de gerne se?");
                        try
                        {
                            int tabeltal = Convert.ToInt32(Console.ReadLine());
                            int tabel = tabeltal;
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write(tabel + ", ");
                                tabel += tabeltal;
                                
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du kan kun skrive tal");
                            Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Opgave 8: Arealberegning");
                        Console.WriteLine("Hvad vil du gerne beregne arealet af, for cirkel skriv 1, trekant 2, rektangel 3.");
                        try
                        {
                            int beregn = Convert.ToInt32(Console.ReadLine());
                            if (beregn == 1)
                            {
                                Console.WriteLine("hvad er radius?");
                                Console.WriteLine(cirkelberegner(Convert.ToDouble(Console.ReadLine())));
                            }
                            else if (beregn == 2)
                            {
                                Console.WriteLine("hvad er højden og bredden?");
                                Console.WriteLine(trekantsberegner(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                            }
                            else if (beregn == 3)
                            {
                                Console.WriteLine("hvad er længden og bredden?");
                                Console.WriteLine(rektangelberegner(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                            }
                            else
                            {
                                Console.WriteLine("Du skal skrive et tal imellem 1 og 3.");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Du kan kun skrive tal");
                            Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 9:
                        string navn = "tore";
                        int gæt = 0;
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Opgave 9: Gæt mit navn");
                            Console.WriteLine("Bare skriv dit gæt");
                            if (Console.ReadLine().ToLower() == navn)
                            {
                                Console.WriteLine("Tillykke du gættede det :)");
                                break;
                            }
                            else
                            {
                                gæt++;
                                Console.WriteLine("Desværre forkert :(");
                                Console.WriteLine("Du er oppe på " + gæt + " gæt.");
                                Console.WriteLine("prøv igen");
                                Console.WriteLine("Tryk på enter for at prøve igen, skriv stop for at stoppe");
                                if (Console.ReadLine().ToLower() == "stop")
                                {
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }
        static double cirkelberegner(double radius)
        {

            double areal = (Math.Pow(radius, 2) * Math.PI);
            return areal;
        }
        static double trekantsberegner (double højde, double bredde)
        {

            double areal = (højde * bredde) / 2;
            return areal;
        }
        static double rektangelberegner(double længde, double bredde)
        {

            double areal = længde * bredde;
            return areal;
        }
    }
}
