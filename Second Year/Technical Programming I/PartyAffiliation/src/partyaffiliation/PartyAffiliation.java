package partyaffiliation;

import java.util.Scanner;

public class PartyAffiliation {

    public static void main(String[] args) {
        
       Scanner inFile = new Scanner(System.in);
       
       System.out.print("Input Party Affiliation Code >> ");
       char affiliationCode = inFile.next().charAt(0);
       
       System.out.println();
       if (affiliationCode == 'D')
           System.out.println("Democrat");
       else if (affiliationCode == 'R')
           System.out.println("Republican");
       else
           System.out.println("Independent");
    }   
}