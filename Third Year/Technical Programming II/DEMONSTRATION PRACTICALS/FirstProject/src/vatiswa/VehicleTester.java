package vatiswa;

/**
 *
 * @author Christoph
 */

import java.util.Scanner;

public class VehicleTester {
 
    static Scanner console = new Scanner(System.in); 
    
    public static void main(String[] args)
    {
        //MOTORVEHICLE CLASS
        MotorVehicle motor1 = new MotorVehicle(4, "Brown", 15, "TOYOTA Quantum", "Manual", 4, 180, "Electric Power Steering");
        MotorVehicle motor2 = new MotorVehicle();
        
        motor2.setWheels(4);
        motor2.setColour("Black");
        motor2.setSeats(5);
        motor2.setModel("FORD RANGER");
        motor2.setTransmission("Manual");
        motor2.setDoors(2);
        motor2.setMaxSpeed(220);
        motor2.setSteering("Hydro-Power Steering");
        
        System.out.println("Motor 1 Model: " + motor1.getModel());
        System.out.println("Motor 2 Model: " + motor2.getModel());
        System.out.println(); 
        System.out.println(motor1);
        System.out.println(motor2);
        
        
        
        /*BUS CLASS
        Bus bus1 = new Bus();
        Bus bus2 = new Bus(8, "White", 65, "Marcopolo", "Automatic", 2, 120);
        
        bus1.setWheels(6);
        bus1.setWheels(10);
        bus1.setColour("Orange");
        bus1.setSeats(80);
        bus1.setModel("MAN DFX");
        bus1.setTransmission("Automatic");
        bus1.setDoors(1);
        bus1.setMaxSpeed(160);
        
        bus2.setColour("Blue");
       
        
        System.out.println(bus1); 
        System.out.println(bus2);
        //System.out.println("Bus 2 Model: " + bus2.getModel());
        //bus2.setModel("Mercedes Benz Actros");
        //System.out.println("Bus 2 Model: " + bus2.getModel()); 

        */
        
        
        /*VEHICLE CLASS
        Vehicle veh1 = new Vehicle();
        Vehicle veh2 = new Vehicle();
        Vehicle veh3 = new Vehicle();
        
        
        veh1.setWheels(4);
        veh1.setColour("Blue");
        veh1.setSeats(5);
        veh1.setModel("BMW X5");
        veh1.setTransmission("Automatic");
        
        veh2.setWheels(5);
        veh2.setColour("Red");
        veh2.setSeats(8);
        veh2.setModel("TOYOTA AVANZA");
        veh2.setTransmission("Manual");
        
        
        System.out.print("Input Vehicle 3 Wheels >> ");       
        veh3.setWheels(console.nextInt());

        console.nextLine();

        System.out.print("Input Vehicle 3 Colour >> ");
        String colour = console.nextLine();
        veh3.setColour(colour);
        
        System.out.print("Input Number of Seats >> ");
        int seats = console.nextInt();
        veh3.setSeats(seats);
        
        veh3.setModel("YAMAHA YFZ");
        veh3.setTransmission("Automatic");
        
        System.out.println("Vehicle 1 Wheels: " + veh1.getWheels());
        System.out.println("Vehicle 1 Colour: " + veh1.getColour());
        System.out.println("Vehicle 1 Seats: " + veh1.getSeats());
        System.out.println("Vehicle 1 Model: " + veh1.getModel());
        System.out.println("Vehicle 1 Transmission: " + veh1.getTransmission());
        
        System.out.println(); 
        
        System.out.println("Vehicle 2 Wheels: " + veh2.getWheels());
        System.out.println("Vehicle 2 Colour: " + veh2.getColour());
        System.out.println("Vehicle 2 Seats: " + veh2.getSeats());
        System.out.println("Vehicle 2 Model: " + veh2.getModel());
        System.out.println("Vehicle 2 Transmission: " + veh2.getTransmission());
        
        System.out.println(); 
        
        System.out.println("Vehicle 3 Wheels: " + veh3.getWheels());
        System.out.println("Vehicle 3 Colour: " + veh3.getColour());
        System.out.println("Vehicle 3 Seats: " + veh3.getSeats());
        System.out.println("Vehicle 3 Model: " + veh3.getModel());
        System.out.println("Vehicle 3 Transmission: " + veh3.getTransmission());
        
        */
    }
}