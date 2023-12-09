using StrategyPattern.Model;
using StrategyPattern.Service;
using StrategyPattern;

try
{
    var pos = new POS()
    {
        CustomerName = "Mahdi",
        MerchantName = "Online Shop",
        PSP = PSPEnum.IranKish,
        TrackId = 1024
    };
    PSPService service = new PSPService(pos.PSP);
    service.AddAcceptor(pos);
    service.EditAcceptor(pos);
    service.Inquery(pos.TrackId);
}
catch (Exception ex)
{
    throw null;
}
Console.ReadLine();