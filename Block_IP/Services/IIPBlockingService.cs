using System.Net;

namespace Block_IP.Services
{
    public interface IIPBlockingService
    {
        bool IsBlocked(IPAddress ipAddress);
    }
}
