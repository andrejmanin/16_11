using System.Text.RegularExpressions;

namespace _16_11
{
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
                    }
                    else if (arr[i] % 2 != 0)
                    {
                        npar++;
                    }

                    if (i + 1 != size)
                    {
                        if (arr[i] != arr[i + 1])
                        {
                            unique++;
                        }
                    }

                    Console.Write($"{arr[i]} ");
                }

                Console.WriteLine();
                Console.WriteLine(
                    $"The count of parnumbers: {par} \nThe count of Nparnumbers: {npar}\nThe count of unique: {unique}");
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
                char[] letters = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
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
                    Console.Write($"A[{i}] = ");
                    A[i] = double.Parse(Console.ReadLine());
                }

                Random random = new Random();

                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = Math.Round(random.NextDouble() * 100 - 50, 2);
                    }
                }

                Console.WriteLine("\nArray A:");
                foreach (var value in A)
                {
                    Console.Write(value + " ");
                }

                Console.WriteLine("\nArray B:");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                double maxElement = double.MinValue, minElement = double.MaxValue;
                foreach (var value in A) maxElement = Math.Max(maxElement, value);
                foreach (var value in B) maxElement = Math.Max(maxElement, value);
                foreach (var value in A) minElement = Math.Min(minElement, value);
                foreach (var value in B) minElement = Math.Min(minElement, value);

                double sum = 0, product = 1;
                foreach (var value in A)
                {
                    sum += value;
                    product *= value;
                }

                foreach (var value in B)
                {
                    sum += value;
                    product *= value;
                }

                // Сума парних елементів масиву A
                double sumEvenA = 0;
                foreach (var value in A)
                {
                    if (value % 2 == 0) sumEvenA += value;
                }

                double sumOddColumnsB = 0;
                for (int j = 1; j < B.GetLength(1); j += 2)
                {
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }

                Console.WriteLine($"\nЗагальний максимальний елемент: {maxElement}");
                Console.WriteLine($"Загальний мінімальний елемент: {minElement}");
                Console.WriteLine($"Загальна сума усіх елементів: {sum}");
                Console.WriteLine($"Загальний добуток усіх елементів: {product}");
                Console.WriteLine($"Сума парних елементів масиву A: {sumEvenA}");
                Console.WriteLine($"Сума непарних стовпців масиву B: {sumOddColumnsB}");
            }

            public static void second_task()
            {
                int[,] array = new int[5, 5];
                Random random = new Random();

                int max = int.MinValue, min = int.MaxValue;
                int maxIndex = 0, minIndex = 0;

                // Заповнення масиву та пошук мінімального й максимального елементів
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(-100, 101);
                        Console.Write($"{array[i, j]} ");
                        int linearIndex = i * array.GetLength(1) + j;

                        if (array[i, j] > max)
                        {
                            max = array[i, j];
                            maxIndex = linearIndex;
                        }

                        if (array[i, j] < min)
                        {
                            min = array[i, j];
                            minIndex = linearIndex;
                        }
                    }

                    Console.WriteLine();
                }

                // Визначення порядку індексів
                if (minIndex > maxIndex)
                {
                    (minIndex, maxIndex) = (maxIndex, minIndex);
                }

                // Обчислення суми
                int sum = 0;
                for (int k = minIndex + 1; k < maxIndex; k++)
                {
                    int row = k / array.GetLength(1);
                    int col = k % array.GetLength(1);
                    sum += array[row, col];
                }

                Console.WriteLine($"The sum of elements between min \"{min}\" and max \"{max}\" is: {sum}");
            }

            public static void third_task()
            {
                const int number = 5;
                string? line = Console.ReadLine();
                string encrypted = "", unencrypted = "";
                for (int i = 0; i < line.Length; i++)
                {
                    encrypted += (char)(line[i] + number);
                }

                for (int i = 0; i < line.Length; i++)
                {
                    unencrypted += (char)(encrypted[i] - number);
                }

                Console.WriteLine($"Encrypted text: {encrypted}");
                Console.WriteLine($"Unencrypted text: {unencrypted}");
            }

            public static void fourth_task()
            {
                int[,] array = new int[5, 5];
                Random random = new Random();

                Console.WriteLine("First matrix:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(-25, 25);
                        Console.Write($"{array[i, j]} ");
                    }

                    Console.WriteLine();
                }

                int[,] arr = new int[5, 5];
                Console.WriteLine("\nSecond matrix:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        arr[i, j] = random.Next(-25, 25);
                        Console.Write($"{arr[i, j]} ");
                    }

                    Console.WriteLine();
                }

                int input = 0;
                do
                {
                    Console.WriteLine("Enter task: ");
                    Console.WriteLine("1. Multiplication matrix on number");
                    Console.WriteLine("2. Addition of matrices");
                    Console.WriteLine("3. Multiplication of matrices");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter number: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (input)
                    {
                        case 1:
                        {
                            Console.WriteLine("Enter number: ");
                            input = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    array[i, j] = array[i, j] * input;
                                    Console.Write($"{array[i, j]} ");
                                }

                                Console.WriteLine();
                            }

                            break;
                        }
                        case 2:
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    array[i, j] += arr[i, j];
                                    Console.Write($"{array[i, j]} ");
                                }

                                Console.WriteLine();
                            }

                            break;
                        }
                        case 3:
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    array[i, j] *= arr[i, j];
                                    Console.Write($"{array[i, j]} ");
                                }

                                Console.WriteLine();
                            }

                            break;
                        }
                        case 4:
                            break;
                        default:
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                    }
                } while (input != 4);
            }

            public static void fifth_task()
            {
                Console.WriteLine("Write 'exit' to exit");
                string? line;
                int sum = 0;

                do
                {
                    line = Console.ReadLine();
                    if (line == null || line.Trim() == "") continue;
                    if (line.ToLower() == "exit") break;

                    try
                    {
                        int start = 0;
                        char lastSign = '+'; 
                        for (int i = 0; i <= line.Length; i++)
                        {
                            if (i == line.Length || line[i] == '-' || line[i] == '+')
                            {
                                string numberStr = line.Substring(start, i - start).Trim();
                                if (int.TryParse(numberStr, out int number))
                                {
                                    if (lastSign == '+') sum += number;
                                    else if (lastSign == '-') sum -= number;

                                    if (i < line.Length) lastSign = line[i];
                                    start = i + 1;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input.");
                                    sum = 0; 
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        sum = 0;
                    }

                    Console.WriteLine($"Sum: {sum}");
                } while (true);
            }

            public static void sixth_task()
            {
                char[] SpaceDeleting(char[] array, int index)
                {
                    index++;
                    while (array[index] != ' ')
                    {
                        index++;
                    }
                    if(index >= array.Length)
                    {
                        return null!;
                    }
                    char[] newArray = new char[array.Length];
                    Array.Copy(array, index, newArray, array.Length, array.Length - index);
                    return newArray;
                }

                string? line = Console.ReadLine();
                try
                {
                    int dotPosition = 0;
                    if (line == null || line.Trim() == "") return;
                    char[] chrLine = line.ToCharArray();

                    if (chrLine[0] == ' ')
                    {
                        do 
                        {
                            dotPosition++;
                        } while(chrLine[dotPosition] == ' ');
                    }
                    chrLine[dotPosition] = (char)(chrLine[dotPosition] - 32);
                    
                    while (dotPosition < chrLine.Length)
                    {
                        if (chrLine[dotPosition] == '.' && dotPosition + 1 < chrLine.Length)
                        {
                            do 
                            {
                                dotPosition++;
                            } while(chrLine[dotPosition] == ' '); 
                            chrLine[dotPosition] = (char)(chrLine[dotPosition] - 32);
                        }
                        dotPosition++;
                    }
                    line = new string(chrLine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine(line);
            }
            
            public static void seventh_task()
            {
                Console.WriteLine("Enter ban word: ");
                string? banWord = Console.ReadLine();
                string pattern = @"\W+"; // Matches any non-word character
                Console.WriteLine("Enter text: ");
                string? text = Console.ReadLine();
                if (text != null)
                {
                    string[]? words = Regex.Split(text, pattern);
            
                    if (words == null || words.Length == 0)
                    {
                        Console.WriteLine("Invalid input.");
                        return;
                    }
                    string[] updatedText = new string[words.Length];
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i] == banWord)
                        {
                            updatedText[i] = new string('*', words[i].Length);
                            continue;
                        }
                        updatedText[i] = words[i];
                    }
                    /*
                 * To be, or not to be, that is the question, \nWhether 'tis nobler in the mind to suffer \nThe slings and arrows of outrageous fortune, \nOr to take arms against a sea of troubles, \nAnd by opposing end them? To die: to sleep; \nNo more; and by a sleep to say we end \nThe heart-ache and the thousand natural shocks \nThat flesh is heir to, 'tis a consummation \nDevoutly to be wish'd. To die, to sleep
                 */
                    Console.WriteLine(string.Join(" ", updatedText));
                }
            }
        }

        static void Main(string[] args)
        {
            // Classwork.first_task();
            // Classwork.second_task();
            // Classwork.third_task();
            // Classwork.fourth_task();
            // Classwork.fifth_task();
            // Classwork.sixth_task();
            // Classwork.seventh_task();
            // Classwork.eighth_task();
            // Classwork.ninth_task();

            // Homework.first_task();
            // Homework.second_task();
            // Homework.third_task();
            // Homework.fourth_task();
            // Homework.fiveth_task();
            // Homework.sixth_task();
            Homework.seventh_task();
        }
    }
}