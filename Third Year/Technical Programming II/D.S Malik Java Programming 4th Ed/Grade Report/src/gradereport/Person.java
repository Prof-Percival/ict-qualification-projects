package gradereport;

/**
 *
 * @author Christoph
 */
public class Person {
    
    //Instance Variables
    private String firstName;
    private String lastName;

                    //Constructors
    //Default Constructor
    public Person()
    {
        firstName = "";
        lastName = "";
    }
    
    //Constructor with Parameters
    public Person(String name, String surname)
    {
        this.firstName = name;
        this.lastName = surname;
    }
    
    
                    //Mutator Methods(Setters)
    //Method to set First Name
    public void setFirstName(String name)
    {
        this.firstName = name;
    }
    
    //Method to set Last Name
    public void setLastName(String surname)
    {
        this.lastName = surname;
    }
    
    //Method to set Name
    public void setName(String fName, String lName)
    {
        this.firstName = fName;
        this.lastName = lName;
    }
    
    
                    //Accessor Methods
    //Method to return First Name
    public String getFirstName()
    {
        return firstName;
    }
    
    //Method to return Last Name
    public String getLastName()
    {
        return lastName;
    }
    
    //toString() Method: Return Student Information
    @Override
    public String toString()
    {
        return String.format("Student Name: %s %s", firstName, lastName);
    }
    
    
}