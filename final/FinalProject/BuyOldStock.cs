public class BuyOldStock: Portfolio{
    public void AddStocks(Stock stock){
        if(stocks.Exists(x => x.symbol == stock.symbol)){
             var stocking = stocks.Find(x => x.symbol == stock.symbol);
             stocking.shares += stock.shares;
             Console.WriteLine($"You now have {stocking.shares} shares of {stocking.symbol}.");
             stock.price += stocking.shares * api.GetPrice(stock.symbol);
         }
        else{
        stocks.Add(stock);
         }
    }
}
