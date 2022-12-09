package hasarelationship;

/**
 *
 * @author Christoph
 */
public class Tester {

    public static void main(String[] args) {
     
        Heart h1 = new Heart();
        
        h1.setHeartRate(3.42);
        
        HumanBody body = new HumanBody();
        
        body.setLegs(2);
        body.setColour("White");
        body.setHeight(2.46);
        body.setMass(72.4);
        body.setHeart(h1);
        
        Heart h2 = new Heart(2.87);
        
        HumanBody body2 = new HumanBody(2, "Black", 3.1, 80.5, h2);
        
        System.out.println(body);
        System.out.println();
        System.out.println(body2);
    }   
}