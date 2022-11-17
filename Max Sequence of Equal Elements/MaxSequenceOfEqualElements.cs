namespace Max_Sequence_of_Equal_Elements
{
    internal class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
           var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var startIndex = 0;
            var sequenceLenght = 1;

            var bestStartIndex = 0;
            var bestSequenceLenght = 0;

            for (var i = 1; i < arr.Length; i++) 
            { 
                if (arr[i] == arr[i - 1])
                {
                    sequenceLenght++;
                    if (bestSequenceLenght < sequenceLenght)
                    {
                        bestSequenceLenght = sequenceLenght;
                        bestStartIndex = startIndex;
                    }
                }
                else
                { 
                   startIndex = i;
                   sequenceLenght = 1;
                }
            }

            for (int i = bestStartIndex; i < bestStartIndex + bestSequenceLenght; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }
    }
}