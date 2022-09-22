using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_sep_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jagged array

            //int[][] jaggarr = new int[3][];

            //jaggarr[0] = new int[] { 1,2,3,4,5}; //oth row
            //jaggarr[1] = new int[] { 1, 2, 3 }; // 1st row
            //jaggarr[2] = new int[] { 1, 2, 3, 4 }; //2nd row

            ////Console.WriteLine(jaggarr.Length);

            //for(int i = 0;i < jaggarr.Length; i++)
            //{
            //    for(int j = 0; j < jaggarr[i].Length; j++)
            //    {
            //        Console.Write(jaggarr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Course[] courses =
            //{
            //    new Course{Id = 1, Name = "Data_Science", Fees = 10000 },
            //    new Course{Id = 2, Name = "Full_Stack_Developer", Fees = 12000 },
            //    new Course{Id = 3, Name = "Data_Analyst", Fees = 10000 }

            //};

            //foreach( var p in courses)
            //{
            //    Console.WriteLine(p);
            //}

            //Department[] dept =
            //{
            //    new Department{ Id = 1, Name = "Computer", Location = "Block-I"},
            //    new Department{ Id = 2, Name = "Architecture", Location = "Block-II"},
            //    new Department{ Id = 3, Name = "Biotechnology", Location = "Block-III"}
            //};

            //foreach (var d in dept)
            //{
            //    Console.WriteLine(d);
            //}



            // Maximum number from array

            //int[] arr1 = new int[10] { 4, 6, 3, 5, 7, 8, 11, 32, 12, 10 };
            //Array.Sort(arr1);
            ////Console.WriteLine(arr1.Length);
            //int max_e = arr1[arr1.Length - 1];
            //Console.WriteLine("Max element fron araray is " + max_e);



            //Mininum number
            //int[] arr2 = new int[10] { 4, 6, 3, 5, 17, 8, 11, 32, 12, 10 };
            //Array.Sort(arr2);
            ////Console.WriteLine(arr1.Length);
            //int min_e = arr2[0];
            //Console.WriteLine("Min element from array is " + min_e);



            // duplicate numbers in array
            //int[] arr3 = new int[6] { 2, 5, 6, 2, 6, 7 };

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    for(int j = i + 1; j < arr3.Length; j++)
            //    {
            //        if (arr3[i] == arr3[j])
            //        {
            //            Console.Write(arr3[i] + " ");
            //            break;
            //        }
            //    }
            //}




            // Remove a given element from an array

            //int[] arr4 = new int[6] { 45, 23, 67, 34, 77, 78 };
            //int element = 67;
            //int index = Array.IndexOf(arr4, element);

            ////Shifting elements

            //for(int i = index;i < arr4.Length - 1; i++)
            //{
            //    arr4[i] = arr4[i + 1]; 
            //}

            //// displaying 
            //for(int j = 0; j < arr4.Length - 1; j++)
            //{
            //    Console.WriteLine(arr4[j]);
            //}


            // Find subarray with required sum.

            //int[] arr5 = new int[6] { 12, 4, 2, 10, 5, 1 };
            //int currentsum, i, j, k;
            //int sum = 16;
            //for(i = 0;i< arr5.Length; i++)
            //{
            //    currentsum = arr5[i];
            //    for(j = i + 1;j <= arr5.Length; j++)
            //    {
            //        if( currentsum == sum)
            //        {
            //            Console.WriteLine($"Sum found between indexes {i} and {j - 1}");
            //            Console.WriteLine("Print the required subarray--");
            //            for( k = i;  k <= j - 1; k++)
            //            {
            //                Console.WriteLine(arr5[k]);
            //            }

            //        }

            //        if(currentsum > sum || j == arr5.Length)
            //        {
            //            break;
            //        }
            //        currentsum = currentsum + arr5[j];
            //    }

            //}







            //  Divide array in two parts and reverse the two parts. e.g. if array is { 1,2,3,4,5,6,} result should be { 4,5,6, 1,2,3}

            //int[] arr6 = new int[6] { 12, 4, 13, 10, 5, 1 };
            //int mid = (arr6.Length) / 2;
            //int[] firsthalf = arr6.Take(mid).ToArray();
            //int[] secondhalf = arr6.Skip(mid).ToArray();

            //Array.Reverse(firsthalf);
            //Array.Reverse(secondhalf);

            //Console.Write(String.Join(", ", firsthalf));
            //Console.Write(", ");
            //Console.WriteLine(String.Join(", ", secondhalf));




            // Find maximum number from each row of two dimensional array with dimensions ( 3 x 4)

            //int[,] arr7 = new int[3, 4]
            //{
            //    {1,2,3,4 },
            //    {5,6,8,7 },
            //    {9,10,11,12 }
            //};

            //int[] one_d_arr  = new int[arr7.GetLength(1)];
            ////Console.WriteLine(arr7.Length);

            //for (int i = 0; i < arr7.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr7.GetLength(1); j++)
            //    {
            //        one_d_arr[j] = arr7 [i,j];

            //    }
            //    Console.WriteLine(one_d_arr.Max());

            //}






            // Find the minimum number from a two dimensional array .

            //int[,] arr8 = new int[3, 4]
            //{
            //    {10,223,33,4 },
            //    {5,6,8,16 },
            //    {9,10,3,12 }
            //};

            //int c = 0;

            //int[] store = new int[arr8.Length];
            //for (int i = 0; i < arr8.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr8.GetLength(1); j++)
            //    {
            //        store[c] = arr8[i, j];
            //        c++;
            //    }
            //}
            //Console.WriteLine(store.Min());
















        }
    }
}
