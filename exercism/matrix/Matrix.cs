using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    public class Matrix
    {
        private readonly string input;

        public Matrix(string input)
        {
            this.input = input;
        }

        public int[] Row(int row)
        {
            return [1];
        }

        public int[] Column(int col)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
