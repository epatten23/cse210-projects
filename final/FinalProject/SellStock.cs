public class SellStock: Portfolio{
    public void SellStocks(){
        Console.WriteLine("What stock do you want to sell? Enter the ticker symbol: ");
        string symbol = Console.ReadLine();
        Console.WriteLine("How many shares do you want to sell?");
        int shares = Convert.ToInt32(Console.ReadLine());

            if(stocks.Exists(x => x.symbol == symbol)){
                var stocking = stocks.Find(x => x.symbol == symbol);
                if(stocking.shares >= shares){
                    stocking.shares -= shares;
                    Console.WriteLine($"Selling: ${api.GetPrice(symbol) * shares}");
                    if(stocking.shares == 0){
                        stocks.Remove(stocking);
                        Console.WriteLine("You have sold all of your shares.");
                    }
                }
                else if (stocking.shares < shares){
                    if(stocks.Exists(x => x.symbol == symbol)){
                    var stockling = stocks.Find(x => x.symbol == symbol);
                    if(stockling.shares <= shares){
                        stockling.shares -= shares;
                        Console.WriteLine($"Selling: ${api.GetPrice(symbol) * shares}");
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