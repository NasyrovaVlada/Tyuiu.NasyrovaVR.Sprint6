using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NasyrovaVR.Sprint6.Task7.V20.Lib
{
    public class DataService : ISprint6Task7V20
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] line = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = line.Length;
            int colums = line[0].Split(';').Length;
            int[,] matrix = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] values = line[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j]);
                }
            }
            int row = matrix.GetLength(0);
            int colum = matrix.GetLength(1);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < colum; c++)
                {
                    if (c == 2 && matrix[r, c] >= 1 && matrix[r, c] <= 20)
                    {
                        matrix[r, c] = 111;
                    }
                }
            }
            return matrix;
        }
    }
}
