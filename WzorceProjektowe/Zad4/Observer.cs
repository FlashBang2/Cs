    internal interface Observer
    {
        void Transfer(Display[] displays);
        void StopClock();
        void Update(Display[] Displays);
    }
