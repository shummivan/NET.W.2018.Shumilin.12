using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchDemo
{
    [TestFixture]
    public class BinarySearchTests
    {
        BinarySearch bs = new BinarySearch();

        [TestCase(new int[] { 10, 22, 34, 48, 51, 62, 79, 88, 976 }, 62, ExpectedResult = 5)]
        [TestCase(new int[] { 10, 22, 34, 48, 51, 62, 79, 88, 976 }, 10, ExpectedResult = 0)]
        [TestCase(new int[] { 10, 22, 34, 48, 51, 62, 79, 88, 976 }, 976, ExpectedResult = 8)]
        public int BinarySearch_ValidIntFormat_ValidResult(int[] arr, int target)
        {
            List<int> list = arr.ToList();
            return bs.Search(list, target, Comparer<int>.Default);
        }

        [TestCase(new string[] { "10", "22", "34", "48", "51", "62", "79", "88", "976" }, "62", ExpectedResult = 5)]
        [TestCase(new string[] { "10", "22", "34", "48", "51", "62", "79", "88", "976" }, "10", ExpectedResult = 0)]
        [TestCase(new string[] { "10", "22", "34", "48", "51", "62", "79", "88", "976" }, "976", ExpectedResult = 8)]
        public int BinarySearch_ValidStringFormat_ValidResult(string[] arr, string target)
        {
            List<string> list = arr.ToList();
            return bs.Search(list, target, Comparer<string>.Default);
        }

        [TestCase(new string[] { "10", "22", "34", "48", "51", "62", "79", "88", "976" }, "976")]
        public void BinarySearch_InvalidComparerFormat_ArgumentNullException(string[] arr, string target)
        {
            List<string> list = arr.ToList();
            Assert.Throws<ArgumentNullException>(() => bs.Search(list, target, null));
        }
    }
}
