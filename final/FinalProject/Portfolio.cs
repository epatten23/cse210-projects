using System.Runtime.InteropServices.Marshalling;
abstract public class Portfolio{
    public static List<Stock> stocks = new List<Stock>();
    public GrabApi api = new GrabApi();
    
    public void ShowPortolio(){
        foreach (Stock stock in stocks){
            stock.ShowStock();
        }
    }
    public void TotalValue(){
        double total = 0;
        foreach (Stock stock in stocks){
            total += stock.price * stock.shares;
        }
        Console.WriteLine($"Total Value: {total}");
    }
}