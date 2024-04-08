public class SellOldStock: Portfolio{
    public void SellOldStocks(Stock stock){

            if(stocks.Exists(x => x.symbol == stock.symbol)){
                var stocking = stocks.Find(x => x.symbol == stock.symbol);
                if(stocking.shares >= stock.shares){
                    stocking.shares -= stock.shares;
                    Console.WriteLine($"Selling: ${stock.price * stock.shares}");
                    if(stocking.shares == 0){
                        stocks.Remove(stocking);
                        Console.WriteLine("You have sold all of your shares.");
                    }
                }
                else if (stocking.shares < stock.shares){
                    if(stocks.Exists(x => x.symbol == stock.symbol)){
                    var stockling = stocks.Find(x => x.symbol == stock.symbol);
                    if(stockling.shares <= stock.shares){
                        stockling.shares -= stock.shares;
                        Console.WriteLine($"Selling: ${stock.price * stock.shares}");
                    }
                    else if(stockling.shares == 0){
                            stocks.Remove(stockling);
                            Console.WriteLine("You have sold all of your shares.");
                    }
                }
                }
            }
            else{
                Console.WriteLine("You do not own this stock.");
        }
    }
}