namespace CSharp8.Features
{
    public static class PropertyPattern
    {
        public static decimal GetTotalPrice(Phone phone) =>
            phone switch
            {
                { Color: "Red" } => phone.Price * 1.05M,
                { Color: "Green" } => phone.Price * 1.08M,
                { Color: "Black" } => phone.Price * 1.03M,
                _ => phone.Price
            };
    }

    public class Phone
    {
        public string Color { get; set; }
        public int Price { get; set; }
    }
}


class Program{
     var res = TuplePattern.RockPaperScissors("rock", "paper");
            Console.WriteLine(res);
}