using System.Security.Cryptography;

namespace _16_11{
    
    class Program
    {
        class Classwork
        {
            public static void array()
            {
                Random rnd = new Random();
                Console.WriteLine("Enter the size of the array");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("Enter lower number: ");
                int lower = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter upper number: ");
                int upper = Convert.ToInt32(Console.ReadLine());
                if (lower > upper)
                {
                    (lower, upper) = (upper, lower);
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(lower, upper);
                }
                Console.WriteLine("The numbers are: ");
                foreach (int i in arr)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Array.Sort(arr);
                Console.WriteLine("The sorted numbers are: ");
                foreach (var i in arr)
                {
                    Console.Write($"{i} ");
                }
            }

            public static void first_task()
            {
                Int32 size = 10;
                Int32[] arr = new Int32[size];
                Random rnd = new Random(DateTime.Now.Millisecond);
                Int32 par = 0, npar = 0, unique = 0;
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rnd.Next(-100, 100);
                }
                
                Console.WriteLine();
                Array.Sort(arr);
                Console.WriteLine($"The numbers are: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        par++;
                    } else if (arr[i] % 2 != 0)
                    {
                        npar++;
                    }

                    if (i + 1 != size)
                    { 
                        if(arr[i] != arr[i + 1])
                        {
                            unique++;
                        }
                    }
                    Console.Write($"{arr[i]} ");
                }          
                Console.WriteLine();
                Console.WriteLine($"The count of parnumbers: {par} \nThe count of Nparnumbers: {npar}\nThe count of unique: {unique}");
            }

            public static void second_task()
            {
                Int32 size = 10;
                Int32[] arr = new Int32[size];
                Console.WriteLine("Enter the mid number: ");
                int mid = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random(DateTime.Now.Millisecond);
                
                Console.WriteLine("The array numbers are: ");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rnd.Next(-100, 100);
                    Console.Write($"{arr[i]} ");
                }
                Array.Sort(arr);
                Console.WriteLine();
                Console.WriteLine("Numbers that less than mid are: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < mid)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                }
            }

            public static void third_task()
            {
                Int32 size = 10;
                Int32[] arr = new Int32[size];
                Random rand = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rand.Next(-10, 10);
                    Console.Write($"{arr[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine("Enter three numbers in range from -10 to 10: ");
                string? input = Console.ReadLine();
                Int32[] numArr = input.Split(' ').Select(Int32.Parse).ToArray();
                Int32 count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == numArr[0] && arr[i + 1] == numArr[1] && arr[i + 2] == numArr[2])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Count of povtors is: {count}");
            }

            public static void fourth_task()
            {
                Console.WriteLine("Enter size of first array: ");
                int size_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter size of second array: ");
                int size_2 = Convert.ToInt32(Console.ReadLine());
                int size_3 = size_1 + size_2;

                int[] arr_1 = new int[size_1];
                int[] arr_2 = new int[size_2];
                int[] arr_3 = new int[size_3];

                Random rnd = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < arr_1.Length; i++)
                {
                    arr_1[i] = rnd.Next(-100, 100);
                }

                for (int i = 0; i < arr_2.Length; i++)
                {
                    arr_2[i] = rnd.Next(-25, 25);
                }

                Array.Sort(arr_1);
                Array.Sort(arr_2);

                Array.Copy(arr_1, 0, arr_3, 0, arr_1.Length);
                Array.Copy(arr_2, 0, arr_3, arr_1.Length, arr_2.Length);
                
                Array.Sort(arr_3);

                int uniqueCount = 0;
                for (int i = 0; i < arr_3.Length - 1; i++)
                {
                    if (arr_3[i] != arr_3[i + 1])
                    {
                        arr_3[uniqueCount++] = arr_3[i];
                    }
                }
                
                arr_3[uniqueCount++] = arr_3[arr_3.Length - 1];

                
                int[] resultArray = new int[uniqueCount];
                Array.Copy(arr_3, resultArray, uniqueCount);
                
                Console.WriteLine("Merged unique elements:");
                foreach (int num in resultArray)
                {
                    Console.Write(num + " ");
                }
                
            }

            public static void fifth_task()
            {
                Int32 size = 15;
                Int32[,] arr = new Int32[size, size];
                Random rnd = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = rnd.Next(-25, 25);
                    }
                }
                Int32 min = arr[0, 0], max = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (min > arr[i, j])
                        {
                            min = arr[i, j];
                        }

                        if (max < arr[i, j])
                        {
                            max = arr[i, j];
                        }
                    }
                }
                Console.WriteLine($"The max number is: {max} and the min is: {min}");
            }

            public static void sixth_task()
            {
                Console.WriteLine("Enter a text: ");
                string? input = Console.ReadLine();
                string[] words = input.Split(' ');
                int wordsCount = words.Length;
                Console.WriteLine($"The count of words is: {wordsCount}");
            }

            public static void seventh_task()
            {
                Console.WriteLine("Enter a text: ");
                string? input = Console.ReadLine();
                string[] words = input.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                    Console.Write($"{words[i]} ");
                }
            }

            public static void eighth_task()
            {
                Console.Write("Enter a text: ");
                string? line = Console.ReadLine();
                char[] letters = {'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' }; 
                int count = 0;
                foreach (char el in line)
                {
                    if (Array.Exists(letters, x => x == el))
                    {
                        count++;        
                    }
                }
                Console.WriteLine($"The count of vowel letters is: {count}");
            }

            public static void ninth_task()
            {
                Console.WriteLine("Enter a text: ");
                string? input = Console.ReadLine();
                Console.WriteLine("Enter a find word: ");
                string? find = Console.ReadLine();
                string[] words = input.Split(' ');
                int count = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == find)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The count of word {find} is: {count}");
            }
        }

        class Homework
        {
            public static void first_task()
            {
                double[] A = new double[5];
                double[,] B = new double[3, 4];

                Console.WriteLine("Enter five numbers: ");
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = Convert.ToDouble(Console.ReadLine());
                }
                Random random = new Random();
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]} ");
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = random.NextDouble();
                        Console.Write($"{B[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
        
        static void Main(string[] args)
        {
            //Classwork.first_task();
            //Classwork.second_task();
            //Classwork.third_task();
            //Classwork.fourth_task();
            //Classwork.fifth_task();
            //Classwork.sixth_task();
            //Classwork.seventh_task();
            //Classwork.eighth_task();
            //Classwork.ninth_task();
            
            Homework.first_task();
        }
    }
}