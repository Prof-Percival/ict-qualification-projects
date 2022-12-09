package c8ex15;

/**
 *
 * @author Christoph
 */
public class Secret {
 
    //Instance Variables
    private String name;
    private int age;
    private int weight;
    private double height;
    
    
                    //Constructors
    //Default Constructor
    public Secret()
    {
        name = "";
        age = 0;
        weight = 0;
        height = 0.0;
    }
    
    //Constructor with Parameters
    public Secret(String name, int age, int weight, double height)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
        this.height = height;
    }
    
    
                    //Accessor Methods
    //Method to set name
    public void setName(String name)
    {
        this.name = name;
    }
    
    //Method to set age
    public void setAge(int age)
    {
        this.age = age;
    }
    
    //Method to set weight
    public void setWeight(int weight)
    {
        this.weight = weight;
    }
    
    //Method to set height
    public void setHeight(double height)
    {
        this.height = height;
    }
    
    
                    //Mutator Methods
    //Method to return name
    public String getName()
    {
        return name;
    }
    
    //Method to return age
    public int getAge()
    {
        return age;
    }
    
    //Method to return weight
    public int getWeight()
    {
        return weight;
    }
    
    //Method to return height
    public double getHeight()
    {
        return height;
    }
    
    
    //Method to print data stored with appropriate titles
    public void print()
    {
        System.out.println("Name: " + getName());
        System.out.println("Age: " + getAge());
        System.out.println("Weight: " + getWeight());
        System.out.println("Height: " + getHeight());
    }
    
}