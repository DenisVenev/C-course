namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] n = new int[4];
            string[] s = { "OK this is the 1st item", "I'm the secound one"};
            int val, k;

            FillArray(n);

            val = GetMin(n, out k);
            Console.WriteLine("Smallest value: " + val);
            Console.WriteLine("Index of the element: " + k);
            Console.WriteLine("Result: A[{0}] = {1}", k, n[k]);
            Console.WriteLine();

            PrintArray(n);
            Console.WriteLine();

            ChangeValue(ref n);

            PrintArray(n);
            Console.WriteLine();

            PrintArray(s);
            Console.WriteLine();

            val = GetMin(n, out k);
            Console.WriteLine("Smallest value: " + val);
            Console.WriteLine("Index of the element: " + k);
            Console.WriteLine("Result: A[{0}] = {1}", k, n[k]);

        }

        static int GetMin(int[] nums, out int index)
        {
            index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[index])
                {
                    index = i;
                }
            }
            return nums[index];
        }

        static int[] ChangeValue(ref int[] n) {
            int[] m = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                m[i] = n[i] + 1;
            }
            n = m;
            return n;
        }

        static void PrintArray(string[] n) 
        { 
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }

        static int[] FillArray(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                n[i] = int.Parse(Console.ReadLine());
            }
            return n;
        }

        static void PrintArray(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i]);
            }
        }

    }
}
