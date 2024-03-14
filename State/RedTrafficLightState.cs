namespace DesignPatterns.State
{
    public class RedTrafficLightState : ITrafficLightState
    {
        private readonly TrafficLight _trafficLight;
        public RedTrafficLightState(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public void Handle()
        {
            // some logic
            Console.WriteLine("Red Light - STOP");

            // change state
            _trafficLight.SetState(new GreenTrafficLightState(_trafficLight));
        }
    }
}