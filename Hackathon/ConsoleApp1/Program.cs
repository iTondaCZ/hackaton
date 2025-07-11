namespace hackaton2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====MULTIFUNKČNÍ APLIKACE====");
            Console.WriteLine("Co chceš dělat?");
            Console.WriteLine("1) Kalkulačka normální, 2D, 3D");
            Console.WriteLine("2) Generátor hesel");
            Console.WriteLine("3) Složité matematické příklady");
            string aplikace = Console.ReadLine();
            int aplikaceInt;
            bool prevedeno = int.TryParse(aplikace, out aplikaceInt);
            if (prevedeno)
            {
                if (aplikaceInt == 1)
                {
                    Console.WriteLine("===KALKULAČKA===");
                    Console.WriteLine("Co chceš dělat? Zmáčkni číslo dané činnosti");
                    Console.WriteLine("1) Sčítání, odčítání, násobení a dělení, dělení jídla");
                    Console.WriteLine("2) Počítání obsahu a obvodu");
                    Console.WriteLine("3) Počítání objemu a povrchu");

                    string moznost = Console.ReadLine();
                    int moznostInt;
                    bool success = int.TryParse(moznost, out moznostInt);

                    if (success)
                    {
                        if (moznostInt == 1)
                        {
                            // Základní početní operace
                            Console.WriteLine("Chceš: 1) sčítat, 2) odčítat, 3) násobit, 4) dělit 5) rozdělit jídlo mezi žáky");
                            moznost = Console.ReadLine();
                            bool success2 = int.TryParse(moznost, out moznostInt);

                            if (success2)
                            {
                                if (moznostInt == 5) // celý tohle je na rozpočítání jídla
                                {
                                    Console.WriteLine("Kolik je jídla? Je jedno, jestli v kusech, kilech, nebo gramech, ale zadej jenom cislo.");
                                    string jidlo = Console.ReadLine();
                                    Console.Write("Zadej počet žáků: ");
                                    string zaci = Console.ReadLine();

                                    double jidloDouble, zaciDouble;
                                    bool ok3 = double.TryParse(jidlo, out jidloDouble);
                                    bool ok4 = double.TryParse(zaci, out zaciDouble);
                                    Console.WriteLine($"Když je {zaciDouble} a {jidloDouble}, na jednoho žáka je {jidloDouble / zaciDouble} jídla");
                                } // tady končí rozpočítávání jídla

                                else
                                {
                                    Console.Write("Zadej první číslo: ");
                                    string vstup1 = Console.ReadLine();
                                    Console.Write("Zadej druhé číslo: ");
                                    string vstup2 = Console.ReadLine();

                                    double cislo1, cislo2;
                                    bool ok1 = double.TryParse(vstup1, out cislo1);
                                    bool ok2 = double.TryParse(vstup2, out cislo2);

                                    if (ok1 && ok2)
                                    {
                                        if (moznostInt == 1)
                                            Console.WriteLine($"Výsledek: {cislo1} + {cislo2} = {cislo1 + cislo2}");
                                        else if (moznostInt == 2)
                                            Console.WriteLine($"Výsledek: {cislo1} - {cislo2} = {cislo1 - cislo2}");
                                        else if (moznostInt == 3)
                                            Console.WriteLine($"Výsledek: {cislo1} * {cislo2} = {cislo1 * cislo2}");
                                        else if (moznostInt == 4)
                                        {
                                            if (cislo2 == 0)
                                                Console.WriteLine("Chyba: dělení nulou není povoleno.");
                                            else
                                                Console.WriteLine($"Výsledek: {cislo1} / {cislo2} = {cislo1 / cislo2}");
                                        }
                                        else Console.WriteLine("Neplatná volba.");
                                    }
                                    else Console.WriteLine("Chybný vstup, zadej čísla správně.");
                                }
                            }
                            else Console.WriteLine("Něco jsi udělal špatně");
                        }
                        else if (moznostInt == 2) // 2d tvary
                        {
                            Console.WriteLine("Vyber tvar: 1) Obdélník 2) Kruh");
                            moznost = Console.ReadLine();
                            bool success2 = int.TryParse(moznost, out moznostInt);

                            if (success2)
                            {
                                if (moznostInt == 1)
                                {
                                    Console.Write("Zadej délku: ");
                                    string delkaStr = Console.ReadLine();
                                    Console.Write("Zadej šířku: ");
                                    string sirkaStr = Console.ReadLine();

                                    double delka, sirka;
                                    bool ok1 = double.TryParse(delkaStr, out delka);
                                    bool ok2 = double.TryParse(sirkaStr, out sirka);

                                    if (ok1 && ok2)
                                    {
                                        double obsah = delka * sirka;
                                        double obvod = 2 * (delka + sirka);
                                        Console.WriteLine($"Obsah obdélníku je {obsah}");
                                        Console.WriteLine($"Obvod obdélníku je {obvod}");
                                    }
                                    else Console.WriteLine("Špatně zadané rozměry.");
                                }
                                else if (moznostInt == 2)
                                {
                                    Console.Write("Zadej poloměr: ");
                                    string polomerStr = Console.ReadLine();

                                    double polomer;
                                    bool ok = double.TryParse(polomerStr, out polomer);

                                    if (ok)
                                    {
                                        double obsah = Math.PI * polomer * polomer;
                                        double obvod = 2 * Math.PI * polomer;
                                        Console.WriteLine($"Obsah kruhu je {obsah}");
                                        Console.WriteLine($"Obvod kruhu je {obvod}");
                                    }
                                    else Console.WriteLine("Špatně zadaný poloměr.");
                                }
                                else Console.WriteLine("Neplatná volba tvaru.");
                            }
                            else Console.WriteLine("Něco jsi udělal špatně");
                        }
                        else if (moznostInt == 3) // 3d tvary
                        {
                            Console.WriteLine("Vyber tvar: 1) Kvádr 2) Koule 3) Válec");
                            moznost = Console.ReadLine();
                            bool success2 = int.TryParse(moznost, out moznostInt);

                            if (success2)
                            {
                                if (moznostInt == 1)
                                {
                                    Console.Write("Zadej délku: ");
                                    string delkaStr = Console.ReadLine();
                                    Console.Write("Zadej šířku: ");
                                    string sirkaStr = Console.ReadLine();
                                    Console.Write("Zadej výšku: ");
                                    string vyskaStr = Console.ReadLine();

                                    double delka, sirka, vyska;
                                    bool ok1 = double.TryParse(delkaStr, out delka);
                                    bool ok2 = double.TryParse(sirkaStr, out sirka);
                                    bool ok3 = double.TryParse(vyskaStr, out vyska);

                                    if (ok1 && ok2 && ok3)
                                    {
                                        double objem = delka * sirka * vyska;
                                        double povrch = 2 * (delka * sirka + delka * vyska + sirka * vyska);
                                        Console.WriteLine($"Objem kvádru je {objem}");
                                        Console.WriteLine($"Povrch kvádru je {povrch}");
                                    }
                                    else Console.WriteLine("Špatně zadané rozměry.");
                                }
                                else if (moznostInt == 2)
                                {
                                    Console.Write("Zadej poloměr: ");
                                    string polomerStr = Console.ReadLine();

                                    double polomer;
                                    bool ok = double.TryParse(polomerStr, out polomer);

                                    if (ok)
                                    {
                                        double objem = (4.0 / 3.0) * Math.PI * Math.Pow(polomer, 3);
                                        double povrch = 4 * Math.PI * polomer * polomer;
                                        Console.WriteLine($"Objem koule je {objem}");
                                        Console.WriteLine($"Povrch koule je {povrch}");
                                    }
                                    else Console.WriteLine("Špatně zadaný poloměr.");
                                }
                                else if (moznostInt == 3)
                                {
                                    Console.Write("Zadej poloměr: ");
                                    string polomerStr = Console.ReadLine();
                                    Console.Write("Zadej výšku: ");
                                    string vyskaStr = Console.ReadLine();

                                    double polomer, vyska;
                                    bool ok1 = double.TryParse(polomerStr, out polomer);
                                    bool ok2 = double.TryParse(vyskaStr, out vyska);

                                    if (ok1 && ok2)
                                    {
                                        double objem = Math.PI * polomer * polomer * vyska;
                                        double povrch = 2 * Math.PI * polomer * (polomer + vyska);
                                        Console.WriteLine($"Objem válce je {objem}");
                                        Console.WriteLine($"Povrch válce je {povrch}");
                                    }
                                    else Console.WriteLine("Špatně zadané hodnoty.");
                                }
                                else Console.WriteLine("Neplatná volba tvaru.");
                            }
                            else Console.WriteLine("Něco jsi udělal špatně");
                        }
                        else Console.WriteLine("Neznámá volba.");
                    }
                    else Console.WriteLine("Buď jsi se překlikl nebo nemáš oči");
                }
                if (aplikaceInt == 2) // generátor hesel
                {
                    Console.WriteLine("===GENERÁTOR HESEL===");
                    Console.Write("Zadejte požadovanou délku hesla: ");
                    int delka;
                    while (!int.TryParse(Console.ReadLine(), out delka) || delka <= 0)
                    {
                        Console.Write("Neplatná hodnota!");
                    }

                    Console.Write("Chcete použít speciální znaky? (a/n): ");
                    string volba = Console.ReadLine().ToLower();

                    string pismenaCisla = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; //znaky, které může použít
                    string specialniZnaky = "!@#$%^&*()_+-=[]{}|;:',.<>?/`";

                    string vsechnyZnaky = pismenaCisla;
                    bool pouzitSpecialni = (volba == "a");

                    if (pouzitSpecialni)
                    {
                        vsechnyZnaky += specialniZnaky;
                    }
                    Random nahoda = new Random();
                    string heslo;

                    do
                    {
                        heslo = "";
                        for (int i = 0; i < delka; i++)
                        {
                            int index = nahoda.Next(vsechnyZnaky.Length);
                            heslo += vsechnyZnaky[index];
                        }
                    }
                    while (pouzitSpecialni && !heslo.Any(c => specialniZnaky.Contains(c)));
                    Console.WriteLine("Vygenerované heslo: " + heslo);
                }
                if (aplikaceInt == 3) // Matematické příklady
                {
                    Console.WriteLine("===PROCVIČOVÁNÍ MATEMATIKY===");
                    Random rnd = new Random();

                    int increment1 = 10;//base number 1 and 2
                    int increment2 = 5;
                    char operator1 = '+';//used operator in problem

                    int doubleincrement1 = 10;//amount of added increment to base number 1 amd 2
                    int doubleincrement2 = 5;

                    int tripleincrement1 = 10;//amount of added increment to double increment 1 and 2
                    int tripleincrement2 = 5;

                    for (int i = 1; i > -1; i++)
                    {
                        int number1 = rnd.Next(increment2, increment1);//makes the numbers 1 and 2 random
                        int number2 = rnd.Next(increment2, increment1);
                        Console.WriteLine($"{i}. Otázka");
                        Console.WriteLine($"Kolik je {number1} {operator1} {number2}");
                        string odpoved = Console.ReadLine();
                        int odpovedInt;
                        bool success = int.TryParse(odpoved, out odpovedInt);
                        if (success)
                        {
                            if (odpovedInt != number1 + number2)
                            {
                                Console.WriteLine("Špatně!");
                                Console.WriteLine("Správná odpověď:" + (number1 + number2));
                                ; break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Odkdy se 2 cisla rovnaji pismenku?");
                            break;
                        }



                        increment1 = increment1 + doubleincrement1;//buffs the increment gain every loop (caps at some point bc of int limit)
                        increment2 = increment2 + doubleincrement2;

                        doubleincrement1 = doubleincrement1 + tripleincrement1;//buffs the double increment gain
                        doubleincrement2 = doubleincrement2 + tripleincrement2;

                        tripleincrement1 = tripleincrement1 + 10;//unexpectedly, buffs the triple increment gain
                        tripleincrement2 = tripleincrement2 + 5;
                    }

                }



               

            }
            Console.WriteLine("Buď konec programu, nebo se něco stalo špatně");
        }
    }
}
// ahoj (easter egg)