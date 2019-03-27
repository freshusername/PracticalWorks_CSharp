using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class MergeSort : AbstractSortable
    {
        public void Alghorithm(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                Alghorithm(input, low, middle);
                Alghorithm(input, middle + 1, high);
                Alghorithm(input, low, middle, high);
            }
        }

        public override void Alghorithm(int[] input)
        {
            Alghorithm(input, 0, input.Length - 1);
        }

        private void Alghorithm(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

        }

        public void PrintArray(int[] input)
        {
            string result = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result = result + input[i] + " ";
            }
            if (input.Length == 0)
            {
                result = "Array is empty.";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
