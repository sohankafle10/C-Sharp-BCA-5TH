using System;

class MatrixProduct
{
    static void Main()
    {
        Console.WriteLine("Enter the dimensions of the first matrix (rows and columns):");
        int rows1 = int.Parse(Console.ReadLine());
        int cols1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the dimensions of the second matrix (rows and columns):");
        int rows2 = int.Parse(Console.ReadLine());
        int cols2 = int.Parse(Console.ReadLine());

        if (cols1 != rows2)
        {
            Console.WriteLine("Matrix multiplication is not possible. Number of columns in the first matrix must equal the number of rows in the second matrix.");
            return;
        }

        int[,] matrix1 = new int[rows1, cols1];
        int[,] matrix2 = new int[rows2, cols2];
        int[,] product = new int[rows1, cols2];

        Console.WriteLine("Enter elements of the first matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of the second matrix:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Matrix multiplication
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                product[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    product[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Product of the matrices:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(product[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}