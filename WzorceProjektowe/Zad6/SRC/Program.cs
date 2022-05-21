const int   CloseDecision = 0;
int         Decision = 1;
Hero        hero = null;
bool        HeroHasGloves = false,HeroHasBoots = false,HeroHasPants=false,
            HeroHasHelmet = false,HeroHasSword = false;    
Console.WriteLine("Menu:");
Console.WriteLine("1. Aby stworzyć nowego bohatera naciśnij '1'.");
Console.WriteLine("2. W celu dodania/usunięcia rękawic do/z aktualnego bohatera naciśnij '2'.");
Console.WriteLine("3. W celu dodania/usunięcia butów do/z aktualnego bohatera naciśnij '3'.");
Console.WriteLine("4. W celu dodania/usunięcia spodni do/z aktualnego bohatera naciśnij '4'.");
Console.WriteLine("5. W celu dodania/usunięcia hełmu do/z aktualnego bohatera naciśnij '5'.");
Console.WriteLine("6. W celu dodania/usunięcia miecza do/z aktualnego bohatera naciśnij '6'.");
Console.WriteLine("7. Aby zatrzymać działanie programu naciśnij '0'.");
while (Decision != CloseDecision)
{
    Decision = Convert.ToInt32(Console.ReadLine());
    switch (Decision)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            hero = new MyHero();
            Console.WriteLine("Stworzono nowego bohatera");
            Console.WriteLine("Bohater został utworzony " + hero.Health()
                              + "/" + hero.Attack()+"/"+hero.Defense()
                              +" (HP/atak/obrona).");
            break;
        case 2:
            if (hero != null)
            {
                switch (HeroHasGloves)
                {
                    case true:
                        hero = new RareGloves(hero, HeroHasGloves);
                        Console.WriteLine("Usunięto rękawice");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                          + hero.Health() + "/"
                                          + hero.Attack() + "/"
                                          + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasGloves = false;
                        break;
                    case false:
                        hero = new RareGloves(hero, HeroHasGloves);
                        Console.WriteLine("Dodano rękawice");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                          + hero.Health() + "/"
                                          + hero.Attack() + "/" + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasGloves = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Create Hero First!");
            }
            break;
        case 3:
            if (hero != null)
            {
                switch (HeroHasBoots)
                {
                    case true:
                        hero = new CommmonBoots(hero,HeroHasBoots);
                        Console.WriteLine("Usunięto buty");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                          + hero.Health() + "/" + hero.Attack() + "/" 
                                          + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasBoots = false;
                        break;
                    case false:
                        hero = new CommmonBoots(hero,HeroHasBoots);
                        Console.WriteLine("Dodano buty");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                         + hero.Health() + "/" + hero.Attack() + "/" 
                                         + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasBoots = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Create Hero First!");
            }
            break;
        case 4:
            if (hero != null)
            {
                switch (HeroHasPants)
                {
                    case true:
                        hero = new Pants(hero, HeroHasPants);
                        Console.WriteLine("Usunięto spodnie");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                         + hero.Health() + "/" + hero.Attack() + "/" 
                                         + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasPants = false;
                        break;
                    case false:
                        hero = new Pants(hero, HeroHasPants);
                        Console.WriteLine("Dodano spodnie");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                         + hero.Health() + "/" + hero.Attack() + "/" 
                                         + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasPants = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Create Hero First!");
            }
            break;
        case 5:
            if (hero != null)
            {
                switch (HeroHasHelmet)
                {
                    case true:
                        hero = new EpicHelmet(hero,HeroHasHelmet);
                        Console.WriteLine("Usunięto Hełm");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                         + hero.Health() + "/" + hero.Attack() + "/" 
                                         + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasHelmet = false;
                        break;
                    case false:
                        hero = new EpicHelmet(hero,HeroHasHelmet);
                        Console.WriteLine("Dodano Hełm");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą "   
                                         + hero.Health() + "/" + hero.Attack() + "/" 
                                         + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasHelmet = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Create Hero First!");
            }
            break;
        case 6:
            if (hero != null)
            {
                switch (HeroHasSword)
                {
                    case true:
                        hero = new LegendarySword(hero,HeroHasSword);
                        Console.WriteLine("Usunięto Miecz");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                         + hero.Health() + "/" + hero.Attack() + "/" 
                                         + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasSword = false;
                        break;
                    case false:
                        hero = new LegendarySword(hero,HeroHasSword);
                        Console.WriteLine("Dodano Miecz");
                        Console.WriteLine("Statystyki bohatera zostały zaktualizowane i wynoszą " 
                                         + hero.Health() + "/" + hero.Attack() + "/" 
                                         + hero.Defense() + " (HP/atak/obrona).");
                        HeroHasSword = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Create Hero First!");
            }
            break;
        default:
            Console.WriteLine("Didn't Implemented");
            break;
    }
}