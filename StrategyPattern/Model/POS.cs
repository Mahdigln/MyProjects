namespace StrategyPattern.Model;

public class POS
{
    public int TrackId { get; set; }
    public string MerchantName { get; set; }
    public string CustomerName { get; set; }
    public PSPEnum PSP { get; set; }

    public override string ToString()
    {
        return $"{MerchantName} [{CustomerName}] ({TrackId}) -> {PSP.ToString()}";
    }
}