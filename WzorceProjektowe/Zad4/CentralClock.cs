using System;
using System.Threading;
    internal class CentralClock : Observer
    {
        int ElapsedSeconds = 0;
        bool Running = true;
    const int MinuteInSeconds = 60;
        Display[] Displays;
    public void Transfer(Display[] displays)
    {
        Displays = displays;
    }
    public void StopClock()
    {
        Running = false;
    }
    public void Run()
    {
        while (Running)
        {
            try
            {
               ElapsedSeconds = ElapsedSeconds + 5;
               if (ElapsedSeconds % MinuteInSeconds == 0 && ElapsedSeconds != 0)
                  {
                     Update(Displays);
                  }
                     Thread.Sleep(5000);
            }
            catch (ThreadInterruptedException Exception)
                  {
                     Console.WriteLine(Exception);
                  }
        }
    }
    public void Update(Display[] Displays)
    {
       foreach (Display Element in Displays)
       {
         if (Element != null)
            Element.Change();            
       }
    }
}