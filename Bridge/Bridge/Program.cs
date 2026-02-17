using Bridge.Domain.Notifications;
using Bridge.Infrastructure.Platforms;

Console.WriteLine("=== Sistema de Notificações (Padrão Bridge) ===\n");

// Agora podemos combinar QUALQUER tipo com QUALQUER plataforma
// Sem precisar criar classes específicas para cada combinação!

IPlatform web = new WebPlatform();
IPlatform mobile = new MobilePlatform();
IPlatform desktop = new DesktopPlatform();

// 1. Notificação de Texto na Web
var n1 = new TextNotification(web, "Alerta", "Sessão expirando");
n1.Display();
Console.WriteLine();

// 2. Notificação de Imagem no Mobile
var n2 = new ImageNotification(mobile, "Promoção", "50% OFF", "promo.png");
n2.Display();
Console.WriteLine();

// 3. Notificação de Vídeo no Desktop
var n3 = new VideoNotification(desktop, "Tutorial", "Veja como usar", "aula.mp4");
n3.Display();
Console.WriteLine();
