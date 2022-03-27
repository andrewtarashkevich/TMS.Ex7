using System;

namespace Ex._5 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1            
            int[] arr1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };            
            Console.WriteLine($"Количество четный = {GetAllSum(arr1)[1]}, кол-во нечетных = {GetAllSum(arr1)[0]}, кол-во нулей {GetAllSum(arr1)[2]}");

            
            //Задание 2            
            ChangeEveryThirdNumber(arr1);
            ShowArray(arr1);
                        
            //Задание 3            
            int[] arr2 = new int[] { 6, 7, 8, 9,7 };
            int[] arr_result = CombineArrays(arr1,arr2);
            ShowArray(arr_result);

            //Задание 4 Math.Ceiling((double)arr.Length/2)
            SwapHalfArray(arr2);
            ShowArray(arr2);
            
            //Задание 5
            int[] array = { 3, 5, 7, 9, 11, 13 };            
            int[] arraynew = ShiftArray(array);
            ShowArray(arraynew);
                       
            //Задание 6
            ChangeEvenAndOdd(array);
            ShowArray(array);

            //Задание 8
            SortByInsert(arr1);
            ShowArray(arr1);

            //Задание 9
            SortBySelect(arr2);
            SortBySelect(arr2);

            static void ShowArray(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i]+" ");
                }
                Console.WriteLine();
            }
            static int[] GetAllSum(int[] arr1)
            {
                int sum_odd1 = 0;
                int sum_even1 = 0;
                int sum_null1 = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (i == 0) sum_null1 += 1;
                    else if (i % 2 == 0) sum_even1 += 1;
                    else sum_odd1 += 1;
                }
                return new int[] { sum_odd1,sum_even1,sum_null1};
            }
            static void ChangeEveryThirdNumber(int[] arr)
            {                
                for (int i = 2; i < arr.Length; i += 3)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }                
            }
            static int[] CombineArrays(int[] arr1, int[] arr2)
            {
                int[] arr_result = new int[arr1.Length + arr2.Length];
                for (int j = 0, i = 0; j < arr1.Length; j++, i++)
                {
                    arr_result[i] = arr1[j];
                }

                for (int j = 0, i = arr1.Length; j < arr2.Length; j++, i++)
                {
                    arr_result[i] = arr2[j];
                }
                return arr_result;
            }
            static void SwapHalfArray(int[] arr)
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    int temp = arr[i];
                    arr[i] = arr[(int)Math.Ceiling((double)arr.Length / 2) + i];
                    arr[(int)Math.Ceiling((double)arr.Length / 2) + i] = temp;
                }
            }
            static int[] ShiftArray(int[] array)
            {
                int k = 3;
                int[] arraynew = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    arraynew[(i + k) % arraynew.Length] = array[i];
                }
                return arraynew;
            }
            static void ChangeEvenAndOdd(int[] arr)
            {
                for (int i = 1; i < arr.Length; i += 2)
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
            }
            static void SortByInsert(int[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                    for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
            }
            static void SortBySelect(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j].CompareTo(arr[min]) < 0)
                        {
                            min = j;
                        }
                    }

                    var temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }        
        }
    }
}
