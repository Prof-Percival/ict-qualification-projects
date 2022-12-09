package twodimarrays;

/**
 *
 * @author Christoph
 */
public class TwoDimArrays {

    public static void main(String[] args) {

        int[][] board ={{23,5,6,15,18},
                        {4,16,24,67,10},
                        {12,54,23,76,11},
                        {1,12,34,22,8},
                        {81,54,32,67,33},
                        {12,34,76,78,9}};
        
        TwoDimArrays.printMatrix(board);
        
        System.out.println();
        
        TwoDimArrays.sumRows(board);
        
        System.out.println();
        
        TwoDimArrays.largestInRows(board);
        
        System.out.println();
        
        TwoDimArrays.largestInColumns(board);
        
        System.out.println();
        
    }
    
    public static void printMatrix(int[][] matrix)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            for (int col = 0; col < matrix[row].length; col++)
            {
                System.out.printf("%7d", matrix[row][col]);
            }
            
            System.out.println();
        }
    }
    
    public static void sumRows(int[][] matrix)
    {
        int sum;
        
        for (int row = 0; row < matrix.length; row++)
        {
            sum = 0;
            
            for (int col = 0; col < matrix[row].length; col++)
            {
                sum += matrix[row][col];
            }
            
            System.out.println("Sum of The Elements of Row " + (row + 1) + " = " + sum);
        }
    }
    
    public static void sumColumns(int[][] matrix)
    {
        int sum;
        
        for (int col = 0; col < matrix[0].length; col++)
        {
            sum = 0;
            
            for (int row = 0; row < matrix.length; row++)
            {
                sum += matrix[row][col];
            }
            
            System.out.println("Sum of The Elements of Column " + (col + 1) + " = " + sum);
        }
    }
    
    public static void largestInRows(int[][] matrix)
    {
        int largest, row = 2;
        largest = matrix[row][0];
        
        for (int col = 1; col < matrix[row].length; col++)
        {
            if (largest < matrix[row][col])
                largest = matrix[row][col];
        }
        
        System.out.println("The Largest Element of Row " + (row + 1) + " = " + largest);
    }
    
    public static void largestInColumns(int[][] matrix)
    {
        int largest, col = 3;
        largest = matrix[0][col];
        
        for (int row = 1; row < matrix.length; row++)
        {
            if (largest < matrix[row][col])
                largest = matrix[row][col];
        }
        
        System.out.println("The Largest Element of Column " + (col + 1) + " = " + largest);
    }
}