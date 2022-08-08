using System;
using System.Threading;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //211-arithmeitc overage of positive elements.

            //int x = 0;
            //int sum = 0;
            //Console.Write("Enter length of the array:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Your {i + 1} number of the array:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        sum += arr[i];
            //        ++x;
            //    }

            //}

            //Console.WriteLine((double)sum/x);


            //213-Print the geometric mean of the negative elements.


            //int x = 0;
            //int product = 1;
            //Console.Write("Enter length of the array:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Your {i + 1} number of the array:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        product *= arr[i];
            //        ++x;
            //    }

            //}

            //if(x%2==1)
            //Console.WriteLine(Math.Pow(-product,(double)1/x));
            //else
            //    Console.WriteLine(Math.Pow(product, (double)1 / x));



            //218-Print sum of absolute values ​​of elements with odd index.


            //int sum = 0;
            //Console.Write("Enter Length of the array:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter your {i + 1} number:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    if ((i + 1) % 2 == 1)
            //        sum +=Math.Abs(arr[i]);
            //}


            //Console.WriteLine("\n\n"+sum);


            //251-print the greatest number of the array

            //int max = int.MinValue;
            //Console.Write("Enter array length:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter your {i + 1} number:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] > max)
            //   max=arr[i];
            //}
            //Console.WriteLine("\n\n"+max);




            //257-index of the first Greatest number of the array.

            //int index = 0;
            //int max = int.MinValue;
            //Console.Write("Enter array length:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter your {i + 1} number:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        index = i + 1;
            //    }

            //}

            //Console.WriteLine("\n\n"+index);


            //261- 


            //int sum = 0;
            //Console.Write("Enter Array Length: ");
            //int n=Convert.ToInt32(Console.ReadLine());

            //int[] X=new int[n];
            //int[] Y=new int[n];

            //Console.WriteLine("\n"); 

            //for(int i=0; i<n; i++)
            //{
            //    Console.Write($"Enter X {i+1} number: ");
            //    X[i]=Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("\n\n");


            //for(int i=0; i<n; i++)
            //{
            //    Console.Write($"Enter Y {i + 1} number: ");
            //    Y[i]=Convert.ToInt32(Console.ReadLine());
            //}

            //for(int i = 0; i < n; i++)
            //{
            //    sum=sum+X[i]+Y[i];
            //}

            //Console.WriteLine("\n\n");
            //Console.WriteLine((double)sum/n);



            //263- positive array number quantity



            //int quantity = 0;
            //Console.Write("Enter Array Length: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] X = new int[n];
            //int[] Y = new int[n];

            //Console.WriteLine("\n");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter X {i + 1} number: ");
            //    X[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("\n\n");


            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter Y {i + 1} number: ");
            //    Y[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < n; i++)
            //{

            //    if (X[i] > 0)
            //        quantity += 1;
            //    if(Y[i] > 0)
            //        quantity += 1;

            //}

            //Console.WriteLine(quantity);



            //392- array elements reverse.


            //int reverse;
            //Console.Write("Enter your Array Length: ");
            //int n=Convert.ToInt32(Console.ReadLine());
            //int[] arr=new int[n];

            //Console.WriteLine();
            //for(int i=0; i<n; i++)
            //{
            //    Console.Write($"Enter Array {i+1} number: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //for (int i = 0; i < n/2; i++)
            //{
            //    reverse = arr[i];
            //    arr[i] = arr[n-1-i];
            //    arr[n-1-i] = reverse;

            //}

            //Console.WriteLine("\n\n");

            //for(int i=0;i<n; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    Thread.Sleep(50);
            //}



            //395- Delete first positive element of array.

            //Console.Write("Enter your array Length: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr=new int[n];

            //Console.WriteLine();
            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter array {i+1} number: ");
            //    arr[i]=Convert.ToInt32(Console.ReadLine());

            //}

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
                     
            //        break;
            //    }
            //}



        }
    }
}
