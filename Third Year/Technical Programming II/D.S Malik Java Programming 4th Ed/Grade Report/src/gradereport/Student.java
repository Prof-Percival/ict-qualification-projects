package gradereport;

/**
 *
 * @author Christoph
 */

import java.io.*;

public class Student extends Person {
 
    //Instance Variables
    private int studentId; //Store Student Id
    private int numberOfCourses; //Store number of courses
    private boolean isTuitionPaid; //Indicate if the tuition is paid
    private Course[] coursesEnrolled; //Array to store the courses
    private char[] courseGrades; //Array to store the course grades
    
    
    //Method to set Student Information
    public void setInfo(String fName, String lName, int Id, int noOfCourses, boolean isTPaid, Course[] courses, char[] cGrades)
    {
        setName(fName, lName);
        studentId = Id;
        numberOfCourses = noOfCourses;
        isTuitionPaid = isTPaid;
        
        for (int i = 0; i < numberOfCourses; i++) //Set the Array
        {
            coursesEnrolled[i].copyCourseInfo(courses[i]);
            courseGrades[i] = cGrades[i];
        }
        
        sortCourses(); //Sort the array coursesEnrolled
    }
    
    //toString() Method: Return Student Grade Report
    @Override
    public String toString()
    {
        String gReport;
        
        gReport = super.toString() + "\r\n"
        + "Student ID: " + studentId + "\r\n"
        + "Number of courses enrolled: "
        + numberOfCourses + "\r\n\n"
        + String.format("%-12s%-15s%-8s%-6s%n", "Course No", "Course Name", "Credits", "Grade");
            for (int i = 0; i < numberOfCourses; i++)
            {
                gReport = gReport + coursesEnrolled[i];
                
                if (isTuitionPaid)
                    gReport = gReport + String.format("%8s%n", courseGrades[i]);
                else
                    gReport = gReport + String.format("%8s%n", "***");
            }
            
            gReport = gReport + "\r\nTotal number of credit hours: " + getHoursEnrolled() + "\r\n";
            
        return gReport;
    }
    
                    //Constructors
    //Default Constructor
    public Student()
    {
        super();
        studentId = 0;
        numberOfCourses = 0;
        isTuitionPaid = false;
        
        coursesEnrolled = new Course[6];
        
        for (int i = 0; i < 6; i++)
        {
            coursesEnrolled[i] = new Course();
        }
        
        courseGrades = new char[6];

        for (int i = 0; i < 6; i++)
        {
            courseGrades[i] = '*';
        }
        
    }
    
    //Constructor with Parameters
    
    
                    //Mutator Methods(setters)
    //Method to set Student Id
    public void setStudentId(int studentId)
    {
        this.studentId = studentId;
    }
    
    //Method to set Number of Courses
    public void setNumberOfCourses(int numberOfCourses)
    {
        this.numberOfCourses = numberOfCourses;
    }
    
    //Method to set is Tuition Paid
    public void setIsTuitionPaid(boolean isTuitionPaid)
    {
        this.isTuitionPaid = isTuitionPaid;
    }
    
    //Method to set Courses Enrolled    
    public void setCoursesEnrolled(Course[] courses, char[] cGrades)
    {
        for (int i = 0; i < numberOfCourses; i++) //Set the Array
        {
            coursesEnrolled[i].copyCourseInfo(courses[i]);
            courseGrades[i] = cGrades[i];
        }
        
        sortCourses(); //Sort the array coursesEnrolled
    }
    
    
                    //Accessor Methods(Getters)
    //Method to return Student Id
    public int getStudentId()
    {
        return studentId;
    }
    
    //Method to return Number of Courses
    public int getNumberOfCourses()
    {
        return numberOfCourses;
    }
    
    
    //Method to return Is Tuition Paid
    public boolean getIsTuitionPaid()
    {
        return isTuitionPaid;
    }
    
    //Method to return a Copy of a course takes
    public Course getCourse(int i)
    {
        Course temp = new Course();
        
        temp.copyCourseInfo(coursesEnrolled[i]);
        
        return temp;
    }
    
    //Method to return Course Grade

    public char getGrade(int i)
    {
        
        return courseGrades[i];
    }
    
    
    /*
        The method getHoursEnrolled calculates and returns the total credit hours that a
        student is taking. These credit hours are needed to calculate both the GPA and the
        billing amount. The total credit hours are calculated by adding the credit hours of each
        course in which the student is enrolled. Because the credit hours for a course are in the
        private data member of an object of type Course, we use the method getCredits
        of the class Course to retrieve the credit hours
    */
    //Method to return Total Credit Hourses in which a student is enrolled
    public int getHoursEnrolled()
    {
        int totalCredits = 0;
        
        for (int i = 0; i < numberOfCourses; i++)
        {
            totalCredits += coursesEnrolled[i].getCourseCredits();
        }
            
        return totalCredits;
    }
    
    
    //Method to calculate Bbilling Amount
    public double billingAmount(double tuitionRate)
    {
       return tuitionRate * getHoursEnrolled();
    }
    
    
    //Method to calculate Grade Points Average (GPA)
    public double getGpa()
    {
        double sum = 0.0;
        
        for (int i = 0; i < numberOfCourses; i++)
        {
            switch (courseGrades[i])
            {
                case 'A' -> 
                    sum += coursesEnrolled[i].getCourseCredits() * 4;
                case 'B' -> 
                    sum += coursesEnrolled[i].getCourseCredits() * 3;
                case 'C' -> 
                    sum += coursesEnrolled[i].getCourseCredits() * 2;
                case 'D' -> 
                    sum += coursesEnrolled[i].getCourseCredits() * 1;
                case 'F' -> 
                    sum += coursesEnrolled[i].getCourseCredits() * 0;
                default -> 
                    System.out.println("Invalid Course Grade");
            }
        }
        
        return sum / getHoursEnrolled();
    }
    
    /*
    The method sortCourses sorts the array coursesEnrolled by course number. 
    To sort the array, we use a selection sort algorithm. 
    Because we will compare the course numbers, which are the strings and private data members of the class Course, we first retrieve and store the course numbers in the local variables. 
    Moreover, this method also rearranges the course grades because the course grades are stored in a separate array
    */
    //Method to sort Courses
    private void sortCourses()
    {
        int minIndex;
        Course temp = new Course(); //variable to swap data
        String course1;
        String course2;
        char tempGrade;
        for (int i = 0; i < numberOfCourses - 1; i++)
        {
            minIndex = i;
            
            for (int j = i + 1; j < numberOfCourses; j++)
            {
                course1 = coursesEnrolled[minIndex].getCourseNumber();
                course2 = coursesEnrolled[j].getCourseNumber();

                if (course1.compareTo(course2) > 0)
                    minIndex = j;
            }
            
            temp.copyCourseInfo(coursesEnrolled[minIndex]);
            
            coursesEnrolled[minIndex].copyCourseInfo(coursesEnrolled[i]);
            coursesEnrolled[i].copyCourseInfo(temp);
            
            tempGrade = courseGrades[minIndex];
            
            courseGrades[minIndex] = courseGrades[i];
            courseGrades[i] = tempGrade;
        }
    }
    
}