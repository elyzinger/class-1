using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod1();
            //NewMethod2();
            //NewMethod3();

            int[,] array = {

                { 1,2},
                { 3,4}
               };
        
            for (int i = 0; i < array.GetLength(0); i++)
                
            {
                

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    
                    Console.Write(array[i, j]);

                }
                Console.WriteLine();
                
                
            }
            
            Console.ReadLine();
            


        }

        private static void NewMethod3()
        {
            int[,] array = new int[3, 3];
            Random engine = new Random();
            int submarine = 0;
            for (int i = 0; i < array.GetLength(0); i++)

            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = engine.Next(0, 2);
                    if (array[i, j] == 1)
                    {
                        submarine++;
                    }
                    Console.Write(array[i, j]);

                }
                Console.WriteLine();

            }
            int trials = 0;
            do
            {
                Console.WriteLine("anter row");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("anter column");
                int columm = Convert.ToInt32(Console.ReadLine());
                if (array[row, columm] == 1)
                {
                    Console.WriteLine("boom");
                    submarine--;
                    array[row, columm] = 0;
                }
                else
                {
                    Console.WriteLine("miss....");
                }
                trials++;

            }
            while (submarine > 0);
            Console.WriteLine("you win");
            Console.WriteLine($" trials = {trials}");
            Console.ReadLine();
        }

        private static void NewMethod2()
        {
            int[,] array = new int[4, 4];
            Random engine = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = engine.Next(1, 10);
                    Console.WriteLine(array[i, j]);
                }
            }
            Console.WriteLine("please choose a num");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == num)
                    {
                        Console.Write(array[i,j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

        private static void NewMethod1()
        {
            int sum = 0;
            Console.Write("how many student in class:");
            int students = Convert.ToInt16(Console.ReadLine());
            int[] array = new int[students];
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("whats the score");
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + array[i];
            }
            double avg = sum / students;
            Console.WriteLine(array[0]);
            Console.WriteLine(sum);
            Console.WriteLine($"{avg} avarage for class");
            Console.ReadLine();
        }
    }
}
