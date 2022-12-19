namespace ConsoleApplication12
{
    class Task_151222
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            int[] arr2 = new int[] { 1, 1 };
            int[] arr3 = new int[] {1,3,3,5,8,7,7,7};
            Miss_el(arr);
            Miss_el(arr2);
            Miss_el(arr3);
            Console.ReadLine();
        }

        static void Miss_el(int[] array)
        {
            int len_arr = array.Length;
            int[] tru_arr = new int[len_arr];
            string ansv = "";
            for (int j = 1; j <= len_arr; j++)
                {
                tru_arr[j - 1] = j;
                }
            var mis_el = tru_arr.Except(array);
            foreach (var s in mis_el)
            ansv = ansv + " " + s.ToString();
            Console.WriteLine(ansv);
        }

    }
}