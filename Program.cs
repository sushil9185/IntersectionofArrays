namespace IntersectionofArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = {1,2,2,3,3,4,5,6};
            int[] myArray2 = {2,3,3,5,6,6,7};
            PrintArray(FindIntersection2(myArray1,myArray2));

        }

        static int[] FindIntersection2(int[] myArray1, int[] myArray2)
        {
            int i = 0, j = 0;
            int n = myArray1.Length, m = myArray2.Length;
            List<int> ls = new List<int>();
            while(i < n && j < m)
            {
                if (myArray1[i] < myArray2[j])
                {
                    i++;
                }
                else if (myArray2[j] > myArray1[i])
                {
                    j++;
                }
                else
                {
                    ls.Add(myArray1[i]);
                    i++;
                    j++;
                }
            }
            return ls.ToArray();
        }

        static int[] FindInterSection1(int[] myArray1, int[] myArray2)
        {
            List<int> ls = new List<int>();
            int[] visited = new int[myArray1.Length];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = 0;
            }

            for(int i = 0;i < myArray1.Length; i++)
            {
                for(int j = 0; j < myArray2.Length; j++)
                {
                    if (myArray1[i] == myArray2[j] && visited[j] != 1)
                    { 
                        ls.Add(myArray1[i]);
                        visited[j] = 1;
                        break;
                    }
                    if (myArray2[j] > myArray1[i])
                    {
                        break;
                    }
                }
            }
            return ls.ToArray();
        }

        static void PrintArray(int[] a)
        {
            for(int i = 0; i< a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}