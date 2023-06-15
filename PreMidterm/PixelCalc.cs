using System;

public static class PixelCalc
{
    public static void StartApplication()
    {
        while (true)
        {
            Console.WriteLine("1. Enter Screen dimensions");
            Console.WriteLine("2. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter Screen width (in pixels):");
                int width = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Screen height (in pixels):");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Diagonal size (in inches):");
                double diagonal = double.Parse(Console.ReadLine());

                // Calculate PPI, Diagonal (in pixels), and Dot pitch
                double ppi = CalculatePPI(width, height, diagonal);
                int diagonalPixels = CalculateDiagonalPixels(width, height);
                double dotPitch = CalculateDotPitch(ppi);

                Console.WriteLine("PPI: " + ppi);
                Console.WriteLine("Diagonal (in pixels): " + diagonalPixels);
                Console.WriteLine("Dot pitch: " + dotPitch);
            }
            else if (choice == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }

    public static double CalculatePPI(int width, int height, double diagonal)
    {

        return Math.Sqrt(width * width + height * height) / diagonal;
    }

    public static int CalculateDiagonalPixels(int width, int height)
    {
        return (int)Math.Sqrt(width * width + height * height);
    }

    public static double CalculateDotPitch(double ppi)
    {
        return 1 / ppi;
    }
}
