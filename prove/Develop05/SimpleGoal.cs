class SimpleGoal : Goal{

    public override void AskQuestions(){
        type = "SimpleGoal";
        NameGoal();
        DescribeGoal();
        PointAmounts();
    }
}