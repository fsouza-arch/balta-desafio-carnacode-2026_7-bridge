namespace Bridge.Infrastructure.Platforms;

public class DesktopPlatform : IPlatform
{
    public void RenderHeader(string title) => Console.WriteLine($"[Desktop] ╔══ {title} ══╗");
    public void RenderBody(string content) => Console.WriteLine($"[Desktop] ║ {content} ║");
    public void RenderImage(string url) => Console.WriteLine($"[Desktop] ║ [IMG: {url}] ║");
    public void RenderVideo(string url) => Console.WriteLine($"[Desktop] ║ [VIDEO: {url}] ║");
    public void RenderFooter() => Console.WriteLine("[Desktop] ╚══════════════════╝");
}