using System.Text.Json;

public class Save{
    // new AddStock portfolio = new AddStock();
    public void SavePortfolio(){
        using (StreamWriter writer = new StreamWriter("portfolio.txt"))
        {
            writer.WriteLine(JsonSerializer.Serialize(AddStock.stocks));
        }
    }
    public void CallPortfolio(){
        foreach (string line in File.ReadLines("portfolio.txt"))
        {
            AddStock.stocks = JsonSerializer.Deserialize<List<Stock>>(line);
        }
    }
}