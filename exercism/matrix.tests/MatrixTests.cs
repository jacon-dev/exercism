using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix.tests
{
    internal class MatrixTests
    {
        [Test]
        public void Extract_row_from_one_number_matrix()
        {
            var sut = new Matrix("1");
            Assert.That(new[] { 1 }, Is.EqualTo(sut.Row(1)));
        }

        [Test]
        public void Can_extract_row()
        {
            var sut = new Matrix("1 2\n3 4");
            Assert.That(new[] { 3, 4 }, Is.EqualTo(sut.Row(2)));
        }

        [Test]
        public void Extract_row_where_numbers_have_different_widths()
        {
            var sut = new Matrix("1 2\n10 20");
            Assert.That(new[] { 10, 20 }, Is.EqualTo(sut.Row(2)));
        }

        [Test]
        public void Can_extract_row_from_non_square_matrix_with_no_corresponding_column()
        {
            var sut = new Matrix("1 2 3\n4 5 6\n7 8 9\n8 7 6");
            Assert.That(new[] { 8, 7, 6 }, Is.EqualTo(sut.Row(4)));
        }

        [Test]
        public void Extract_column_from_one_number_matrix()
        {
            var sut = new Matrix("1");
            Assert.That(new[] { 1 }, Is.EqualTo(sut.Column(1)));
        }

        [Test]
        public void Can_extract_column()
        {
            var sut = new Matrix("1 2 3\n4 5 6\n7 8 9");
            Assert.That(new[] { 3, 6, 9 }, Is.EqualTo(sut.Column(3)));
        }

        [Test]
        public void Can_extract_column_from_non_square_matrix_with_no_corresponding_row()
        {
            var sut = new Matrix("1 2 3 4\n5 6 7 8\n9 8 7 6");
            Assert.That(new[] { 4, 8, 6 }, Is.EqualTo(sut.Column(4)));
        }

        [Test]
        public void Extract_column_where_numbers_have_different_widths()
        {
            var sut = new Matrix("89 1903 3\n18 3 1\n9 4 800");
            Assert.That(new[] { 1903, 3, 4 }, Is.EqualTo(sut.Column(2)));
        }
    }
}
