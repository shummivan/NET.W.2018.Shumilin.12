using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchDemo
{
    public class BinarySearch
    {
        #region private methods
        private bool IsEmpty<T>(List<T> list)
        {
            if (list.Count == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsSort<T>(List<T> list, IComparer<T> comparer)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (comparer.Compare(list[i - 1], list[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region public methods
        public int Search<T>(List<T> list, T target, IComparer<T> comparer)
        {
            int first = 0;
            int last = list.Count;
            int mid;

            if (comparer == null)
            {
                throw new ArgumentNullException();
            }

            if (IsEmpty(list) || !IsSort(list, comparer))
            {
                throw new Exception("Bad data format!");
            }

            while (first <= last)
            {
                mid = (first + last) / 2;

                if (comparer.Compare(list[mid], target) == 0)
                {
                    return mid;
                }
                else if (comparer.Compare(list[mid], target) < 0)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }

            return -11;
        }
        #endregion
    }

}
