namespace mahldcat.core.eventsampleclass;

public class PrimaryEventArgs:EventArgs
{
    public string ArgValue { get; private set; }
    public PrimaryEventArgs(string argValue)
    {
        ArgValue = argValue;
    }
}