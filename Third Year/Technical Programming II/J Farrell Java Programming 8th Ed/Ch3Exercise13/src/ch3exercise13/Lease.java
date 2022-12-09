package ch3exercise13;

/**
 *
 * @author Christoph
 */
public class Lease {
 
    //Data fields
    private String tenantName;
    private int apartmentNumber;
    private double rentAmount;
    private int termOfTheLease;
    
    
                    //Constructors
    //Default constructor
    public Lease()
    {
        this.tenantName = "XXX";
        this.apartmentNumber = 0;
        this.rentAmount = 1000.0;
        this.termOfTheLease = 12;
    }
    
    //Constructor with Parameters
    public Lease(String name, int aptNo, double rent, int lease)
    {
        this.tenantName = name;
        this.apartmentNumber = aptNo;
        this.rentAmount = rent;
        this.termOfTheLease = lease;
    }
    
                    //Mutator Methods (Setters)
    //Method to Set Tenant Name
    public void setTenantName(String name)
    {
        this.tenantName = name;
    }
    
    //Method to Set Apartment Number
    public void setApartmentNumber(int aptNo)
    {
        this.apartmentNumber = aptNo;
    }
    
    //Method to Set Rent Amount
    public void setRentAmount(double rent)
    {
        this.rentAmount = rent;
    }
    
    //Method to Set Term of The Lease
    public void setTermOfTheLease(int lease)
    {
        this.termOfTheLease = lease;
    }
    
                    //Accessor Methods (Getters)
    //Method to return Tenant Name
    public String getTenantName()
    {
        return tenantName;
    }
    
    //Method to return Apartment Number
    public int getApartmentNumber()
    {
        return apartmentNumber;
    }
    
    //Method to return Rent Amount
    public double getRentAmount()
    {
        return rentAmount;
    }
    
    //Method to return Term of The Lease
    public int getTermOfTheLease()
    {
        return termOfTheLease;
    }
    
    //Method to Add Pet Fee of $10
    public void addPetFee()
    {
        rentAmount += 10;
        Lease.explainPetPolicy(rentAmount);
    }
    
    //Method to Explain Pet Policy
    public static void explainPetPolicy(double rent)
    {
        System.out.println("When a Tenant has a Pet, we add a Pet Fee to your Monthly Rent Amount.\nYour Initial Rent = $" + (rent - 10) + "\nPet Fee = $10\nNew Monthly Rent Amount = $" + rent + "\n");
    }
}