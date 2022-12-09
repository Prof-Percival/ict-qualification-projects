package ch3exercise12;

/**
 *
 * @author Christoph
 */
public class Student {
 
    //Data fields
    private String idNumber;
    private int creditHours;
    private int points;
    private double gradePointAverage;
    
                    //Constructors
    //Default Constructor
    public Student()
    {
        idNumber = "9999";
        creditHours = 3;
        points = 12;
        gradePointAverage = 4.0;
    }
    
    //Constructor with parameters
    public Student(String id, int ch, int points)
    {
        this.idNumber = id;
        this.creditHours = ch;
        this.points = points;
        this.gradePointAverage = 4.0;
    }
    
    
                    //Mutator Methods
    //Method to set ID number
    public void setIdNumber(String id)
    {
        this.idNumber = id;
    }
    
    //Method to set Credit Hours
    public void setCreditHours(int hrs)
    {
        this.creditHours = hrs;
    }
    
    //Method to set Points earned
    public void setPoints(int points)
    {
        this.points = points;
    }
    
    
    //Method to compute the Grave Point Average
    public double computeGPA()
    {
       this.gradePointAverage = (double) points / creditHours;
       
       return gradePointAverage;
    }
    
    
                    //Dislay Methods
    //Method to display ID Number
    public void displayIdNumber()
    {
        System.out.println("ID Number: " + idNumber);
    }
    
    //Method to display Credit Hours Earned
    public void displayCreditHours()
    {
        System.out.println("Credit Hours Earned = " + creditHours);
    }
    
    //Method to display Number of Points Earned
    public void displayPoints()
    {
        System.out.println("Number of Points Earned = " + points);
    }
    
    //Method to display Grade Point Average
    public void displayGPA()
    {
        System.out.println("Grade Point Average = " + gradePointAverage);
    }
    
    //Overriding toString() method
    @Override
    public String toString()
    {
        return "ID Number: " + idNumber + "\nCredit Hours Earned = " + creditHours + "\nNumber of Points Earned = " + points + "\nGrade Point Average = " + gradePointAverage;
    }
}