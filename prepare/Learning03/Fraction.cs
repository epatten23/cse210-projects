public class Fraction {
    private int _top;
    private int _bottom;


    private void SetTop(int set){
        this._top = set;
    }


    private void GetTop(){
        SetTop(_top);
    }

    private void GetBottom(){
        setBottom(_bottom);
    }
    private void setBottom(int set){
        this._bottom = set;
    }
    public Fraction(){
        this._top = 1;
        this._bottom = 1;
    }

    public Fraction(int wholeNumber){
        this._top = wholeNumber;
        this._bottom = 1;
    }

    public Fraction(int top, int bottom){
        this._top = top;
        this._bottom = bottom;
    }


    public void GetDecimalValue(){
        Console.WriteLine((double)_top/(double)_bottom);
    }

    public void GetFractionString(){
        Console.WriteLine($"{this._top}/{this._bottom}");
    }
}