using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

public class Goal{
    public string name {get; set;}
    public string points {get; set;}
    public double pointnumber;
    public string description {get; set;}
    public string type {get; set;}
    public string accomplished {get; set;}
    public string bonus {get; set;}
    public List<string> goals = new List<string>();
    public double done = 0;
    public string checklist;
    public List<Goal> entry = new List<Goal>();
    public List<string> jsonentries = new List<string>();
    public Dictionary<string, string> nameDict = new Dictionary<string, string>();
    public double count = 1;
    public string completedSymbol {get; set;} = " ";
    public double completedAmount;
    public string filename;
    public void DisplayPoints(){
        Console.WriteLine($"\nYou have {pointnumber} points. \n");
    }
//     public void UpdateCompletedSymbolInFile(string filename, string goalName, string newCompletedSymbol)
// {
//     // Step 1: Read the file
//     var lines = File.ReadAllLines(filename).ToList();
    
//     foreach(string line in lines){
//         if(line.GetType() == typeof(int)){
//             for (int i = 0; i < lines.Count; i++)
//             {
//                 var goalDict = JsonSerializer.Deserialize<Dictionary<string, string>>(lines[i]);
//                 if (goalDict != null && goalDict.ContainsKey("name") && goalDict["name"] == goalName)
//                 {
//                     goalDict["completedSymbol"] = newCompletedSymbol;
//                     lines[i] = JsonSerializer.Serialize(goalDict);
//                     break; // Exit the loop once the line is found and updated
//                 }
//             }
//         }
//     }
//     File.WriteAllLines(filename, lines);
// }

    public void DisplayListedGoals(){
        count = 1;
        Console.WriteLine("Here are your goals: ");
        foreach(Goal goal in entry){
            Console.WriteLine($"{count}. {goal.FormatGoalsforFile()}");
            count++;
        }
    }
    public void LoadGoals(){
        Console.Write("What file would you like to load from?(Text file)");
        filename = Console.ReadLine();

        foreach (string line in File.ReadLines(filename))
            if (line.Contains("ChecklistGoal"))
            {
                nameDict = JsonSerializer.Deserialize<Dictionary<string,string>>(line);
                name = nameDict["name"];
                type = nameDict["type"];
                description = nameDict["description"];
                points = nameDict["points"];
                accomplished = nameDict["accomplished"];
                bonus = nameDict["bonus"];
                entry.Add(new ChecklistGoal{
                    name = name,
                    type = type,
                    description = description,
                    points = points,
                    pointnumber = double.Parse(points),
                    accomplished = accomplished,
                    bonus = bonus,
                    completedSymbol = completedSymbol
                });
            }
            else if (line.Contains("EternalGoal"))
            {
                nameDict = JsonSerializer.Deserialize<Dictionary<string,string>>(line);
                name = nameDict["name"];
                type = nameDict["type"];
                description = nameDict["description"];
                points = nameDict["points"];
                entry.Add(new EternalGoal{
                    name = name,
                    type = type,
                    description = description,
                    pointnumber = double.Parse(points),
                    points = points,
                    completedSymbol = completedSymbol
                });
            }
            else if (line.Contains("SimpleGoal"))
        {
            // Dictionary<string, string> name = new Dictionary<string, string>();

            nameDict = JsonSerializer.Deserialize<Dictionary<string,string>>(line);
            name = nameDict["name"];
            type = nameDict["type"];
            description = nameDict["description"];
            points = nameDict["points"];
            entry.Add(new SimpleGoal{
                name = name,
                type = type,
                description = description,
                pointnumber = double.Parse(points),
                points = points,
                completedSymbol = completedSymbol
            });
        }
            else if(line.Contains("NegativeGoal"))
            {
                nameDict = JsonSerializer.Deserialize<Dictionary<string,string>>(line);
                name = nameDict["name"];
                type = nameDict["type"];
                description = nameDict["description"];
                points = nameDict["points"];
                entry.Add(new NegativeGoal{
                    name = name,
                    type = type,
                    description = description,
                    pointnumber = double.Parse(points),
                    points = points,
                    completedSymbol = completedSymbol
                });
            }
            else if (int.TryParse(line, out int result)){
                pointnumber = result;
            }
            else{
                Console.WriteLine("Invalid input");
            }

    }

    public void SaveGoal(){
                Console.Write("What file would you like to save to?(Text file)");

        string filename = Console.ReadLine();
        System.IO.File.AppendAllText(filename, pointnumber + Environment.NewLine);
        while(jsonentries.Count() != 0){
            if (File.Exists(filename)){
                for (int i = jsonentries.Count - 1; i >= 0; i--)
                {
                    System.IO.File.AppendAllText(filename, jsonentries[i] + Environment.NewLine);
                    jsonentries.RemoveAt(i);
                    entry.RemoveAt(i);
            }
            }
            else
            {
                System.IO.File.WriteAllText(filename, jsonentries[jsonentries.Count - 1] + Environment.NewLine);
                jsonentries.Remove(jsonentries[jsonentries.Count - 1]);
                entry.Remove(entry[entry.Count - 1]);
            }
            }  
    }
    public void AddAGoal(Goal goal, string jsonString){
        entry.Add(goal);
        jsonentries.Add(jsonString);
    }
    public string NameGoal(){
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        return name;
    }
    public string DescribeGoal(){
        Console.Write("What is a short description of your goal? ");
        description = Console.ReadLine();
        return description;
    }
    public virtual string PointAmounts(){
        Console.Write("What is the amount of point associated with this goal? ");
        points = Console.ReadLine();
        return points;
    }

    public void RecordGoal(){
        DisplayListedGoals();
        Console.Write("Which goal would you like to record?");
        string goals = Console.ReadLine();
        int goal = int.Parse(goals);
        if (entry[goal - 1].type == "ChecklistGoal"){
            Console.Write("How many times would you like to record?");
            string completed = Console.ReadLine();
            double times = double.Parse(completed);
            entry[goal-1].done += times;
            if (entry[goal -1].done == double.Parse(entry[goal-1].accomplished)){
                entry[goal -1].completedSymbol = "X";
                entry[goal-1].pointnumber += double.Parse(entry[goal-1].bonus);
            }
        }
        else if (entry[goal - 1].type == "EternalGoal" || entry[goal - 1].type == "SimpleGoal"){
            pointnumber += double.Parse(entry[goal-1].points);
            entry[goal -1].completedSymbol = "X";
            // UpdateCompletedSymbolInFile(filename, entry[goal-1].name, "X");
        }
        else if(entry[goal - 1].type == "NegativeGoal"){
            pointnumber -= double.Parse(entry[goal-1].points);
        }
        else{
            Console.WriteLine("Invalid input");
        }

    }
    public virtual void AskQuestions(){
        NameGoal();
        DescribeGoal();
        PointAmounts();
    }

    public virtual string FormatGoalsforFile(){
        return $"[{completedSymbol}] {name} ({description})";
    }

}
