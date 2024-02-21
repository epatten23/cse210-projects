public class MathAssignment : Assignment{
    public string _textbookSection;
    public string _problems;

    public string GetHomeWorkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
}