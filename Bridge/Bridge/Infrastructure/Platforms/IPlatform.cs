namespace Bridge.Infrastructure.Platforms;

public interface IPlatform
{
    void RenderHeader(string title);
    void RenderBody(string content);
    void RenderImage(string url);
    void RenderVideo(string url);
    void RenderFooter();
}
