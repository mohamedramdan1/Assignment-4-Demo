﻿using System;
using System.Security;
using System.Text;

namespace Assignment_4___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region loop
            #region for-loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region foreach
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < nums.Length; i++)       // i it is index 
            //                                             // بتمسك ال array الاصليه 
            //                                            // ممكن اغير فيها فى قيم الا array 
            //{
            //    // nums[i] += 10; // valid
            //    if (nums[i] == 4)
            //    {
            //        //break;
            //        //continue;
            //    }
            //    Console.WriteLine(nums[i]);
            //}

            //foreach (int num in nums)                //  num it is element in array not index
            //                                         // ده بتمسك ال element نفسوا مش ال index زى ال for loop 
            //                                         // مش ممكن اغير فيها فى قيم ال array لانها مش شغاله على array  الاصليه
            //{
            //    //num += 10; // invsalid
            //    Console.WriteLine(num);   
            //}

            // for each >>>>مش بتشتغل الا لما يكون عندى  class implemnt interface IEnummrable  علشان هى بتاخد كوبى من ال array 
            //مش شغاله على array  الاصليه 

            #endregion

            #region do-while  while

            //int number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number ");
            //    //number = int.Parse(Console.ReadLine()); it is old becouse if enter string the o/p will be error (Formate Execption)
            //    //to solve it use Tryparse  it is return bool (True if can convert  or false if can not convert) 
            //    Flag = int.TryParse(Console.ReadLine(), out number); // tryparse take 2 parametr (what we want to convert , output paramter)
            //}
            //while (number % 2 ==1 || !Flag);
            //Console.WriteLine($"{number} is even");

            //int number = 3;
            //bool Flag = false;
            //while (number % 2 == 1 || !Flag)
            //{
            //    Console.WriteLine("Enter Even Number ");
            //    Flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //Console.WriteLine($"{number} is even");
            #endregion

            #endregion

            #region string
            //string name ;
            //name = new string("Ali");
            //string name = "Ali";

            // string have special case have loadstr if we have 2 string have the same value the 2 string it is only in string 
            // will have the same address
            //string num01 = "Ali";
            //string num02 = "Ali";
            //Console.WriteLine(num01.GetHashCode());
            //Console.WriteLine(num02.GetHashCode());

            //string is immutable can not change value becouse it is array of char it is  fixed size can not chane size  it is only in string 
            //string num01 = "Ali";
            //string num02 = "Ahmed";
            //Console.WriteLine(num01.GetHashCode());
            //Console.WriteLine(num02.GetHashCode());
            //num02 = num01;
            //Console.WriteLine(num01.GetHashCode());
            //Console.WriteLine(num02.GetHashCode());
            //num01 = "Nora";
            //Console.WriteLine(num01.GetHashCode());
            //Console.WriteLine(num02.GetHashCode());
            #endregion

            #region String-Builder
            //StringBuilder msg;
            //msg = new StringBuilder("hellow");
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            //msg.Append("mo");
            //Console.WriteLine(msg.GetHashCode());
            #endregion

            #region String-builder method
            //StringBuilder Msg = new StringBuilder("Mohamed");
            //Msg.Append(" Ramdan");
            //Console.WriteLine(Msg);
            //Msg.AppendLine(" Hany");
            //Console.WriteLine(Msg);
            //Msg.Remove(0, 3);
            //Console.WriteLine(Msg);
            //Msg.Insert(0, "MMM");
            //Console.WriteLine(Msg);
            //int Age = 10;
            //string name = "Ali";
            //Msg.AppendFormat("Age {0} : Name {1} ", name , Age);
            //Console.WriteLine(Msg);
            //Msg.AppendJoin("/", "Ali", "mostafa", 2);
            //Console.WriteLine(Msg);


            #endregion

            #region Array 1D
            //int[] number = new int[3]; // size of array = 3
            //int[] number = new int[3] { 1, 2, 3 };
            //int[] number = new int[] { 1, 2, 3 };
            //int[] number = { 1, 2, 3 };

            //int[] number = new int[3];
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine("Enter the array Number");
            //    number[i]= int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine($"array is {number[i]} ");
            //}
            //Console.WriteLine(number.Length);
            //Console.WriteLine(number.Rank);// tell me the type of array
            #endregion

            #region Array 2D
            //int[,] marks = new int[3, 5];
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Grades of Student [{i+1}]");
            //    for (int j = 0; j < marks.GetLength(1); /*j++*/)
            //    {
            //        bool Flag;
            //        Console.WriteLine($"Enter the Grade({j+1})");
            //        Flag = int.TryParse(Console.ReadLine(), out marks[i,j]);
            //        //if (Flag && marks[i,j]>=0)
            //        //{
            //        //    j++;
            //        //}
            //        j = Flag && marks[i, j]>=0 ? ++j : j ; // ternary operator
            //    }
            //}

            ////for (int i = 0; i < marks.GetLength(0); i++)
            ////{
            ////    Console.WriteLine($" Grades of Student [{i + 1}]");

            ////    for (int j = 0; j < marks.GetLength(1); j++)
            ////    {
            ////        Console.Write($"Grade [{j + 1})] : ");
            ////        Console.WriteLine(marks[i, j]);
            ////    }
            ////}

            //// we have second way to print 2D array

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine(marks[i / marks.GetLength(1), i % marks.GetLength(1)]);
            //}

            #endregion

            #region judged array
            //int[][] numbers = new int[3][];
            //numbers[0] =new int[3] {1,2,3};
            //numbers[1] =new int[2] {4,5};
            //numbers[2] =new int[1] {6};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0;  j < numbers[i].Length;  j++)
            //    {
            //        Console.WriteLine(numbers[i][j]);
            //    }
            //}
            #endregion
            #endregion

            #region Assignment

            #region Q1
            //int numbers;
            //bool Flag;
            //Console.Write("Enter The Number : ");
            //Flag = int.TryParse(Console.ReadLine(), out numbers);
            //while (!Flag || numbers < 0)
            //{
            //    Console.Write("Enter The Number : ");
            //    Flag = int.TryParse(Console.ReadLine(), out numbers);
            //}
            //Console.Write($"Numbers from 1 to {numbers} : ");
            //for (int i = 0; i < numbers; i++)
            //{
            //    Console.Write($" {i + 1}");
            //}
            #endregion

            #region Q2
            //Console.Write("Enter a Number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = num * i;
            //    Console.Write(result + " ");

            //}
            #endregion

            #region Q3
            //int numbers;
            //bool Flag;
            //Console.Write("Enter The Number : ");
            //Flag = int.TryParse(Console.ReadLine(), out numbers);
            //while (!Flag || numbers < 0)
            //{
            //    Console.Write("Enter The Number : ");
            //    Flag = int.TryParse(Console.ReadLine(), out numbers);
            //}
            //Console.Write($"Even Numbers Between 1 to {numbers} : ");
            //for (int i = 1; i <= numbers; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($" {i}");

            //    }
            //}
            #endregion

            #region Q4
            //Console.Write("Enter a Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter a power : ");
            //int power = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= num;
            //}
            //Console.WriteLine($"The result of {num}^{power} is: {result}");

            #endregion

            #region Q5
            //Console.Write("Enter the string : ");
            //string name = Console.ReadLine();
            //string reversed = " ";
            //for (int i = name.Length - 1 ; i >=0; i--)
            //{
            //    reversed += name[i];
            //}
            //Console.WriteLine($"Reversed string is : {reversed}");
            #endregion

            #region Q6
            //bool Falg1 = false;
            //bool Falg2 = false;
            //int start = 5;// for enter the while
            //int end = 1;// for enter the while
            //Console.WriteLine("Test Data : ");
            //while (start > end || !Falg1 || !Falg2 || start < 0 || end < 0)
            //{
            //    Console.Write("Input starting number of range: ");
            //    Falg1 = int.TryParse(Console.ReadLine(), out start);
            //    Console.Write("Input ending number of range : ");
            //    Falg2 = int.TryParse(Console.ReadLine(), out end);
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Expected Output :");
            //Console.Write($"Prime numbers between {start} and {end} is :  ");
            //for (int i = start; i <= end; i++)
            //{
            //    bool isPrime = true;
            //    if (i <= 1)
            //    {
            //        isPrime = false;
            //    }
            //    else
            //    {
            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region Q7
            //int numbers;
            //string binarynum = "";
            //Console.Write("Enter a number to convert : ");
            //while (!int.TryParse(Console.ReadLine(), out numbers) || numbers < 0)
            //{
            //    Console.Write("Enter a correct number to convert : ");
            //}
            //int num = numbers;
            //if (numbers == 0)
            //{
            //    binarynum = "0";
            //}
            //else 
            //{
            //    while (numbers > 0) 
            //    {
            //        binarynum = (numbers % 2) + binarynum;
            //        numbers /= 2;
            //    }
            //}
            //Console.WriteLine($"The Binary of {num} is : {binarynum}");
            #endregion

            #region Q8
            //Console.Write("Enter the size of the matrix (n): ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Enter the size postive correct of the matrix (n): ");
            //}
            //Console.WriteLine($"Identity matrix {n}x{n}:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine(); // Move to the next  row
            //}
            #endregion

            #region Q9
            //Console.Write("Enter the String : ");
            //String name = Console.ReadLine();
            //Console.Write("Enter the starting index for the substring : ");
            //int x; // start index
            //while (!int.TryParse(Console.ReadLine(), out x) || x < 0 || x >= name.Length)
            //{
            //    Console.Write("Please Enter the Valid starting index: ");
            //}
            //Console.Write("Enter the  lenght : ");
            //int y; // lenght of index
            //while (!int.TryParse(Console.ReadLine(), out y) || y < 0 || (x + y > name.Length))
            //{
            //    Console.Write("Please Enter the Valid Lenght index: ");
            //}
            //string substring = name.Substring(x, y);
            //Console.WriteLine($"The extracted substring is :{substring} ");
            #endregion

            #region Q10
            //Console.Write("Enter the First String : ");
            //String input01 = Console.ReadLine();
            //Console.Write("Enter the First String : ");
            //String input02 = Console.ReadLine();
            //string result = input01 + input02;
            //Console.Write($"The string combination is : {result }");
            #endregion

            #region Q11
            //Console.Write("Enter the size of the matrix (n): ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Enter the size postive correct of the matrix (n): ");
            //}
            //Console.WriteLine($"Identity matrix {n}x{n}:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine(); // Move to the next  row
            //}
            #endregion

            #region Q12
            //Console.Write("Enter the number of element in array = ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            //{
            //    Console.Write("Please enter a valid positive number for the array size: ");
            //}
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.Write($"The sum of all elements in the array is: {sum}");

            #endregion

            #region Q13
            //Console.Write("Enter the number of element in array = ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive number for the array size: ");
            //}
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];

            //Console.WriteLine("Enter elements for the first array : ");
            //for (int i = 0; i < n;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr1[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}
            //Console.WriteLine("Enter elements for the second array : ");
            //for (int i = 0; i < n;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr2[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}
            //int[] mergedArray = new int[n + n];// merge the two array
            //for (int i = 0; i < n; i++)
            //{
            //    mergedArray[i] = arr1[i];
            //    mergedArray[n + i] = arr2[i];
            //}
            //Array.Sort(mergedArray); // sort array asc

            //Console.Write("The merged array in ascending is : ");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.Write($"{mergedArray[i]} ");
            //}
            #endregion

            #region Q14
            //Console.Write("Enter the number of element in array = ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive number for the array size: ");
            //}
            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}
            //bool[] repeat = new bool[n];

            //for (int i = 0; i < n; i++)// intilize repeted array
            //{
            //    repeat[i] = false;
            //}
            //Console.WriteLine("Frequency of each element in the array:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (repeat[i])
            //    {
            //        continue;
            //    }
            //    int count = 1;
            //    for (int j = i+1; j <arr.Length ; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            repeat[j] = true;
            //        }
            //    }
            //    Console.WriteLine($"Element {arr[i+1]} repeated : {count} times");
            //}
            #endregion

            #region Q15
            //Console.Write("Enter the number of element in array = ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive number for the array size: ");
            //}
            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}
            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"The maximum element in the array is: {max}");
            //Console.WriteLine($"The minimum element in the array is: {min}");
            #endregion

            #region Q16
            //Console.Write("Enter the number of element in array = ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive number for the array size: ");
            //}
            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}

            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        Array.Sort(arr);
            //        Array.Reverse(arr);
            //    }
            //}

            //Console.WriteLine($"The second maximum element in the array is: {arr[1]}");
            #endregion

            #region Q17
            //Console.Write("Enter the number of element in array = ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive number for the array size: ");
            //}
            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}
            //int maxdistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = arr.Length - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int dist = j - i - 1;
            //            if (dist > maxdistance)
            //            {
            //                maxdistance = dist;
            //            }
            //            break; // stop loop if we find the longest  distnce
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance between two equal cells is: {maxdistance}");

            #endregion

            #region Q18
            //Console.Write("Enter the number of rows in array : ");
            //int rows;
            //while (!int.TryParse(Console.ReadLine(), out rows) || rows<=0)
            //{
            //    Console.Write("Enter the positive and valid number of rows: ");
            //}
            //Console.Write("Enter the number of columns in array : ");
            //int column;
            //while (!int.TryParse(Console.ReadLine(), out column) || column <= 0)
            //{
            //    Console.Write("Enter the positive and valid number of column : ");
            //}
            //int[,] arry01 = new int[rows, column];
            //int[,] arry02 = new int[rows, column];

            //Console.WriteLine("");
            //Console.WriteLine("Enter the elements of the first array ");
            //for (int i = 0; i < arry01.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter the rows {i + 1}");
            //    for (int j = 0; j < arry01.GetLength(1);)
            //    {
            //        bool Flag;
            //        Console.Write($"Enter the Element({j + 1}) :  ");
            //        Flag = int.TryParse(Console.ReadLine(), out arry01[i, j]);
            //        if (Flag && arry01[i, j] >= 0)
            //        {
            //            j++;
            //        }
            //    }
            //}

            //// copy to second array
            //for (int i = 0; i < arry01.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arry01.GetLength(1); j++)
            //    {
            //        arry02[i, j] = arry01[i, j];
            //    }
            //}

            //// print second array
            //Console.WriteLine("");
            //Console.WriteLine("The second multidimensional array after copying from the first array is : ");
            //for (int i = 0; i < arry02.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arry02.GetLength(1); j++)
            //    {
            //        Console.Write(arry02[i, j] + " ");
            //    }
            //    Console.WriteLine(" ");
            //}
            #endregion

            #region Q19
            //Console.Write("Enter the number of element in array = ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive number for the array size : ");
            //}
            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length;)
            //{
            //    bool Flag;
            //    Console.Write($"Element {i + 1}  : ");
            //    Flag = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (Flag)
            //    {
            //        i++;
            //    }
            //}
            //Console.Write("The array in reverse : ");
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            ////or using array method
            ////Array.Reverse(arr);
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.Write($"{arr[i]} ");
            ////}
            #endregion
            #endregion
        } 
    }
}
