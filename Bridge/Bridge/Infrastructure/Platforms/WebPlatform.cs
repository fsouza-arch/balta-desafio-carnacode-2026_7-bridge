namespace Bridge.Infrastructure.Platforms;

public class WebPlatform : IPlatform
{
    public void RenderHeader(string title) => Console.WriteLine($"[Web] <div class='notif'><h3>{title}</h3>");
    public void RenderBody(string content) => Console.WriteLine($"[Web]   <p>{content}</p>");
    public void RenderImage(string url) => Console.WriteLine($"[Web]   <img src='{url}' />");
    public void RenderVideo(string url) => Console.WriteLine($"[Web]   <video src='{url}' controls />");
    public void RenderFooter() => Console.WriteLine("[Web] </div>");
}