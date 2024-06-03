namespace L14_Assignment_CSI120
{
    internal class Program
    {
        // Kady Tran
        // 06/02/2024
        // Lecture 14 Assignment

        static void Main(string[] args)
        {
            // Call Method 1: Display numbers in rows
            Console.WriteLine("Method 1");
            Console.WriteLine("Displaying numbers in rows:");
            DisplayNumbersInRows();

            // Call Method 2: Generate a 2D array with random integers
            Console.WriteLine("Method 2");
            int[,] array = Generate2DArray(4, 3);
            Console.WriteLine("Generated 2D Array:");
            Print2DArray(array);

            // Call Method 3: Print the 2D array
            Console.WriteLine("Method 3");
            Console.WriteLine("Printed 2D Array: ");
            Print2DArray(array);

            // Call Method 4: Print the diagonal of the 2D array
            Console.WriteLine("Method 4");
            Console.WriteLine("Diagonal of the Array:");
            PrintDiagonal(array);

        } // End of main


        // Method 1: Display numbers in rows
        // Create a method that uses nested for loops to display numbers 1 through 10 across five rows. Each number should be separated by a space.
        public static void DisplayNumbersInRows()
        {
            // 1
            for (int i = 0; i < 5; i++)
            {
                // 2
                for (int j = 1; j <= 10; j++)
                {
                    // 3
                    Console.Write(j + " ");
                } // End of for loop

                // 4
                Console.WriteLine();
            } // End of for loop

            // I'll set the number in comments to show where to look
            // I am using the outer and inner loop to control the number of rows at 1 and 2. I've also changed the original "i" into j since we can't have the same two "i"'s if that makes sense. At 3, I'm using ConsoleWrite instead of ConsoleWriteLine since this will be more readable and prints out each number with a space in between and I've also added a consolewriteline at 4 to move to the next line after each row.
        }



        // Method 2: Generate a 2D array with random integers
        // Create a method that generates a 2D array of integers. The method should take two parameters: the size of the first dimension (rows) and the size of the second dimension (columns). The values in the array should be randomly generated integers.
        public static int[,] Generate2DArray(int rows, int columns)
        {
            // I created the Random object to generate random numbers
            Random rand = new Random();
            // 2
            int[,] array = new int[rows, columns];

            // outer loop
            for (int x = 0; x < rows; x++)
            {
                // inner loop
                for (int y = 0; y < columns; y++)
                {
                    // 5
                    array[x, y] = rand.Next(1, 10);
                } // End of for loop

            } // End of for loop

            // 6
            return array;

            // In this method I've set the two parameters of the rows and column. I thought using the x for the outer loop and y for the inner loop would be better, it just made sense in my head regarding rows and columns. I started off the method with creating the random object then at 2 (I labeled btw :D) I declared a 2D array with the specified number of rows and columns. And then 3, for the outer loop it is pretty much the same as above, just changed the i to x and then for inner loop, at 5, I assigned a random int between 1 and 9 (short to keep it simple) to each element in the array. Then at 6, since i made this method without a void, i made it return back with the 2D array 

            // sorry for too much details, i didn't know how much detail you wanted the explanation to be 
        } // End of method



        // Method 3: Print the 2D array
        // Create a method that takes a 2D integer array as a parameter and prints all the values. Each subsequent array should be printed on a new row.
        public static void Print2DArray(int[,] array)
        {
            // 1
            int rows = array.GetLength(0);
            // 2
            int columns = array.GetLength(1);

            // Outer loop
            for (int x = 0; x < rows; x++)
            {
                // Inner loop
                for (int y = 0; y < columns; y++)
                {
                    // 3
                    Console.Write(array[x, y] + " ");
                } // End of for loop

                // 4
                Console.WriteLine();
            } // End of for loop

            // I've set the 2D integer array as a parameter then I got the numbers for both rows and columns in the array at line 1 and 2. Then for outer and inner loop, i did the same as method 2, since columns and rows reminds me of x and y that's what I changed the i's too. I wanted the elements printed out more cleaner so I added a space in the cw at line 3 and then added another cw to move to the next line at line 4.

        } // End of Print2D Array


        // Method 4: Print the diagonal of the 2D array
        // Create a method that takes a 2D integer array as a parameter and prints the diagonal elements of the array. This method should only use a single for loop.
        public static void PrintDiagonal(int[,] array)
        {
            // got the number of rows in the array
            int rows = array.GetLength(0);
            // got the number of columns in the array
            int columns = array.GetLength(1);
            // 3
            int size = Math.Min(rows, columns);

            // one for loop
            for (int i = 0; i < size; i++)
            {
                // printing each element out
                Console.WriteLine(array[i, i]);
            } // End of for

            // I set the 2D integer array as a parameter again and I basically did the same thing as above with getting the numbers for each int and then setting a new int variable named size to determine the size of the diagonal, which is the minimum of the number of rows and columns at Line 3. Then I am using a single for loop to iterate over the diagonal elements which will then print each diagonal element out.

        } // End of printdiagonal

    } // End of Class
} // End of Namespace
