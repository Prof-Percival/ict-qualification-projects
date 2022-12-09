package timepackage;

public class TestProgClock {
	
    public static void main(String[] args) {

        Clock myClock = new Clock(5, 21, 7);
        
        TestProgClock myClockRef = new TestProgClock();

        myClock.printTime();
        
        System.out.println("\n" + myClock);

    }

}