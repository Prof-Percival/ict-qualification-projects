package practical18052022;

/**
 *
 * @author Christoph
 */

public class Triangle extends Rectangle {
    
    //Default Constructor
    public Triangle()
    {
       super();
    }
    
    //Constructor with Parameters
    public Triangle(int length, int width)
    {
        super(length, width);
    }

    //Method to calculate area of Triangle
    public int areaOfTriangle() {
        return (super.getLength() * super.getWidth()) / 2;
    }
    
    //toString() Method: Returns Area of Triangle
    @Override
    public String toString()
    {
        return "Area of Triangle: " + areaOfTriangle();
    }
}