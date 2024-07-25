using Assignment_C__Advanced_1.Range_Q2;

namespace Assignment_C__Advanced_1
{
    internal class Program
    {
        static void BubbleSort(ref int[] arr)
        {
            int n = arr.Length;
            bool swap;
            for (int i = 0; i < n; i++)
            {
                swap = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;
                    }

                }
                if (!swap)
                {
                    break;
                }

            }
        }
        static void Main(string[] args)
        {
            #region Q1
            /*int[] arr = { 5, 1, 4, 2, 8 };

                Console.WriteLine("Original array:");

                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                BubbleSort(ref arr);

                Console.WriteLine("Sorted array:");

                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();*/
            #endregion

            #region Q2
            /*var intRange = new Range<int>(5, 10);
                Console.WriteLine($"Is 7 in range (5-10): {intRange.IsInRange(7)}"); 
                Console.WriteLine($"Length of range (5-10): {intRange.Length()}");  

                var doubleRange = new Range<double>(1.5, 4.5);
                Console.WriteLine($"Is 3.2 in range (1.5-4.5): {doubleRange.IsInRange(3.2)}"); 
                Console.WriteLine($"Length of range (1.5-4.5): {doubleRange.Length()}");    

                var charRange = new Range<char>('a', 'z');
                Console.WriteLine($"Is 'm' in range ('a'-'z'): {charRange.IsInRange('m')}"); 
                Console.WriteLine($"Length of range ('a'-'z'): {charRange.Length()}");   */ 
            #endregion
        }
    }
}
