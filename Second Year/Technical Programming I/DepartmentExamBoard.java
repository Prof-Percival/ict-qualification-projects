package departmentexamboard;

import java.util.Scanner;
import java.io.FileReader;
import java.io.FileNotFoundException;

public class DepartmentExamBoard {

    public static void main(String[] args) throws FileNotFoundException {
       
        Scanner input = new Scanner(new FileReader("StudentMarks.txt"));
        
        String studentNo = "";
        short test1 = 0, test2 = 0, test3 = 0, test4 = 0, studentsPassed = 0, studentsFailed = 0, no_Of_Students = 0;
        double finalMark = 0.0, passRate, failRate, classAverage = 0.0;
        
        while (input.hasNext()){
            
            no_Of_Students += 1;
            
            studentNo = input.next();
            test1 = input.nextShort();
            test2 = input.nextShort();
            test3 = input.nextShort();
            test4 = input.nextShort();
            
            finalMark = (test1 * 0.15) + (test2 * 0.15) + (test3 * 0.2) + (test4 * 0.5);
            
            if (finalMark >= 50)
                studentsPassed += 1;
            else
                studentsFailed += 1;
            
            classAverage += finalMark;
        }
        
        passRate = (studentsPassed / (double)no_Of_Students) * 100;
        failRate = (studentsFailed / (double)no_Of_Students) * 100;
        
        classAverage /= no_Of_Students;
        
        System.out.println(studentsPassed + " Students Passed The Subject");
        System.out.println(studentsFailed + " Students Failed The Subject");
        System.out.printf("Pass Rate = %.2f%%%n", passRate);
        System.out.printf("Fail Rate = %.2f%%%n%n", failRate);
        System.out.printf("Overall Class Average = %.2f%%%n", classAverage);
        
        input.close();
    }   
}