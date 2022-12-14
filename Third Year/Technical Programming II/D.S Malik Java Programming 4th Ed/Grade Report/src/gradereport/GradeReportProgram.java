package gradereport;

/**
 *
 * @author Christoph
 */

import java.io.*;
import java.util.Scanner;

public class GradeReportProgram {
    
    public static void main(String[] args) throws FileNotFoundException
    {
        int noOfStudents;
        double tuitionRate;
        
        System.out.println("Program Running...");
        
        Scanner inFile = new Scanner(new FileReader("stData.txt"));
        
        PrintWriter outFile = new PrintWriter("sDataOut.out");
        
        noOfStudents = inFile.nextInt(); //get the number of students
        tuitionRate = inFile.nextDouble(); //get the tuition rate
        
        Student[] studentList = new Student[noOfStudents];
        
        for (int i = 0; i < studentList.length; i++)
        {
            studentList[i] = new Student();
        }
        
        getStudentData(inFile, studentList);
        
        printGradeReports(outFile, studentList, tuitionRate);
        
        System.out.println("\nProgram Finished...\n");
        
        inFile.close();
        outFile.close();
    }
    
    
    //Method to get Student Data
    public static void getStudentData(Scanner inpFile, Student[] sList)
    {
        //Local variables
        String fName; //variable to store the first name
        String lName; //variable to store the last name
        int ID; //variable to store the student ID
        int noOfCourses; //variable to store the number of courses
        char isPaid; //variable to store Y/N; that is, is the tuition paid?
        boolean isTuitionPaid; //variable to store true/false
        String cName; //variable to store the course name
        String cNo; //variable to store the course number
        int credits; //variable to store the course credit hours
        char grade; //variable to store the course grade
        Course[] courses = new Course[6]; //array of objects to store the course information
        char[] courseGrades = new char[6];
        
        for (int i = 0; i < 6; i++)
        {
            courses[i] = new Course();
        }
        
        for (int count = 0; count < sList.length; count++)
        {
            fName = inpFile.next();
            lName = inpFile.next();
            ID = inpFile.nextInt();
            isPaid = inpFile.next().charAt(0);

            /*
            if (isPaid == 'Y')
                isTuitionPaid = true;
            else
                isTuitionPaid = false;
            */ 
            //OR
            
            isTuitionPaid = (isPaid == 'Y');
            
            noOfCourses = inpFile.nextInt();

            for (int i = 0; i < noOfCourses; i++)
            {
                cName = inpFile.next();
                cNo = inpFile.next();
                credits = inpFile.nextInt();
                courseGrades[i] = inpFile.next().charAt(0);

                courses[i].setCourseInfo(cName, cNo, credits);
            }

            sList[count].setInfo(fName, lName, ID, noOfCourses, isTuitionPaid, courses, courseGrades);
        }
    }
    
    
    //Method to Print The Grade Reports
    public static void printGradeReports(PrintWriter outpFile, Student[] sList, double tuitionRate)
    {
        for (int count = 0; count < sList.length; count++)
        {
            outpFile.print(sList[count]);
            
            if (sList[count].getIsTuitionPaid())
                outpFile.printf("Midsemester GPA: %.2f%n", sList[count].getGpa());
            else
            {
                outpFile.println("*** Grades are being held for not paying the tuition. ***");
            
                outpFile.printf("Amount Due: $%.2f%n", sList[count].billingAmount(tuitionRate));
            }
            
            outpFile.println("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\r\n");
        }
    }
    
}