package shapes;

/**
 *
 * @author Christoph
 */
public class Rectangle {
	
	//Instance Variables
	private double length;
	private double width;
	
					//Constructors
	//Default Constructor
	public Rectangle()
	{
		length = 0.0;
		width = 0.0;
	}
	
	//Constructor with Parameters
	public Rectangle(double length, double width)
	{
		setDimensions(length, width);
	}
	
	
					//Methods
	//Method to Set Dimensions
	public void setDimensions(double length, double width)
	{
		//Setting length
		if (length >= 0)
			this.length = length;
		else
			this.length = 0;
		
		//Setting width
		if (width >= 0)
			this.width = width;
		else
			this.width = 0;
	}
	
	//Method to Return Length
	public double getLength()
	{
		return length;
	}
	
	//Method to Return Width
	public double getWidth()
	{
		return width;
	}
	
	//Method to Calculate & Return Area
	public double area()
	{
		return (length * width);
	}
    
	//Method to Calculate & Return Perimeter
	public double perimeter()
	{
		return (2 * (length + width));
	}
	
	//Overriding toString method
	public String toString()
	{
		return ("Length = " + length + "; Width = " + width);
	}
}