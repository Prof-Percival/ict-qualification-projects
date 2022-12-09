package ch5_example21;

import java.io.FileReader;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Ch5_Example21 {

    public static void main(String[] args) throws FileNotFoundException {
        
        Scanner inFile = new Scanner(new FileReader("Exp_5_21.txt"));
        
        int id, num, votes;
        String name, newlineCharacter;
        
        while (inFile.hasNext()) {
            id = inFile.nextInt();
            newlineCharacter = inFile.nextLine();
            name = inFile.nextLine();
            
            votes = 0;
            
            num = inFile.nextInt();
            while (num != -999){
                votes += num;
                num = inFile.nextInt();
            }
            System.out.printf("ID: %d%nName: %s%nVotes: %d%n%n", id, name, votes);
        }
        inFile.close();
    }   
}