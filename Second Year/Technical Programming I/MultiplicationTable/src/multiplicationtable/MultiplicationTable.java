package multiplicationtable;

public class MultiplicationTable {
    
    public static void main(String[] args) {
        int t = 0;
        for (int p = 1; p <= 5; p++){  //For Rows
            
            for (int c = 1; c <= 10; c++) //For Columns
                System.out.printf("%-4d| ", p * c);
            System.out.println();
        }
    }   
}