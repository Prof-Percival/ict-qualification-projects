package gradereport;

/**
 *
 * @author Christoph
 */
import java.io.*;

public class Course {
 
    //Instance Variables
    private String courseName;
    private String courseNumber;
    private int courseCredits;
    
    
                    //Constructors
    //Default Constructor
    public Course()
    {
        courseName = "";
        courseNumber = "";
        courseCredits = 0;
    }
    
    //Constructor with Parameters
    public Course(String cName, String cNumber, int credits)
    {
        setCourseInfo(cName, cNumber, credits);
    }
    
    
                    //Mutator Methods(Setters)
    //Method to set Course Name
    public void setCourseName(String cName)
    {
        this.courseName = cName;
    }
    
    //Method to set Course Number
    public void setCourseNumber(String cNumber)
    {
        this.courseNumber = cNumber;
    }
    
    //Method to set Course Credits
    public void setCourseCredits(int credits)
    {
        this.courseCredits = credits;
    }
    
    
                    //Accessor Methods
    //Method to return Course Name
    public String getCourseName()
    {
        return courseName;
    }
    
    //Method to return Course Number
    public String getCourseNumber()
    {
        return courseNumber;
    }
    
    //Method to return Course Credits
    public int getCourseCredits()
    {
        return courseCredits;
    }
    
    
                    //Other Methods
    //Method to set Course Information
    public final void setCourseInfo(String cName, String cNumber, int credits)
    {
        this.courseName = cName;
        this.courseNumber = cNumber;
        this.courseCredits = credits;
    }
    
    //toString() Method: Return course information as a String
    @Override
    public String toString()
    {
        //return "Course Name: " + courseName + "\nCourse Number: " + courseNumber + "\nCourse Credits: " + courseCredits + "\n";
        return String.format("%-12s%-15s%4s", courseNumber, courseName, courseCredits);
    }
    
    //Method to copy a course's information from another object
    public void copyCourseInfo(Course otherCourse)
    {
        this.courseName = otherCourse.courseName;
        this.courseNumber = otherCourse.courseNumber;
        this.courseCredits = otherCourse.courseCredits;
    }
}