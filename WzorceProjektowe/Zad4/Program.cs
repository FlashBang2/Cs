// See https://aka.ms/new-console-template for more information
Console.WriteLine("Central Clock");
Console.WriteLine("Menu");
Console.WriteLine("1.Aby uruchomić zegar centralny naciśnij '1'.");
Console.WriteLine("2.W celu dodania/usunięcia wyświetlacza pokojowego naciśnij '2'.");
Console.WriteLine("3.W celu dodania/usunięcia wyświetlacza kuchennego naciśnij '3'.");
Console.WriteLine("4.W celu dodania/usunięcia wyświetlacza ogrodowego naciśnij '4'.");
Console.WriteLine("5.Aby zatrzymać działanie programu naciśnij '0'.");
Display Room=new Display("pokoju"),Kitchen=new Display("kuchni"),Garden=new Display("ogrodzie");
Display[] Displays;
CentralClock centralClock = new CentralClock();
Thread Clock = new Thread(new ThreadStart(centralClock.Run));
int UserValue = 1; 
const int DisplaySize = 3;
bool RoomActive=false,GardenActive=false,KitchenActive=false;
Displays = new Display[DisplaySize];
while (UserValue!=0)
{
    UserValue=Convert.ToInt32(Console.ReadLine());
    switch (UserValue)
    {
        case 1:
            Console.WriteLine("Zegar centralny zaczął odmierzać czas.");
              Clock.Start();
            break;
        case 2:
            if (RoomActive)
            {
                Console.WriteLine("Usunięto wyświetlacz pokojowy");
                Displays[0]=null;
                RoomActive=false;
                centralClock.Transfer(Displays);
            }
            else 
            {
                Console.WriteLine("Dodano wyświetlacz pokojowy");
                Displays[0]=Room;
                RoomActive=true;
                centralClock.Transfer(Displays);
            }
            break;
        case 3:
            if (KitchenActive)
            {
                Console.WriteLine("Usunięto wyświetlacz kuchenny");
                Displays[1] = null;
                KitchenActive = false;
                centralClock.Transfer(Displays);
            }
            else
            {
                Console.WriteLine("Dodano wyświetlacz kuchenny");
                Displays[1] = Kitchen;
                KitchenActive = true;
                centralClock.Transfer(Displays);
            }
            break;
        case 4:
            if (GardenActive)
            {
                Console.WriteLine("Usunięto wyświetlacz ogrodowy");
                Displays[2] = null;
                GardenActive = false;
                centralClock.Transfer(Displays);
            }
            else
            {
                Console.WriteLine("Dodano wyświetlacz ogrodowy");
                Displays[2] = Garden;
                GardenActive = true;
                centralClock.Transfer(Displays);
            }
            break;
        case 0:
            centralClock.StopClock();
            break;
        default:
            Console.WriteLine("Opcja która wybrałeś nie została zaimplementowania w programie");
            break;
    }
}
Environment.Exit(0);

