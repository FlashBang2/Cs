// See https://aka.ms/new-console-template for more information
int Decision=1,SubDecision;
const int CloseSubMenuNumber = 9,CloseApplication=0;
Factory Factory;
while (Decision!= CloseApplication)
{
    SubDecision=0;
    Console.WriteLine("Fabryka");
    Console.WriteLine("Menu");
    Console.WriteLine("1.Aby stworzyć koszary naciśnij '1'.");
    Console.WriteLine("2.Aby stworzyć hangar naciśnij '2'.");
    Console.WriteLine("3.Aby stworzyć port naciśnij '3'.");
    Console.WriteLine("4.Aby wrócić do głównego menu naciśnij '9'.");
    Console.WriteLine("5.Aby zatrzymać działanie programu naciśnij '0'.");
    Decision=Convert.ToInt32(Console.ReadLine());
    switch (Decision)
    {
        case 1:
            Factory = new Barracks();
            Console.WriteLine("Fabryka 'Koszary'");
            Console.WriteLine("1.1 Aby stworzyć żołnierza naciśnij '1'.");
            Console.WriteLine("1.2 Aby stworzyć czołg naciśnij '2'.");
            while (SubDecision != CloseSubMenuNumber)
            {
                SubDecision = Convert.ToInt32(Console.ReadLine());
                switch (SubDecision)
                {
                    case 1:
                        Console.WriteLine("Stworzono żołnierza");
                        Factory.CreateFirstUnit();
                        break;
                    case 2:
                        Console.WriteLine("Stworzono czołg");
                        Factory.CreateSecondUnit();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
            break;
        case 2:
            Factory = new Hangar();
            Console.WriteLine("Fabryka 'Hangar'");
            Console.WriteLine("2.1 Aby stworzyć helikopter naciśnij '1'.");
            Console.WriteLine("2.2 Aby stworzyć samolot naciśnij '2'.");
            while (SubDecision != CloseSubMenuNumber)
            {
                SubDecision = Convert.ToInt32(Console.ReadLine());
                switch (SubDecision)
                {
                    case 1:
                        Console.WriteLine("Stworzono helikopter");
                        Factory.CreateFirstUnit();
                        break;
                    case 2:
                        Console.WriteLine("Stworzono samolot");
                        Factory.CreateSecondUnit();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
            break;
        case 3:
            Factory = new Harbor();
            Console.WriteLine("Fabryka 'Port'");
            Console.WriteLine("3.1 Aby stworzyć statek naciśnij '1'.");
            Console.WriteLine("3.2 Aby stworzyć łódź podwodną naciśnij '2'.");
            while (SubDecision != CloseSubMenuNumber)
            {
                SubDecision = Convert.ToInt32(Console.ReadLine());
                switch (SubDecision)
                {
                    case 1:
                        Console.WriteLine("Stworzono statek");
                        Factory.CreateFirstUnit();
                        break;
                    case 2:
                        Console.WriteLine("Stworzono łódź podwodną");
                        Factory.CreateSecondUnit();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            break;
    }
}
