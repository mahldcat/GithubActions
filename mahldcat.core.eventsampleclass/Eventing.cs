namespace mahldcat.core.eventsampleclass;

public delegate void EventHandlerPrimary(object sender, PrimaryEventArgs args);
    
public class Eventing
{
    public event EventHandlerPrimary PrimaryEvent = null!;

    public void OnEventHandlerPrimary(string arg)
    {
        if (PrimaryEvent != null)
        {
            PrimaryEvent(this, new PrimaryEventArgs(arg));
        }
    }
}
