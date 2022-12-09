package viptransport;

/**
 *
 * @author Christoph
 */
public class TestTrip {

    public static void main(String[] args) {
        
        /*
        Trip trip1 = new Trip();
        
        trip1.setCarId("car001");
        trip1.setDestination("Ocean Villas");
        trip1.setDistance(150);
        
        System.out.println("Car Id: " + trip1.getCarId());
        System.out.println("Destination: " + trip1.getDestination());
        System.out.println("Distance: " + trip1.getDistance() + "Km");
        System.out.printf("Total Fare Payable: R%.2f%n", trip1.getTotalFare());
        */
        
        Trip t1 = new Trip("007 BOND", "Cape Town", 250.0);
        
        Trip t2 = new Trip("111 RAJ", "Greenfields", 15.0);
        
        Trip t3 = new Trip("111 JON", "Port Elizabeth", 150.0);
        
        //TestTrip value = new TestTrip();
        
        System.out.println(t1); //Displaying Values of Trip 1
        System.out.println(t2); //Displaying Values of Trip 2
        System.out.println(t3); //Displaying Values of Trip 3
        //System.out.println("t2 is instane of Trip: " + (t2 instanceof Trip));
        //System.out.println("value is instane of Trip: " + (value instanceof TestTrip));
        
    }   
}