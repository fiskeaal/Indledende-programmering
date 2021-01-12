using System;

namespace Indledende_programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hilken opgave vil du gerne se, skriv et tal fra 1 til 10.");
                Console.WriteLine("Hvis du ikke vil se flere opgaver skal du bare skrive \"stop\".");
                String opgave = Console.ReadLine().ToLower();
                
                
                if (opgave == "stop")
                {
                    break;
                }
                try
                {
                    x = Convert.ToInt32(opgave);
                }
                catch (Exception)
                {
                    Console.WriteLine("Du kan kun skrive tal fra 1 til 10 eller stop");
                    Console.WriteLine("Tryk på en vilkårelig tast for at fortsætte");
                    Console.ReadKey();
                }
                
                switch (x)
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
                                Console.WriteLine(km * 1.54 + " kr.");
                            }
                            else if (km > 100)
                            {
                                Console.WriteLine(km * 0.77 + " kr.");
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
                        Console.WriteLine("Hvor lang skal den være?");
                        string længde = Console.ReadLine();
                        try
                        {
                            int tal = Convert.ToInt32(længde);
                            if (p_n == "n")
                            {
                                for (int i = tal; i > 0; i--)
                                {
                                    Console.Write(i + ", ");
                                }
                            }
                            if (p_n == "p")
                            {
                                for (int i = 1; i <= tal; i++)
                                {
                                    Console.Write(i + ", ");
                                }
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
                        Console.WriteLine("case 6");
                        break;
                    case 7:
                        Console.WriteLine("case 7");
                        break;
                    case 8:
                        Console.WriteLine("case 8");
                        break;
                    case 9:
                        Console.WriteLine("case 9");
                        break;
                    case 10:
                        Console.WriteLine("case 10");
                        break;
                }
            }
        }
    }
}
