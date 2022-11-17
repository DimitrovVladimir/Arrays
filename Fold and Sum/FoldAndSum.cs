namespace Fold_and_Sum
{
    internal class FoldAndSum
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = arr.Length/4;


            var leftArr = new int[k];
            var rightArr = new int[k];
            var middleArr = new int[2 * k];


            var resultArr = new int[2 * k];


            for (int i = 0; i < k; i++)
            {
                leftArr[i] = arr[i];

            }
            for (int i = 0; i < k; i++)
            {
                rightArr[i] = arr[3* k + i];
            }
            for (int i = 0; i < 2 * k; i++)
            {
                middleArr[i] = arr[k + i];
            }
            Array.Reverse(leftArr);
            Array.Reverse(rightArr);
            for (int i = 0; i < k; i++)
            {
                resultArr[i] += middleArr[i]+leftArr[i];
                resultArr[i + k] += middleArr[i + k] + rightArr[i];
            }
            Console.WriteLine(String.Join(" ", resultArr));
        }
    }
}