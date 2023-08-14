namespace JuletraetMedSinPynt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Amount of layers in the tree
            int Layers = 8;

            for (int i = 0; i < Layers; i++)
            {
                // By subtracting the current layer iteration (i) from the total number of layers, the loop prints one fewer space for the next line to create the tree shape
                for (int j = 0; j < Layers - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Iteration to print * and add the necessary colors, where for every layer, the iteration (k) iterates over a multiplication of the layer iteration (i) with 2, in order to double the layer size instead of linearly incrementing
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    // If the layer iteration (i) doesn't equal 4 (because the center layer should not have red decoration looking at the assignment)
                    // And if the remainder of k modulo 2 equals 1 then change console to red, because it's an odd number (which is what it looks like on the assignment)
                    if (i != 4 && k % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        // Other *'s should be green to appear as a tree
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write("*");
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}