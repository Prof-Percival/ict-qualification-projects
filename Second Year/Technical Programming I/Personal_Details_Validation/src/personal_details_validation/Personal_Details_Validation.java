//Playground Program to Test
package personal_details_validation;

import java.util.Scanner;
import javax.swing.*;

public class Personal_Details_Validation {
    
     static Scanner Percival = new Scanner(System.in);
     
    public static void main(String[] args) {
        
        //Validation for Name Begins 
        String name;
        name = JOptionPane.showInputDialog(null, "Input your Full Name", "Name", JOptionPane.QUESTION_MESSAGE);
        name = name.trim();
        
        //Validating Name is Not Blank
        while (name.equals("")){
            JOptionPane.showMessageDialog(null, "Name Can't Be Blank!", "Name", JOptionPane.ERROR_MESSAGE);
            name = JOptionPane.showInputDialog(null, "Input your Full Name", "Name", JOptionPane.QUESTION_MESSAGE);
            name = name.trim();            
        }
        
        //Validating Name that it contains only Letters (A to Z) and Space
        for (int p = 0; p < 1;){
            if (name.length() - 1 >= 1 ){
                String xp;
                //name = name.replace(' ', '_');
                name = name.toUpperCase();
                for (int x = 0; x <= (name.length() - 1);){
                    xp = name.substring(x, (x + 1));
                    switch (xp){
                        case " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" :
                            x++;
                            break;   
                        default:
                            JOptionPane.showMessageDialog(null, "Name Must Be Alphabetic!", "Name", JOptionPane.ERROR_MESSAGE);
                            name = JOptionPane.showInputDialog(null, "Input your Full Name", "Name", JOptionPane.QUESTION_MESSAGE);
                            name = name.trim().toUpperCase();
                            x = 0;
                            break;
                    }
                }
                p++;
            }else{
            JOptionPane.showMessageDialog(null, "Name Must Contain At Least Two Characters!", "Name", JOptionPane.ERROR_MESSAGE);
            name = JOptionPane.showInputDialog(null, "Input your Full Name", "Name", JOptionPane.QUESTION_MESSAGE); 
            name = name.trim();
            p = 0;
            }   
        }
        //Validation for Name Ends
        
        
        
        //Age Validation that it contains ONLY Positive Integers Begins
        int age;
        String strAge;
        strAge = (JOptionPane.showInputDialog(null, "Input Your Age", "Age", JOptionPane.QUESTION_MESSAGE));
        
        strAge = strAge.trim();
        
        while (strAge.equals("")){
            JOptionPane.showMessageDialog(null, "Age Can't Be Blank!", "Age", JOptionPane.ERROR_MESSAGE);
            strAge = (JOptionPane.showInputDialog(null, "Input Your Age", "Age", JOptionPane.QUESTION_MESSAGE));
            strAge = strAge.trim();
        }
        
        //Checking for other Characters on the Age
        String t;
        for (int pp = 0; pp <= (strAge.length() - 1);){
         t = (strAge.substring(pp, (pp + 1)));
        t = t.trim().toUpperCase();
        switch (t) {
            case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" :
                pp++;
                break;
            case " ":
               JOptionPane.showMessageDialog(null, "Age Must not Contain Spaces!", "Age", JOptionPane.ERROR_MESSAGE);
                strAge = (JOptionPane.showInputDialog(null, "Input Your Age", "Age", JOptionPane.QUESTION_MESSAGE));
                pp = 0;
                break;
            case ".", ",", "-":
               JOptionPane.showMessageDialog(null, "Age Must Be A Positive Integer!", "Age", JOptionPane.ERROR_MESSAGE);
               strAge = (JOptionPane.showInputDialog(null, "Input Your Age", "Age", JOptionPane.QUESTION_MESSAGE));
                pp = 0;
                break;    
            default:
                JOptionPane.showMessageDialog(null, "Age Must Be Numeric!", "Age", JOptionPane.ERROR_MESSAGE);
                strAge = (JOptionPane.showInputDialog(null, "Input Your Age", "Age", JOptionPane.QUESTION_MESSAGE));
                pp = 0;
                break;
        }
        }
        
        //Final Checking if Age is Positive Integer
        int q;
        for (int ppp = 0; ppp <= (strAge.length() - 1);){
         q = (Integer.parseInt(strAge.substring(ppp, (ppp + 1))));
        switch (q) {
            case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9:
                ppp++;
                break;
            default:
                ppp = 0;
                break;
        }
        }
         //Age Validation that it contains ONLY Positive Integers Ends
        
         
         
        //ID Number validation Begins
        String idString;
        idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
        
        idString = idString.trim();
        
        while (idString.equals("")){
            JOptionPane.showMessageDialog(null, "404 ID Number Can't Be blank!", "ID Number", JOptionPane.ERROR_MESSAGE);
            idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
            idString = idString.trim();            
        }
        
        int id, idVerify;
        String idSub;
        for (id = 0; id < 1;){
            if (idString.length() == 13){
                ++id;
            }else if (idString.length() < 13){
                JOptionPane.showMessageDialog(null, "ID Number Must Be 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                idString = idString.trim();
                id = 0;
            }else if (idString.length() > 13){
                JOptionPane.showMessageDialog(null, "ID Number Cannot Be > 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                idString = idString.trim(); 
                id = 0;
            }
        } 
        for (idVerify = 0; idVerify < 13;){
            idSub = idString.substring(idVerify, (idVerify + 1));
            switch (idSub) {
                case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9":
                    ++idVerify;
                    break;
                case " ":
                    JOptionPane.showMessageDialog(null, "ID Number Must Not Contain Any Space in-between!", "ID Number", JOptionPane.ERROR_MESSAGE);
                    idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                    idString = idString.trim();
                    for (id = 0; id < 1;){
                        if (idString.length() == 13){
                            ++id;
                        }else if (idString.length() < 13){
                            JOptionPane.showMessageDialog(null, "ID Number Must Be 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                            idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                            idString = idString.trim();
                            id = 0;
                        }else if (idString.length() > 13){
                            JOptionPane.showMessageDialog(null, "ID Number Cannot Be > 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                            idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                            idString = idString.trim(); 
                            id = 0;
                        }
                    }
                    idVerify = 0;
                    break;
                case "":
                    JOptionPane.showMessageDialog(null, "ID Number Cannot Be Blank!", "ID Number", JOptionPane.ERROR_MESSAGE);
                    idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                    idString = idString.trim();
                    for (id = 0; id < 1;){
                        if (idString.length() == 13){
                            ++id;
                        }else if (idString.length() < 13){
                            JOptionPane.showMessageDialog(null, "ID Number Must Be 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                            idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                            idString = idString.trim();
                            id = 0;
                        }else if (idString.length() > 13){
                            JOptionPane.showMessageDialog(null, "ID Number Cannot Be > 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                            idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                            idString = idString.trim(); 
                            id = 0;
                        }
                    }
                    idVerify = 0;
                    break;
                default:
                    JOptionPane.showMessageDialog(null, "ID Number Must Be Numeric!", "ID Number", JOptionPane.ERROR_MESSAGE);
                    idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                    idString = idString.trim();
                    for (id = 0; id < 1;){
                        if (idString.length() == 13){
                            ++id;
                        }else if (idString.length() < 13){
                            JOptionPane.showMessageDialog(null, "ID Number Must Be 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                            idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                            idString = idString.trim();
                            id = 0;
                        }else if (idString.length() > 13){
                            JOptionPane.showMessageDialog(null, "ID Number Cannot Be > 13 Digits", "ID Number", JOptionPane.ERROR_MESSAGE);
                            idString = JOptionPane.showInputDialog(null, "Input ID Number", "ID Number", JOptionPane.QUESTION_MESSAGE);
                            idString = idString.trim(); 
                            id = 0;
                        }
                    }
                    idVerify = 0;
                    break;
            }
        }
        //ID Number validation Ends
         
         
        //Converting String Age into Integer Age
        age = Integer.parseInt(strAge);
        
        
        //Concatenating Name and Age
        String jop = "Name: " + name + "\nID Number: " + idString +"\nAge: " + age + " Years Old";
        
        //Sending Information To Message Dialog Box
        JOptionPane.showMessageDialog(null, jop, "Personal Details", JOptionPane.INFORMATION_MESSAGE);  
    } 
} // 227