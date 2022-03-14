using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math : ");
                Console.WriteLine("Enter an integer number greater than zero : ");
                int num = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[num];
                Populate(arr);

                Console.WriteLine("Your array is size: " + num);
                Console.WriteLine("The numbers in array are ");
                foreach (int e in arr)
                {
                    Console.WriteLine(e);
                }
                
                int sum = GetSum(arr);
                Console.WriteLine("The sum of array: " + sum);

                int product = GetProduct(arr, sum);
                

                decimal co = GetQuotient(product);
                Console.WriteLine("Array Quotient is: " + co);
                Console.WriteLine("Programe complete");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong! " + e);
            }


        }

        static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter number " + (i+1) + "of" + (arr.Length));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static int GetSum(int[] arr)
        {
            int sum = 0;

            foreach (int s in arr)
            {
                sum += s;
            }

            if (sum < 20)
            {
                throw new Exception("Value of "+sum+" is too low");
            }

            return sum;
        }

        static int GetProduct(int[] arr, int sum)
        {
            int num = -1;
            Console.WriteLine("Pick a random number between 1 and " + arr.Length);

            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            int product = sum * num;

            return product;
        }

        static decimal GetQuotient(int product)
        {
            Console.WriteLine("Please enter number to divide your product " + product + " by");
            decimal result = 0;
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                result = Decimal.Divide(product, num);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide on Zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong " + e);
            }

            return result;
            
        }

      
    }

    
}
