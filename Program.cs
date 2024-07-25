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
            int[] arr = { 5, 1, 4, 2, 8 };

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
            Console.WriteLine();
        }
    }
}
