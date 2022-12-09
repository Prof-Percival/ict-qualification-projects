package ch3ex16;
import java.util.*;
import java.io.*;

public class Ch3Ex16
{
    
public static void main(String[] args) throws FileNotFoundException
        
{
Scanner inFile = new Scanner(new FileReader("Ex16Input.txt"));
PrintWriter outFile = new PrintWriter("Ex16Output.dat");

int num1, num2;
num1 = inFile.nextInt();
num2 = inFile.nextInt();
outFile.println("Sum = " + (num1 + num2));
    
inFile.close();
outFile.close();
}
}
