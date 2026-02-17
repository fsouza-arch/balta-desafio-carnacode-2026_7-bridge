using Bridge.Infrastructure.Platforms;

namespace Bridge.Domain.Notifications;

public class VideoNotification : Notification
{
    private string _videoUrl;
    public VideoNotification(IPlatform platform, string title, string content, string videoUrl)
        : base(platform, title, content) => _videoUrl = videoUrl;

    public override void Display()
    {
        _platform.RenderHeader(_title);
        _platform.RenderVideo(_videoUrl);
        _platform.RenderBody(_content);
        _platform.RenderFooter();
    }
}