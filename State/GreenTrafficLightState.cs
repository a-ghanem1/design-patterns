namespace DesignPatterns.State;

public class GreenTrafficLightState : ITrafficLightState
{
    private readonly TrafficLight _trafficLight;
    public GreenTrafficLightState(TrafficLight trafficLight)
    {
        _trafficLight = trafficLight;
    }

    public void Handle()
    {
        // some logic
        Console.WriteLine("Green Light - MOVE");

        // change state
        _trafficLight.SetState(new GreenTrafficLightState(_trafficLight));
    }
}