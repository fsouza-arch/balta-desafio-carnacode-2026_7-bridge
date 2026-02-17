using Bridge.Infrastructure.Platforms;

namespace Bridge.Domain.Notifications;

public abstract class Notification
{
    protected IPlatform _platform; // A PONTE
    protected string _title;
    protected string _content;

    protected Notification(IPlatform platform, string title, string content)
    {
        _platform = platform;
        _title = title;
        _content = content;
    }

    public abstract void Display();
}
