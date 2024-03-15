class EternalGoal : Goal{

    public override void AskQuestions(){
        type = "EternalGoal";
        NameGoal();
        DescribeGoal();
        PointAmounts();
    }
}