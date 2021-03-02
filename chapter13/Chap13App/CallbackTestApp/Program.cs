using System;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b); // a, b 비교 대리자
    class Program
    {
        //오름차순 a > b1 : 1 리턴, a = b : 0 리턴, a < b : -1리턴
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1; //a와 b를 바꿈 
            else if (a == b) return 0;
            else return -1;
        }

        //내림차순 비교, a < b : 1 리턴, a = b : 0 리턴, a > b : -1 리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1; //b와 a 순서 바꿀 것 
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] Dataset, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < Dataset.Length; i++)
            {
                for (int j = 0; j < Dataset.Length - (i + 1); j++)
                {
                    //비교하여 값 위치 변경 swao
                    if(comparer(Dataset[j], Dataset[j + 1]) > 0)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }


                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };
            Console.WriteLine("Sorting");
            BubbleSort(array, new Compare(AscendCompare)); //오름차순 정렬
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
