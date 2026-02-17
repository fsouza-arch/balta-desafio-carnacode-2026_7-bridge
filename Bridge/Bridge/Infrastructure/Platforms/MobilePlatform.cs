namespace Bridge.Infrastructure.Platforms;

public class MobilePlatform : IPlatform
{
    public void RenderHeader(string title) => Console.WriteLine($"[Mobile] Push Title: {title}");
    public void RenderBody(string content) => Console.WriteLine($"[Mobile] Body: {content}");
    public void RenderImage(string url) => Console.WriteLine($"[Mobile] Rich Content (Image): {url}");
    public void RenderVideo(string url) => Console.WriteLine($"[Mobile] Rich Content (Video): {url}");
    public void RenderFooter() => Console.WriteLine("[Mobile] --- Fim da Notificação ---");
}