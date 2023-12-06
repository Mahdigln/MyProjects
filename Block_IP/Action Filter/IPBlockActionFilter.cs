using Block_IP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Block_IP.Action_Filter;

public class IPBlockActionFilter : ActionFilterAttribute
{
    private readonly IIPBlockingService _blockingService;
    public IPBlockActionFilter(IIPBlockingService blockingService)
    {
        _blockingService = blockingService;
    }
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var remoteIp = context.HttpContext.Connection.RemoteIpAddress;
        var isBlocked = _blockingService.IsBlocked(remoteIp!);
        if (isBlocked)
        {
            context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
            return;
        }
        base.OnActionExecuting(context);
    }
    
}
