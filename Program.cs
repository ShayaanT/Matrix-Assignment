using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TheMatrix
{
    class Program
    {

        static void generatematrix()
        {
            Console.Write("Enter the number of Rows for your Matrix: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of collumns for your Matrix: ");
                int collumns = Convert.ToInt32(Console.ReadLine());

                
                int[,] randommatrix = new int[rows, collumns]; 
                for (int x = 0; x < rows; x++)
                {

                    for (int y = 0; y < collumns; y++)
                    {
                        Random rnd = new Random();
                        
                        randommatrix[x, y] = rnd.Next(0,9);
                        Console.Write(randommatrix[x, y] + "  ");
                        
                    }
                    Console.WriteLine();
                }
        } 

        static void generatetranspose()
        {

            Console.Write("Enter the number of Rows for your Matrix: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of collumns for your Matrix: ");
                int collumns = Convert.ToInt32(Console.ReadLine());

                
                int[,] randommatrix = new int[rows, collumns]; 
                for (int x = 0; x < rows; x++)
                {

                    for (int y = 0; y < collumns; y++)
                    {
                        Random rnd = new Random();
                        
                        randommatrix[x, y] = rnd.Next(0,9);
                        Console.Write(randommatrix[x, y] + "  ");
                        
                    }
                    Console.WriteLine();
                }

            Console.WriteLine("The transpose is: ");
                for (int y = 0; y < rows; y++)///flip x and y values to output the rows as columns
                {
                    for (int x = 0; x < collumns; x++)
                    {
                        Console.Write(randommatrix[x, y] + "  ");
                    }
                    Console.WriteLine();
                } 
        }

        static void multiplymatrixbyconstant()
        {
            Console.Write("Enter the number of Rows for your Matrix: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of collumns for your Matrix: ");
                int collumns = Convert.ToInt32(Console.ReadLine());

                
                int[,] randommatrix = new int[rows, collumns]; 
                for (int x = 0; x < rows; x++)
                {

                    for (int y = 0; y < collumns; y++)
                    {
                        Random rnd = new Random();
                        
                        randommatrix[x, y] = rnd.Next(0,9);
                        Console.Write(randommatrix[x, y] + "  ");
                        
                    }
                    Console.WriteLine();
                }

            Console.WriteLine("Enter constant multiplier value");
                double constant = Convert.ToDouble(Console.ReadLine());

                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < collumns; y++)
                    {
                        
                        Console.Write(constant + "*" + randommatrix[x, y] + "  ");
                    }
                    Console.WriteLine();
                } 
                Console.ReadLine();

                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < collumns; y++)
                    {
                        
                        Console.Write(constant * randommatrix[x, y] + "  ");
                    }
                    Console.WriteLine();
                } 
        }

        static void multiplymatrix()
        {
            Console.Write("Please indicate the number of rows in your Matrix: ");
                int rowsM = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please indicate the number of collumns in your Matrix: ");
                int collumnsM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("First Matrix is:");


                int[,] randommatrix = new int[rowsM, collumnsM]; 
                for (int x = 0; x < rowsM; x++)
                {
                    for (int y = 0; y < collumnsM; y++)
                    {
                        Random rnd = new Random();
                        randommatrix[x, y] = rnd.Next(0,9);
                        Console.Write(randommatrix[x, y] + "  ");///outputs first matrix
                    }
                    Console.WriteLine();
                }
            Console.WriteLine();



            int a;
            int b;
            int[,] NewArray = new int[2, 3];
            int min = 0;
            int max = 9;
            Random randomnum = new Random();
            for (a = 0; a < NewArray.GetLength(0); a++)
            {
                for (b = 0; b < NewArray.GetLength(1); b++)
                {
                    NewArray[a, b] = randomnum.Next(min, max);
                }
            }

            Console.WriteLine("Second Matrix is:");
            int[,] NewArray2 = new int[3, 2];
            for (a = 0; a < NewArray2.GetLength(0); a++)
            {
                Console.WriteLine();
                for (b = 0; b < NewArray2.GetLength(1); b++)
                {
                    NewArray2[a, b] = randomnum.Next(min, max);
                    Console.Write(NewArray2[a, b]);///outputs second matrix
                    Console.Write(" ");
                }
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Multipled matrix:");
            int[,] cMatrix = new int[2, 2];


            cMatrix[0,0] = ((NewArray[0, 0] * NewArray2[0, 0]) + (NewArray[0, 1] * NewArray2[1, 0]) + (NewArray[0, 2] * NewArray2[2, 0]));
            cMatrix[1, 0] = ((NewArray[1, 0] * NewArray2[0, 0]) + (NewArray[1, 1] * NewArray2[1, 0]) + (NewArray[1, 2] * NewArray2[2, 0 ]));
            cMatrix[0, 1] = ((NewArray[0, 0] * NewArray2[0, 1]) + (NewArray[0, 1] * NewArray2[1, 1]) + (NewArray[0, 2] * NewArray2[2, 1]));
            cMatrix[1, 1] = ((NewArray[1, 0] * NewArray2[0, 1]) + (NewArray[1, 1] * NewArray2[1, 1]) + (NewArray[1, 2] * NewArray2[2, 1]));
            for (a = 0; a < cMatrix.GetLength(0); a++)
            {
                Console.WriteLine();
                for (b = 0; b < cMatrix.GetLength(1); b++)
                {
                    Console.Write(cMatrix[a, b]);///outputs the product of matrix a and matrix b as matrix c
                    Console.Write(" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Matrix Program!");
            Console.Write("Please select one of the following options: ");
            Console.WriteLine();
            Console.WriteLine("1: The Random Matrix");
            Console.WriteLine("2: The Transpose Matrix");
            Console.WriteLine("3: Multiplying a Matrix by a Constant");
            Console.WriteLine("4: Multiplying Two Matrices");
            Console.WriteLine();
            Console.Write("Your choice is: ");
            int option1 = Convert.ToInt32(Console.ReadLine();


            if (option1 == 1)///this whole option 1 code will fall under the method generateMatrix
            {
                generatematrix();
                Console.WriteLine();
            }


            if (option1 == 2)
            {
                generatetranspose();
                Console.WriteLine();
            ///this piece of code falls under the method generateTranspose

            ///this is the end of the piece of code that falls under the method generateTranspose
            }

            if (option1 == 3)
            {
                multiplymatrixbyconstant();
                Console.WriteLine();
            ///this piece of code falls under the method multiplyMatrixByConstant
                
            ///this is the end of the piece of code that falls under the method multiplyMatrixByConstant

            }

            if (option1 == 4)
            {
                multiplymatrix();
                Console.WriteLine();

                // ///multiplyMatrix method(this part of the code is not finished, I died trying to figure this out)
                // Console.Write("Enter the number of Rows for your Matrix: ");
                // int rows2 = Convert.ToInt32(Console.ReadLine());
                // Console.Write("Enter the number of collumns for your Matrix: ");
                // int collumns2 = Convert.ToInt32(Console.ReadLine());

                // rows2 = 2;
                // collumns2 = 3;

                // int[,] randommatrix = new int[rows2, collumns2]; 
                // for (int x = 0; x < rows2; x++)
                // {

                //     for (int y = 0; y < collumns2; y++)
                //     {
                //         Random rnd = new Random();
                        
                //         randommatrix[x, y] = rnd.Next(0,9);
                //         Console.Write(randommatrix[x, y] + "  ");
                        
                //     }
                //     Console.WriteLine();
                // }
                // Console.ReadLine();


                // Console.Write("Enter the number of Rows for your second Matrix: ");
                // int rows3 = Convert.ToInt32(Console.ReadLine());
                // Console.Write("Enter the number of collumns for your second Matrix: ");
                // int collumns3 = Convert.ToInt32(Console.ReadLine());

                // rows3 = 3;
                // collumns3 = 2;

                // int[,] randommatrix2 = new int[rows3, collumns3]; 
                // for (int x = 0; x < rows3; x++)
                // {

                //     for (int y = 0; y < collumns3; y++)
                //     {
                //         Random rnd = new Random();
                        
                //         randommatrix2[x, y] = rnd.Next(0,9);
                //         Console.Write(randommatrix2[x, y] + "  ");
                        
                //     }
                //     Console.WriteLine();
                // }
                // Console.ReadLine();

                // int cmatrix1 = 0;
                // int cmatrix2 = 0;
                // int cmatrix3 = 0;
                // int cmatrix4 = 0;
                
              
                
                // for (int x = 0; x < 1; x++)
                // {

                //     for (int y = 0; y < 3; y++)
                //     {
                //         if (y == 0)
                //         {
                //         cmatrix1 = randommatrix[x,y] * randommatrix2[y,x];
                //         }
                //         if (y == 1)
                //         {
                //             int cmatrix1partialtotal = cmatrix1 + randommatrix[x,y] * randommatrix2[y,x];
                //             cmatrix1 = cmatrix1partialtotal;
                            
                //         }
                //         if (y == 2)
                //         {
                //             int cmatrix1partialtotal2 = cmatrix1 + randommatrix[x,y] * randommatrix2[y,x];
                //             cmatrix1 = cmatrix1partialtotal2;
                //             Console.Write(cmatrix1);
                //         }
                        
                        
                //     }
                    
                //     Console.WriteLine();
                // }
                // Console.ReadLine();

                // for (int x = 1; x < 2; x++)
                // {
                //     for (int y = 0; y < 3; y++)
                //     {
                //         if (y == 0)
                //         {
                //         cmatrix2 = randommatrix[x,y] * randommatrix2[y,x];
                //         }
                //         if (y == 1)
                //         {
                //             int cmatrix1partialtotal = cmatrix2 + randommatrix[x,y] * randommatrix2[y,x];
                //             cmatrix2 = cmatrix1partialtotal;
                            
                //         }
                //         if (y == 2)
                //         {
                //             int cmatrix1partialtotal2 = cmatrix2 + randommatrix[x,y] * randommatrix2[y,x];
                //             cmatrix2 = cmatrix1partialtotal2;
                //             Console.Write(cmatrix2);
                //         }
                        
                //     }
                //     Console.WriteLine();
                // } 
                // Console.ReadLine();




            }
        }
    }
}

