// See https://aka.ms/new-console-template for more information
internal class Display : SubjectOfObserver
{
    const int StartingHour = 15, StartingSecondDigitMinutes = 0, StartingFirstDigitMinutes = 0;
    const int LastDigitHours=23,LastMinuteFirstDigit=5,LastMinuteSecondDigit=9;
    int CurrentHour=StartingHour,CurrentSecondDigitMinutes=StartingSecondDigitMinutes,CurrentFirstDigitMinutes=StartingFirstDigitMinutes;
    string Name;
    public Display(string name)
    {
        this.Name = name;
    }
    public void DisplayClock()
    {
        Console.WriteLine("W "+Name+" jest godzina: "+CurrentHour + ":"+CurrentFirstDigitMinutes+CurrentSecondDigitMinutes);
    }
    public void Change()
    {
        if (CurrentHour==LastDigitHours && CurrentFirstDigitMinutes == LastMinuteFirstDigit && CurrentSecondDigitMinutes==LastMinuteSecondDigit)
        {
            CurrentHour=0;
            CurrentFirstDigitMinutes = 0;
            CurrentSecondDigitMinutes = 0;
        }
        else if (CurrentFirstDigitMinutes==LastMinuteFirstDigit && CurrentSecondDigitMinutes==LastMinuteSecondDigit)
        {
            CurrentFirstDigitMinutes = 0;
            CurrentSecondDigitMinutes = 0;
            CurrentHour++;
        }
        else if (CurrentSecondDigitMinutes==LastMinuteSecondDigit)
        {
            CurrentSecondDigitMinutes = 0;
            CurrentFirstDigitMinutes++;
        }
        else
            CurrentSecondDigitMinutes++;
        DisplayClock();
    }
}