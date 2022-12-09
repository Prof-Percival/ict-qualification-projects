package tcc_it_repairs;

import java.util.Scanner;

public class TCC_IT_Repairs {
    
    public static void main(String[] args) {
 
        Scanner input = new Scanner(System.in);
        
        short jobType, hours, counter, labourHours_Type2;
        double partsCharge, vat, accVat, labourCharge_Type1, totalPartsCharge, total;
        
        totalPartsCharge = 0.0;
        labourCharge_Type1 = 0.0;
        vat = 0.0;
        accVat = 0.0;
        total = 0.0;
        
        labourHours_Type2 = 0;
        
        counter = 1;
        
        while (counter <= 200){
            
            System.out.print("Input Job Type (1 or 2) >> ");
            jobType = input.nextShort();
            
            if (jobType == 1 || jobType == 2){
                
                System.out.print("Input Number of Hours (Labour) >> ");
                hours = input.nextShort();
                
                if (hours > 0){
                    
                    System.out.print("Input Charge For The Parts Needed >> ");
                    partsCharge = input.nextDouble();
                    
                    if (partsCharge > 0){
                    
                        if (jobType == 1){
                        
                            //Accumulating Labour Charge For Type 1 Jobs
                            labourCharge_Type1 += (200 * hours);
                            
                            //Total Before Vat
                            total = (200 * hours) + partsCharge;
                            
                            //Vat
                            vat = total * 0.15;
                            
                            //Total After Vat
                            total += vat;
                        }
                        
                        if (jobType == 2){
                        
                            //Accumulating Labour Hours For Type 2 Jobs
                            labourHours_Type2 += hours;
                            
                            //Total Before Vat
                            total = (375 * hours) + partsCharge;
                            
                            //Vat
                            vat = total * 0.15;
                            
                            //Total After Vat
                            total += vat;
                        }
                        
                        //Accumulating Total Charge For Parts of All Jobs
                        totalPartsCharge += partsCharge;
                        
                        //Accumulating Vat Amount for All Jobs
                        accVat += vat;
                        
                        //Displaying Total Charge
                        System.out.printf("%nTotal Charge (incl VAT) = R%.2f%n%n", total);
                        
                        //Incrementing The Counter
                        counter += 1;
                        
                    }else
                        System.out.println("\nCharge For The Parts Needed Must Be Greater Than R0\n");
                    
                }else
                    System.out.println("\nLabour Hours Must Be Greater Than 0\n");
            
            }else
                System.out.println("\nJob Type Must Be 1 or 2\n");
        }
        //Displays (Accumulations)
        System.out.printf("Total Labour Charge (Type 1) = R%.2f%n", labourCharge_Type1);
        System.out.printf("Total Labour Hours (Type 2) = %d%n", labourHours_Type2);
        System.out.printf("Total Parts Charge (All Jobs) = R%.2f%n", totalPartsCharge);
        System.out.printf("Total VAT Amount (All Jobs) = R%.2f%n", accVat);
        
    }   
}