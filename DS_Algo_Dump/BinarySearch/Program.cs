
namespace BinarySearch
{
    internal class Program
    {
        public static List<int> Items = new List<int>();

        static void Main(string[] args)
        {
            int[] numArray = { 1, 1, 3, 10, 14, 25, 27, 34, 78, 90, 90, 120 };
            Items.AddRange(numArray);
            Console.WriteLine(BinSearch(Items, 15, 0, 11));

        }

        private static int BinSearch<T>(List<T> sortedList, T key, int start, int end) where T : IComparable<T>
        {
            if (start > end)
            {
                return -1;
            }

            if (key.CompareTo(sortedList[start]) < 0 || key.CompareTo(sortedList[end]) > 0)
            {
                return -1;
            }

            int middleIndex = (start + end) / 2;
            T middleValue = sortedList[middleIndex];

            /*    0 = both numbers are equal
                  1 = second number is smaller
                 -1 = first number is smaller
             */

            if (key.CompareTo(middleValue) == 0)
            {
                return middleIndex;
            }

            if (key.CompareTo(middleValue) < 0)
            {
                end = middleIndex - 1;
                return BinSearch(sortedList, key, start, middleIndex - 1);
            }

            if (key.CompareTo(middleValue) > 0)
            {
                start = middleIndex + 1;
                return BinSearch(sortedList, key, middleIndex + 1, end);
            }

            return -1;
        }
    }
}
