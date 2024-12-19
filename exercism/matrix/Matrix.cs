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

        public Matrix(string input)
        {
            this.input = input;
        }

        public int[] Row(int row)
        {
            var rowIndex = row - 1;
            var rows = input.Split('\n');
            return rows[rowIndex].Split(' ')
                .Select(x => Convert.ToInt32(x))
                .ToArray();
        }

        public int[] Column(int col)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
