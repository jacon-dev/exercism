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
            return InputRows[row - 1].Split(' ')
                .Select(x => Convert.ToInt32(x))
                .ToArray();
        }

        public int[] Column(int col)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
