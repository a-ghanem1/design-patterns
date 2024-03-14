namespace DesignPatterns.State;

public class TrafficLight
{
    private ITrafficLightState _trafficLightState;
    public TrafficLight()
    {
        _trafficLightState = new GreenTrafficLightState(this);
    }

    public void SetState(ITrafficLightState trafficLightState)
    {
        _trafficLightState = trafficLightState;
    }

    public void Change()
    {
        _trafficLightState.Handle();
    }
}