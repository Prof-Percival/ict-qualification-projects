package studentpopulation;

public class StudentPopulation {

    public static void main(String[] args) {
        final double ibika_perc = (1.01 / 100);
        final double mthatha_perc = (0.15 / 100);
        int years = 0;
        double ibika_pop, mthatha_pop;
        ibika_pop = 3000;
        mthatha_pop = 14000;
        
        boolean exceeds = false;
        
        while (!exceeds){
        
            years += 1;
            
            System.out.printf("Ibika Campus Student Population: %.2f%n", ibika_pop);
            System.out.printf("Mthatha Campus Student Population: %.2f%n%n", mthatha_pop);
            
            ibika_pop += (ibika_pop * ibika_perc);
            mthatha_pop -= (mthatha_pop * mthatha_perc);
            
            if (ibika_pop > mthatha_pop)
                exceeds = true;
        
        }
        System.out.println("It Took " + years + " Years For Ibika Campus Student Population To Exceed That of Mthatha Campus");
    }   
}