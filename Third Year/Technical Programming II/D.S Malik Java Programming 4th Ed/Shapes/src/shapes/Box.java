package shapes;

/**
*
* @author Christoph
*/
public class Box extends Rectangle {

	//Instance Variable
	private double height;
	
					//Constructors
	//Default Constructor
	public Box()
	{
		super(); //Calling Default Constructor of Rectangle class
		height = 0.0;
	}
	
	//Constructor with Parameters
	public Box(double length, double width, double height)	
	{
		super(length, width); //Calling Constructor of Rectangle class
		
		this.height = (height >= 0) ? height : 0; //Using Ternary Operator		
	}
	
	
					//Methods
	//Method to Set Dimensions
	public void setDimensions(double length, double width, double height)
	{
		super.setDimensions(length, width);
		//Another option to initialize private data members from Rectangle
		//setDimensions(length, width);
		
		this.height = (height >= 0) ? height : 0;
	}
	
	//Method to Return Height
	public double getHeight()
	{
		return height;
	}
	
	//Method to Calculate & Return Area of Box
	public double area()
	{
		return (2 * (super.getLength() * super.getWidth() + super.getLength() * height + super.getWidth() * height));
		//Another Option below:
		//return (2 * (getLength() * getWidth() + getLength() * height + getWidth() * height));
	}
	
	//Method to Calculate & Return Volume of Box
	public double volume()
	{
		//Multiply length, width, and height of box OR multiple area of base of box by its height
		return (super.area() * height);
		
		//Another option below:
		//return (getLength() * getWidth() * height);
	}
	
	//Overriding toString method of Box class
	public String toString()
	{
		return (super.toString() + "; Height = " + height);
	}
}