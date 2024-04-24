namespace DesignPatterns.Bridge;

public class YoutubeVideoProvider : VideoProvider
{
    private readonly VideoQuality _videoQuality;
    public YoutubeVideoProvider(VideoQuality videoQuality)
    {
        _videoQuality = videoQuality;
    }

    public override void PlayBack(string videoId)
    {
        _videoQuality.Render();
        Console.WriteLine($"Playback youtube video: {videoId}");
    }
}