using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku
{
    class Program
    {
        public static Jatek jatek;
        public static string filename;
        public static int inputrow;
        public static int inputcol;
        public static string num;

        static void Main(string[] args)
        {
            FirstMission();

            Teszt();

            ThirdMission();

            FourthMission();

            FifthMission();
            Console.ReadKey();
        }

        private static void FifthMission()
        {
            bool Check = true;
            if (jatek.sudoku[inputrow, inputcol] != "0")
            {
                Check = false;
                Console.WriteLine("This Position is already filled");
            }
            else if(jatek.sudoku[inputrow, inputcol] == "0")
            {
                for (int pos = 0; pos < 9; pos++)
                {
                    if (jatek.sudoku[inputrow,pos] == num)
                    {
                        Console.WriteLine("This row already has this number in it");
                        Console.WriteLine(jatek.sudoku[inputrow, pos] + " <- ugyan az-> " + num);
                        Check = false;
                    }
                    else if (jatek.sudoku[pos,inputcol] == num)
                    {
                        Console.WriteLine("This column already has this number in it");
                        Console.WriteLine(jatek.sudoku[inputcol, pos] + " <- ugyan az-> " + num + " Ezen az indexen: " + pos);
                        Check = false;
                    }
                }
            }
            if (Check)
            {
                Console.WriteLine("This step is valid.");
            }

            //
        }


        //inputcol inputrow 
        // 

        private static void FourthMission()
        {
            Console.WriteLine($"Exercise 4.: The ratio of blank positions is {Math.Round((jatek.count * 100) / 81)}%");
        }

        private static void ThirdMission()
        {
            Console.WriteLine(jatek.sudoku[inputrow,inputcol] != "0" ? $"The number in the given position is: {jatek.sudoku[inputrow, inputcol]}" : "The given number is not filled yet");
            Console.WriteLine($"The position belongs to region: ");
            
        }

        private static void Teszt()
        {
            jatek = new Jatek(filename);
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Console.Write(jatek.sudoku[row,col]);
                }
                Console.WriteLine();
            }
        }


        private static void FirstMission()
        {
            Console.WriteLine("Excersise 1.\nEnter the name of the input file: ");
            filename = Console.ReadLine();
            Console.WriteLine("Enter a row identifier");
            inputrow = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("Enter a column identifier");
            inputcol = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("What number do you want to put in this position?: ");
            num = Console.ReadLine();
        }


    }
}
