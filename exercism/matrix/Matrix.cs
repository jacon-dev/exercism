using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Matrix
    {
        private readonly string input = string.Empty;
        private string[] InputRows => input.Split('\n');

        public Matrix(string input)
        {
            this.input = input;
        }

        public int[] Row(int row)
        {
            return ToIntArray(InputRows[row - 1]);
        }

        public int[] Column(int col)
        {
            return (from row in InputRows 
                    select ToIntArray(row)[col - 1])
                    .ToArray();
        }

        private static int[] ToIntArray(string str)
        {
            return str.Split(' ')
                .Select(x => Convert.ToInt32(x))
                .ToArray();
        }
    }
}
