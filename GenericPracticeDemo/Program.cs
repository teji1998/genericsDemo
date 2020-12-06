using System;

namespace GenericPracticeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of generics !!!!!");
            Console.WriteLine("=======================================");
            int[] intArray = { 1, 7, 8 };
            double[] doubleArray = { 1.1, 2.2, 3.3 };
            char[] charArray = { 'H', 'O', 'L','A' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
        }

        public class PrintArray<T>
        {
            private T[] inputArray;
            public PrintArray(T[] inputArray)
            {
                this.inputArray = inputArray; 
            }
            public void toPrint()
            {
                foreach (var element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("======================");
            }
        }

       
        
    }
}
