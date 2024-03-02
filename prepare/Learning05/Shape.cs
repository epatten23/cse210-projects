using System.Globalization;

public abstract class Shape{
    public string _color;
    public Shape(string color){
        _color = color;
    }
    public string GetColor(){
        return _color;
    }

    public void SetColor(string color){
        this._color = color;
    }

    public abstract double GetArea();
}