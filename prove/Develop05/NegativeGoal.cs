class NegativeGoal : Goal{
    public override void AskQuestions(){
        type = "NegativeGoal";
        NameGoal();
        DescribeGoal();
        PointAmounts();
    }
}