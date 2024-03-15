using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        SimpleGoal simpleone = new SimpleGoal();
        ChecklistGoal checklistone = new ChecklistGoal();
        EternalGoal eternalone = new EternalGoal();
        NegativeGoal negativeone = new NegativeGoal();
        Console.WriteLine(simpleone.points);
        // SimpleGoal test = new SimpleGoal("typeValue", "nameValue", 10.0, "descriptionValue");
        // Console.WriteLine(test.FormatGoalsforFile());

        // If simplegoal then type = simpleGoal, name and everything else is user input
        while(true){
            simpleone.DisplayPoints();
            Console.Write("Menu Options:\n  1. Create New Goal \n  2. List Goals \n  3. Save Goals \n  4. Load Goals \n  5. Record Event \n  6. Quit \nSelect a choice from the menu: ");
            string answer = Console.ReadLine();
            int response = int.Parse(answer);
            if(response == 1){
                Console.Write("Menu Options:\n  1. Simple Goal\n  2. Checklist Goal\n  3. Eternal Goal \n  4. Negative Goal \nSelect a choice from the menu: ");
                answer = Console.ReadLine();
                response = int.Parse(answer);
                if(response == 1){
                    SimpleGoal simpleGoal = new SimpleGoal{
                        type = "SimpleGoal",
                        name = simpleone.NameGoal(),
                        description = simpleone.DescribeGoal(),
                        points = simpleone.PointAmounts(),
                        completedSymbol = " ",
                    };
                    // simpleGoal.AskQuestions();
                    string jsonString = JsonSerializer.Serialize(simpleGoal);
                    simpleone.AddAGoal(simpleGoal, jsonString);
                    Console.WriteLine(simpleGoal.FormatGoalsforFile());
                }
                else if(response == 2){
                    ChecklistGoal checklistGoal = new ChecklistGoal{
                        type = "ChecklistGoal",
                        name = checklistone.NameGoal(),
                        description = checklistone.DescribeGoal(),
                        points = checklistone.PointAmounts(),
                        accomplished = checklistone.Accomplished(),
                        bonus = checklistone.Bonus(),
                        completedSymbol = " ",
                    };
                   string jsonString = JsonSerializer.Serialize(checklistGoal);
                    simpleone.AddAGoal(checklistGoal, jsonString);
                    Console.WriteLine(checklistGoal.FormatGoalsforFile());
                    
                }
                else if(response == 3){
                    EternalGoal eternalGoal = new EternalGoal{
                        type = "EternalGoal",
                        name = eternalone.NameGoal(),
                        description = eternalone.DescribeGoal(),
                        points = eternalone.PointAmounts(),
                        completedSymbol = " ",
                    };
                    string jsonString = JsonSerializer.Serialize(eternalGoal);
                    simpleone.AddAGoal(eternalGoal, jsonString);
                    Console.WriteLine(eternalGoal.FormatGoalsforFile());                  
                }
                else if(response == 4){
                    NegativeGoal negativeGoal = new NegativeGoal{
                        type = "NegativeGoal",
                        name = negativeone.NameGoal(),
                        description = negativeone.DescribeGoal(),
                        points = negativeone.PointAmounts(),
                        completedSymbol = " ",
                    };
                    string jsonString = JsonSerializer.Serialize(negativeGoal);
                    simpleone.AddAGoal(negativeGoal, jsonString);
                    Console.WriteLine(negativeGoal.FormatGoalsforFile());
                }
                else{
                    Console.Write("Invalid input. Please try again");
                }
            }
            else if(response == 2){
                simpleone.DisplayListedGoals();
            }
            else if(response == 3){
                simpleone.SaveGoal();           
            }
            else if(response == 4){
                simpleone.LoadGoals();                
            }
            else if(response == 5){
                simpleone.RecordGoal();
            }
            else if(response == 6){
                break;
            }
            else{
                Console.Write("Invalid input. Please try again");
            }
    }
    }
}
