package practical18052022;

/**
 *
 * @author Christoph
 */
public class Rectangle {
 
    //Instance Variables
    private int length;
    private int width;
    
                //Constructors
    //Default Constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }
    
    //Constructor with Parameters
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    //Method to set Length
    public void setLength(int length)
    {
        this.length = length;
    }

    //Method to set Width
    public void setWidth(int width)
    {
        this.width = width;
    }

    //Method to return Length
    public int getLength()
    {
        return length;
    }

    //Method to return Width
    public int getWidth()
    {
        return width;
    }
    
    //Method to calculate Area of Rectangle
    public int areaOfRectangle()
    {
        return length * width;
    }
    
    //toString() Method: Returns Area of Rectangle
    @Override
    public String toString()
    {
        return "Area of Rectangle: " + areaOfRectangle();
    }  
}