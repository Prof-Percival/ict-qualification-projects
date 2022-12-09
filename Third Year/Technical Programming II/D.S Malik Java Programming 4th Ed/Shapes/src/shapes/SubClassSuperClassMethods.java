package shapes;

/**
*
* @author Christoph
*/
public class SubClassSuperClassMethods {

    public static void main(String[] args)
    {
        //Rectangle Class objects
        Rectangle myRectangle1 = new Rectangle();
        Rectangle myRectangle2 = new Rectangle(8, 6);

        //Box Class objects
        Box myBox1 = new Box();
        Box myBox2 = new Box(10, 7, 3);

        System.out.println("myRectangle1: " + myRectangle1);
        System.out.println("Are of myRectangle1: " + myRectangle1.area());

        System.out.println("myRectangle2: " + myRectangle2);
        System.out.println("Area of myRectangle2: " + myRectangle2.area());

        System.out.println("myBox1: " + myBox1);
        System.out.println("Surface Area of myBox1: " + myBox1.area());
        System.out.println("Volume of myBox1: " + myBox1.volume());

        System.out.println("myBox2: " + myBox2);
        System.out.println("Surface Area of myBox2: " + myBox2.area());		
        System.out.println("Volume of myBox2: " + myBox2.volume());
    }
}