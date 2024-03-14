namespace DesignPatterns.State;

public class YellowTrafficLightState : ITrafficLightState
{
    private readonly TrafficLight _trafficLight;
    public YellowTrafficLightState(TrafficLight trafficLight)
    {
        _trafficLight = trafficLight;
    }

    public void Handle()
    {
        // some logic
        Console.WriteLine("Yellow Light - STOP");

        // change state
        _trafficLight.SetState(new RedTrafficLightState(_trafficLight));
    }
}