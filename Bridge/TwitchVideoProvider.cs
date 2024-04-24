namespace DesignPatterns.Bridge;

public class TwitchVideoProvider : VideoProvider
{
    private readonly VideoQuality _videoQuality;
    public TwitchVideoProvider(VideoQuality videoQuality)
    {
        _videoQuality = videoQuality;
    }

    public override void PlayBack(string videoId)
    {
        _videoQuality.Render();
        Console.WriteLine($"Playback twitch video: {videoId}");
    }
}