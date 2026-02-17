using Bridge.Infrastructure.Platforms;

namespace Bridge.Domain.Notifications;

public class TextNotification : Notification
{
    public TextNotification(IPlatform platform, string title, string content)
            : base(platform, title, content) { }

    public override void Display()
    {
        _platform.RenderHeader(_title);
        _platform.RenderBody(_content);
        _platform.RenderFooter();
    }
}
