class ChecklistGoal : Goal{

    

    public string Accomplished(){
        Console.Write("How many times does this goal need to be accomplished for a bonus?");
        accomplished = Console.ReadLine();
        return accomplished;
    }
    public string Bonus(){
        Console.Write("What is the bonus amount?");
        bonus = Console.ReadLine();
        return bonus;
    }
    public override void AskQuestions(){
        type = "ChecklistGoal";
        NameGoal();
        DescribeGoal();
        PointAmounts();
        Accomplished();
        Bonus();
    }
    public override string FormatGoalsforFile(){
        return $"[{completedSymbol}] {name} ({description})  {done}/{accomplished}";
    }
}