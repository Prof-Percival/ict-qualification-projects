package fibonaccinumber;

import java.util.Scanner;

public class FibonacciNumber {

    public static void main(String[] args) {
        
        Scanner inFile = new Scanner(System.in);
        
        int previous1, previous2, current = 0, nthFibonacci, p;
        
        String sequence = "", term;

        System.out.print("Input The First Fibonacci Number: ");
        previous1 = inFile.nextInt();
        
        System.out.println();
        
        System.out.print("Input The Second Fibonacci number: ");
        previous2 = inFile.nextInt();
        
        System.out.println();
        
        System.out.print("Input The Position Of The Desired Number In The Fibonacci Sequence: ");
        nthFibonacci = inFile.nextInt();
        
        System.out.println();
        
        if (nthFibonacci >= 1){
            
            //Determining The Term of A Number (st, nd, rd, th)
            term = Integer.toString(nthFibonacci);
            if (term.endsWith("1") && !term.endsWith("11"))
                term = "st";
            else if (term.endsWith("2") && !term.endsWith("12"))
                term = "nd";
            else if (term.endsWith("3") && !term.endsWith("13"))
                term = "rd";
            else
                term = "th";
            
            //Determining Number on a Given Position From The Sequence & The Sequence As Well
            /* Using if... else Statements
            if (nthFibonacci == 1){
                sequence = previous1 + ", ...";
                current = previous1;
            } else if (nthFibonacci == 2){
                sequence = previous1 + ", " + previous2 + ", ...";
                current = previous2;
            } else {
                p = 3;
                sequence = previous1 + ", " + previous2;
                while (p <= nthFibonacci){
                    current = previous1 + previous2;
                    previous1 = previous2;
                    previous2 = current;
                    sequence +=", " + current;                    
                    p += 1;
                }
                sequence += ", ...";
            }
            */
            
            //Using switch statement
            switch (nthFibonacci){
                case 1 -> {
                    sequence = previous1 + ", ...";
                    current = previous1;
                }
                case 2 -> {
                    sequence = previous1 + ", " + previous2 + ", ...";
                    current = previous2;
                }
                default -> {
                    p = 3;
                    sequence = previous1 + ", " + previous2;
                    while (p <= nthFibonacci){
                        current = previous1 + previous2;
                        previous1 = previous2;
                        previous2 = current;
                        sequence +=", " + current;
                        p += 1;
                    }
                    sequence += ", ...";
                }
            }
            System.out.println("\t\t\t***** Fibonacci Sequence *****\n");
            System.out.println("Sequence: " + sequence);
            System.out.printf("%nThe %d%s Fibonacci Number Of The Sequence Is: %d%n%n", nthFibonacci, term, current);
            
        }else{
            System.out.println("\t\t\t***** Fibonacci Sequence *****\n");
            System.out.println("Position Of Number In The Fibonacci Sequence Must Be Greater Than 0\n");
        }
        System.out.println("\t\t\t***** Fibonacci Sequence *****\n");
    }
}