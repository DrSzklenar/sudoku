using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sudoku
{
    class Jatek
    {
        public string[,] sudoku = new string[9,9];
        public string[,] idk = new string[4,3];
        string[] temp;
        public double count;


        public Jatek(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                for (int row = 0; row < 9; row++)
                {
                    temp = sr.ReadLine().Split(' ');
                    for (int col = 0; col < 9; col++)
                    {
                        sudoku[row, col] = temp[col];
                        if (temp[col] == "0")
                        {
                            count++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {

                }

            }
        }
    }
}
