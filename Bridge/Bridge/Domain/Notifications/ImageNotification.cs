using Bridge.Infrastructure.Platforms;

namespace Bridge.Domain.Notifications;

public class ImageNotification : Notification
{
    private string _imageUrl;
    public ImageNotification(IPlatform platform, string title, string content, string imageUrl)
        : base(platform, title, content) => _imageUrl = imageUrl;

    public override void Display()
    {
        _platform.RenderHeader(_title);
        _platform.RenderImage(_imageUrl);
        _platform.RenderBody(_content);
        _platform.RenderFooter();
    }
}