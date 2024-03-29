using System.Globalization;
using FluentAssertions;

namespace mahldcat.core.eventsampleclass.tests;

public class EventTests
{
    [Fact]
    public void OnEventHandlerPrimaryWithNoEvent()
    {
        Eventing eventing = new Eventing();
        eventing.OnEventHandlerPrimary("arg");
    }
    
    [Fact]
    public void OnEventHandlerPrimaryWithEvent()
    {
        Eventing eventing = new Eventing();

        string eventArgSent = "blarg";

        string eventArgReturn = string.Empty;

        eventing.PrimaryEvent += new EventHandlerPrimary((sender, args) =>
        {
            eventArgReturn = args.ArgValue;
        });
        eventing.OnEventHandlerPrimary(eventArgSent);

        eventArgReturn.Should().Be(eventArgSent);
    }

}