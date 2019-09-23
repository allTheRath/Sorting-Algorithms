using System;

namespace SortingAlgorithm
{
    public class Sorting
    {



        public static int[] MergeTwoSortedArray(int[] array1, int[] array2)
        {
            if (array1.Length == 0)
            {
                return array2;
            }
            if (array2.Length == 0)
            {
                return array1;
            }
            int[] returning = new int[array1.Length + array2.Length];
            int tempValArray1 = array1[0];
            int tempArray1Counter = 0;
            int tempValArray2 = array2[0];
            int tempArray2Counter = 0;
            for (int i = 0; i < returning.Length; i++)
            {
                if (((tempValArray1 < tempValArray2) && tempValArray1 != Int32.MinValue) || tempValArray2 == Int32.MinValue)
                {
                    returning[i] = tempValArray1;
                    tempArray1Counter++;
                    if (tempArray1Counter >= array1.Length)
                    {

                        tempValArray1 = Int32.MinValue;
                    }
                    else
                    {
                        tempValArray1 = array1[tempArray1Counter];
                    }
                }
                else if (((tempValArray2 <= tempValArray1) && tempValArray2 != Int32.MinValue) || tempValArray1 == Int32.MinValue)
                {
                    returning[i] = tempValArray2;
                    tempArray2Counter++;
                    if (tempArray2Counter >= array2.Length)
                    {
                        tempValArray2 = Int32.MinValue;
                    }
                    else
                    {
                        tempValArray2 = array2[tempArray2Counter];
                    }
                }
            }

            return returning;
        }

        public static float[] MergeTwoSortedArray(float[] array1, float[] array2)
        {
            if (array1.Length == 0)
            {
                return array2;
            }
            if (array2.Length == 0)
            {
                return array1;
            }
            float[] returning = new float[array1.Length + array2.Length];
            float tempValArray1 = array1[0];
            int tempArray1Counter = 0;
            float tempValArray2 = array2[0];
            int tempArray2Counter = 0;
            for (int i = 0; i < returning.Length; i++)
            {
                if (((tempValArray1 < tempValArray2) && tempValArray1 != float.MinValue) || tempValArray2 == float.MinValue)
                {
                    returning[i] = tempValArray1;
                    tempArray1Counter++;
                    if (tempArray1Counter >= array1.Length)
                    {

                        tempValArray1 = float.MinValue;
                    }
                    else
                    {
                        tempValArray1 = array1[tempArray1Counter];
                    }
                }
                else if (((tempValArray2 <= tempValArray1) && tempValArray2 != float.MinValue) || tempValArray1 == float.MinValue)
                {
                    returning[i] = tempValArray2;
                    tempArray2Counter++;
                    if (tempArray2Counter >= array2.Length)
                    {
                        tempValArray2 = float.MinValue;
                    }
                    else
                    {
                        tempValArray2 = array2[tempArray2Counter];
                    }
                }
            }

            return returning;
        }


        public static double[] MergeTwoSortedArray(double[] array1, double[] array2)
        {
            if (array1.Length == 0)
            {
                return array2;
            }
            if (array2.Length == 0)
            {
                return array1;
            }
            double[] returning = new double[array1.Length + array2.Length];
            double tempValArray1 = array1[0];
            int tempArray1Counter = 0;
            double tempValArray2 = array2[0];
            int tempArray2Counter = 0;
            for (int i = 0; i < returning.Length; i++)
            {
                if (((tempValArray1 < tempValArray2) && tempValArray1 != Int32.MinValue) || tempValArray2 == Int32.MinValue)
                {
                    returning[i] = tempValArray1;
                    tempArray1Counter++;
                    if (tempArray1Counter >= array1.Length)
                    {

                        tempValArray1 = Int32.MinValue;
                    }
                    else
                    {
                        tempValArray1 = array1[tempArray1Counter];
                    }
                }
                else if (((tempValArray2 <= tempValArray1) && tempValArray2 != Int32.MinValue) || tempValArray1 == Int32.MinValue)
                {
                    returning[i] = tempValArray2;
                    tempArray2Counter++;
                    if (tempArray2Counter >= array2.Length)
                    {
                        tempValArray2 = Int32.MinValue;
                    }
                    else
                    {
                        tempValArray2 = array2[tempArray2Counter];
                    }
                }
            }

            return returning;
        }


        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void swapDouble(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void swapFloat(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }

        public static void QuickSort(ref int[] array, int start, int end)
        {
            //end position should be the last index of element.
            if (start >= end)
            {
                return;
            }
            int counter = 0;
            int pivot = array[end];

            for (int i = 1; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    counter++;
                    swap(ref array[i], ref array[counter]);
                }
            }
            counter++;
            swap(ref array[counter], ref array[end]);

            if (counter == end - start)
            {
                return;
            }
            QuickSort(ref array, start, counter - 1);
            QuickSort(ref array, counter, end);
        }

        public static void QuickSort(ref double[] array, int start, int end)
        {
            //end position should be the last index of element.
            if (start >= end)
            {
                return;
            }
            int counter = 0;
            double pivot = array[end];

            for (int i = 1; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    counter++;
                    swapDouble(ref array[i], ref array[counter]);
                }
            }
            counter++;
            swapDouble(ref array[counter], ref array[end]);

            if (counter == end - start)
            {
                return;
            }
            QuickSort(ref array, start, counter - 1);
            QuickSort(ref array, counter, end);
        }

        public static void QuickSort(ref float[] array, int start, int end)
        {
            //end position should be the last index of element.
            if (start >= end)
            {
                return;
            }
            int counter = 0;
            float pivot = array[end];

            for (int i = 1; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    counter++;
                    swapFloat(ref array[i], ref array[counter]);
                }
            }
            counter++;
            swapFloat(ref array[counter], ref array[end]);

            if (counter == end - start)
            {
                return;
            }
            QuickSort(ref array, start, counter - 1);
            QuickSort(ref array, counter, end);
        }



        public static void BubbleSort(ref int[] array, int start, int end)
        {

            bool flag = false;
            for (int i = start; i < end - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    flag = true;
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            if (flag == false) { goto BreckCondition; }
            BubbleSort(ref array, start, end);

        BreckCondition:
            return;
        }

        public static void BubbleSort(ref double[] array, int start, int end)
        {

            bool flag = false;
            for (int i = start; i < end - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    flag = true;
                    double temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            if (flag == false) { goto BreckCondition; }
            BubbleSort(ref array, start, end);

        BreckCondition:
            return;
        }

        public static void BubbleSort(ref float[] array, int start, int end)
        {

            bool flag = false;
            for (int i = start; i < end - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    flag = true;
                    float temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            if (flag == false) { goto BreckCondition; }
            BubbleSort(ref array, start, end);

        BreckCondition:
            return;
        }

        public static void SelectionSort(ref int[] array)
        {
            if (array == null || array.Length == 1)
            {
                return;
            }

            int sortedPointer = array.Length;
            int currentMax = Int32.MinValue;
            int currentMaxPointer = Int32.MinValue;
            int breckPointer = array.Length;
            while (breckPointer > 0)
            {
                for (int i = 0; i < sortedPointer; i++)
                {
                    if (array[i] >= currentMax)
                    {
                        currentMax = array[i];
                        currentMaxPointer = i;
                    }
                }
                sortedPointer--;
                int tempInt = array[sortedPointer];
                array[sortedPointer] = currentMax;
                currentMax = Int32.MinValue;
                array[currentMaxPointer] = tempInt;
                breckPointer--;
            }

        }

        public static void SelectionSort(ref double[] array)
        {
            if (array == null || array.Length == 1)
            {
                return;
            }

            int sortedPointer = array.Length;
            double currentMax = double.MinValue;
            int currentMaxPointer = -1;
            int breckPointer = array.Length;
            while (breckPointer > 0)
            {
                for (int i = 0; i < sortedPointer; i++)
                {
                    if (array[i] >= currentMax)
                    {
                        currentMax = array[i];
                        currentMaxPointer = i;
                    }
                }
                sortedPointer--;
                double tempDouble = array[sortedPointer];
                array[sortedPointer] = currentMax;
                currentMax = double.MinValue;
                array[currentMaxPointer] = tempDouble;
                breckPointer--;
            }

        }

        public static void SelectionSort(ref float[] array)
        {
            if (array == null || array.Length == 1)
            {
                return;
            }

            int sortedPointer = array.Length;
            float currentMax = float.MinValue;
            int currentMaxPointer = -1;
            int breckPointer = array.Length;
            while (breckPointer > 0)
            {
                for (int i = 0; i < sortedPointer; i++)
                {
                    if (array[i] >= currentMax)
                    {
                        currentMax = array[i];
                        currentMaxPointer = i;
                    }
                }
                sortedPointer--;
                float tempfloat = array[sortedPointer];
                array[sortedPointer] = currentMax;
                currentMax = float.MinValue;
                array[currentMaxPointer] = tempfloat;
                breckPointer--;
            }

        }




        public static void HeapSort(ref int[] array)
        {
            int length = array.Length;
        MaxHeap:
            bool change = false;
            for (int i = 0; i < length / 2; i++)
            {
                if (i * 2 + 1 < length && array[i] < array[i * 2 + 1])
                {
                    change = true;
                    swap(ref array[i], ref array[i * 2 + 1]);
                }
                if (i * 2 + 2 < length && array[i] < array[i * 2 + 2])
                {
                    change = true; // Once all values are at right position to breck the loop..
                    swap(ref array[i], ref array[i * 2 + 2]);
                }
            }
            if (change == true)
            {
                goto MaxHeap;
            }
            swap(ref array[0], ref array[length - 1]); // first element is now max values as it is a max tree.
            length--;
            if (length > 1)
            {
                goto MaxHeap;
            }

        }

        public static void HeapSort(ref double[] array)
        {
            int length = array.Length;
        MaxHeap:
            bool change = false;
            for (int i = 0; i < length / 2; i++)
            {
                if (i * 2 + 1 < length && array[i] < array[i * 2 + 1])
                {
                    change = true;
                    swapDouble(ref array[i], ref array[i * 2 + 1]);
                }
                if (i * 2 + 2 < length && array[i] < array[i * 2 + 2])
                {
                    change = true; // Once all values are at right position to breck the loop..
                    swapDouble(ref array[i], ref array[i * 2 + 2]);
                }
            }
            if (change == true)
            {
                goto MaxHeap;
            }
            swapDouble(ref array[0], ref array[length - 1]); // first element is now max values as it is a max tree.
            length--;
            if (length > 1)
            {
                goto MaxHeap;
            }

        }

        public static void HeapSort(ref float[] array)
        {
            int length = array.Length;
        MaxHeap:
            bool change = false;
            for (int i = 0; i < length / 2; i++)
            {
                if (i * 2 + 1 < length && array[i] < array[i * 2 + 1])
                {
                    change = true;
                    swapFloat(ref array[i], ref array[i * 2 + 1]);
                }
                if (i * 2 + 2 < length && array[i] < array[i * 2 + 2])
                {
                    change = true; // Once all values are at right position to breck the loop..
                    swapFloat(ref array[i], ref array[i * 2 + 2]);
                }
            }
            if (change == true)
            {
                goto MaxHeap;
            }
            swapFloat(ref array[0], ref array[length - 1]); // first element is now max values as it is a max tree.
            length--;
            if (length > 1)
            {
                goto MaxHeap;
            }

        }


        public static void CountingSort(ref int[] array)
        {
            int[] indexArray = new int[int.MaxValue / 100];
            int maxVal = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxVal < array[i])
                {
                    maxVal = array[i];
                }
                indexArray[array[i]] = indexArray[array[i]] + 1;
            }
            int j = 0, k = 0;
            maxVal++;
            while (j != maxVal)
            {
                for (int p = indexArray[j]; p > 0; p--)
                {
                    array[k] = j;
                    k++;
                }

                j++;
            }

        }


        public static void MergeSort(ref int[] array)
        {
            int arrayLength = array.Length;
            int loopLength = 0;
            if (arrayLength % 2 == 0)
            {
                loopLength = arrayLength;
            }
            else
            {
                loopLength = arrayLength - 1;
            }

            for (int i = 0; i < loopLength; i += 2)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            int incrementor = 2;
        MergingArrays:

            for (int i = 0; i < loopLength; i += incrementor * 2)
            {
                int arrayPtr = i;
                int[] array1 = new int[incrementor];

                if (arrayPtr + incrementor < arrayLength)
                {
                    Array.Copy(array, arrayPtr, array1, 0, incrementor);
                }
                arrayPtr += incrementor;
                if (arrayPtr + incrementor <= arrayLength)
                {
                    int[] array2 = new int[incrementor];
                    Array.Copy(array, arrayPtr, array2, 0, incrementor);
                    int[] sortedArr = MergeTwoSortedArray(array1, array2);
                    Array.Copy(sortedArr, 0, array, i, sortedArr.Length);
                }
                else if (arrayLength - arrayPtr > 0)
                {
                    int[] array2 = new int[arrayLength - incrementor];
                    Array.Copy(array, arrayPtr, array2, 0, array2.Length);
                    int[] sortedArr = MergeTwoSortedArray(array1, array2);
                    Array.Copy(sortedArr, 0, array, i, sortedArr.Length);
                }
            }
            incrementor *= 2;
            if (incrementor < arrayLength)
            {
                goto MergingArrays;
            }
        }

        public static void MergeSort(ref double[] array)
        {
            int arrayLength = array.Length;
            int loopLength = 0;
            if (arrayLength % 2 == 0)
            {
                loopLength = arrayLength;
            }
            else
            {
                loopLength = arrayLength - 1;
            }

            for (int i = 0; i < loopLength; i += 2)
            {
                if (array[i] > array[i + 1])
                {
                    double temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            int incrementor = 2;
        MergingArrays:

            for (int i = 0; i < loopLength; i += incrementor * 2)
            {
                int arrayPtr = i;
                double[] array1 = new double[incrementor];

                if (arrayPtr + incrementor < arrayLength)
                {
                    Array.Copy(array, arrayPtr, array1, 0, incrementor);
                }
                arrayPtr += incrementor;
                if (arrayPtr + incrementor <= arrayLength)
                {
                    double[] array2 = new double[incrementor];
                    Array.Copy(array, arrayPtr, array2, 0, incrementor);
                    double[] sortedArr = MergeTwoSortedArray(array1, array2);
                    Array.Copy(sortedArr, 0, array, i, sortedArr.Length);
                }
                else if (arrayLength - arrayPtr > 0)
                {
                    double[] array2 = new double[arrayLength - incrementor];
                    Array.Copy(array, arrayPtr, array2, 0, array2.Length);
                    double[] sortedArr = MergeTwoSortedArray(array1, array2);
                    Array.Copy(sortedArr, 0, array, i, sortedArr.Length);
                }
            }
            incrementor *= 2;
            if (incrementor < arrayLength)
            {
                goto MergingArrays;
            }
        }

        public static void MergeSort(ref float[] array)
        {
            int arrayLength = array.Length;
            int loopLength = 0;
            if (arrayLength % 2 == 0)
            {
                loopLength = arrayLength;
            }
            else
            {
                loopLength = arrayLength - 1;
            }

            for (int i = 0; i < loopLength; i += 2)
            {
                if (array[i] > array[i + 1])
                {
                    float temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            int incrementor = 2;
        MergingArrays:

            for (int i = 0; i < loopLength; i += incrementor * 2)
            {
                int arrayPtr = i;
                float[] array1 = new float[incrementor];

                if (arrayPtr + incrementor < arrayLength)
                {
                    Array.Copy(array, arrayPtr, array1, 0, incrementor);
                }
                arrayPtr += incrementor;
                if (arrayPtr + incrementor <= arrayLength)
                {
                    float[] array2 = new float[incrementor];
                    Array.Copy(array, arrayPtr, array2, 0, incrementor);
                    float[] sortedArr = MergeTwoSortedArray(array1, array2);
                    Array.Copy(sortedArr, 0, array, i, sortedArr.Length);
                }
                else if (arrayLength - arrayPtr > 0)
                {
                    float[] array2 = new float[arrayLength - incrementor];
                    Array.Copy(array, arrayPtr, array2, 0, array2.Length);
                    float[] sortedArr = MergeTwoSortedArray(array1, array2);
                    Array.Copy(sortedArr, 0, array, i, sortedArr.Length);
                }
            }
            incrementor *= 2;
            if (incrementor < arrayLength)
            {
                goto MergingArrays;
            }
        }

        public static void ShellSort(ref float[] array)
        {
            // In shell sort you dicide a gap and check all element from current and current + gap and sort them.
            // again reducing a gap size and do the same thing untill gap is one. then you apply insertion sort.
            // worst case it is On2 while average case it depends on the gap size..
            // Knuth formula is of taking a gap of h=h*3+1 // so h = h-1/3 h should be length at begining..
            int h = array.Length;

            if (array.Length % 2 == 0)
            {
                h = (h - 3) / 2;
            }
            else
            {
                h = h / 2;
            }
            while (h > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + h < array.Length && array[i] > array[i + h])
                    {
                        swapFloat(ref array[i], ref array[i + h]);
                    }
                }
                h = (h - 1) / 3;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    int backTracePt = i - 1;
                    int currentPt = i;
                    while (backTracePt > 0)
                    {
                        if (array[currentPt] <= array[backTracePt])
                        {
                            swapFloat(ref array[currentPt], ref array[backTracePt]);
                            currentPt = backTracePt;
                            backTracePt--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            // insertion sort..
        }

        public static void ShellSort(ref double[] array)
        {
            // In shell sort you dicide a gap and check all element from current and current + gap and sort them.
            // again reducing a gap size and do the same thing untill gap is one. then you apply insertion sort.
            // worst case it is On2 while average case it depends on the gap size..
            // Knuth formula is of taking a gap of h=h*3+1 // so h = h-1/3 h should be length at begining..
            int h = array.Length;

            if (array.Length % 2 == 0)
            {
                h = (h - 3) / 2;
            }
            else
            {
                h = h / 2;
            }
            while (h > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + h < array.Length && array[i] > array[i + h])
                    {
                        swapDouble(ref array[i], ref array[i + h]);
                    }
                }
                h = (h - 1) / 3;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    int backTracePt = i - 1;
                    int currentPt = i;
                    while (backTracePt > 0)
                    {
                        if (array[currentPt] <= array[backTracePt])
                        {
                            swapDouble(ref array[currentPt], ref array[backTracePt]);
                            currentPt = backTracePt;
                            backTracePt--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            // insertion sort..
        }


        public static void ShellSort(ref int[] array)
        {
            // In shell sort you dicide a gap and check all element from current and current + gap and sort them.
            // again reducing a gap size and do the same thing untill gap is one. then you apply insertion sort.
            // worst case it is On2 while average case it depends on the gap size..
            // Knuth formula is of taking a gap of h=h*3+1 // so h = h-1/3 h should be length at begining..
            int h = array.Length;

            if (array.Length % 2 == 0)
            {
                h = (h - 3) / 2;
            }
            else
            {
                h = h / 2;
            }
            while (h > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + h < array.Length && array[i] > array[i + h])
                    {
                        swap(ref array[i], ref array[i + h]);
                    }
                }
                h = (h - 1) / 3;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    int backTracePt = i - 1;
                    int currentPt = i;
                    while (backTracePt > 0)
                    {
                        if (array[currentPt] <= array[backTracePt])
                        {
                            swap(ref array[currentPt], ref array[backTracePt]);
                            currentPt = backTracePt;
                            backTracePt--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            // insertion sort..

        }


        public static void shiftArray(ref int[] array, int start, int end)
        {
            int currentval = array[start];
            if (end - start == 1)
            {
                array[end] = array[start];
                return;
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    int temp = array[i];
                    array[i] = currentval;
                    currentval = temp;
                }
                array[end] = currentval;
            }

        }


        public static void shiftArray(ref float[] array, int start, int end)
        {
            float currentval = array[start];
            if (end - start == 1)
            {
                array[end] = array[start];
                return;
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    float temp = array[i];
                    array[i] = currentval;
                    currentval = temp;
                }
                array[end] = currentval;
            }

        }


        public static void shiftArray(ref double[] array, int start, int end)
        {
            double currentval = array[start];
            if (end - start == 1)
            {
                array[end] = array[start];
                return;
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    double temp = array[i];
                    array[i] = currentval;
                    currentval = temp;
                }
                array[end] = currentval;
            }

        }

        public static void InsertionSort(ref int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = i;
                    while (temp > 0)
                    {

                        // check for correct position..
                        if (array[temp] >= array[i] && array[temp - 1] < array[i])
                        {
                            int valueToPut = array[i];
                            //value should be put to temp position and array should be shifted to right from temp till i..
                            shiftArray(ref array, temp, i);
                            array[temp] = valueToPut;
                            break;
                        }
                        temp--;
                    }

                }
            }

        }

        public static void InsertionSort(ref float[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = i;
                    while (temp > 0)
                    {

                        // check for correct position..
                        if (array[temp] >= array[i] && array[temp - 1] < array[i])
                        {
                            float valueToPut = array[i];
                            //value should be put to temp position and array should be shifted to right from temp till i..
                            shiftArray(ref array, temp, i);
                            array[temp] = valueToPut;
                            break;
                        }
                        temp--;
                    }

                }
            }

        }

        public static void InsertionSort(ref double[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = i;
                    while (temp > 0)
                    {

                        // check for correct position..
                        if (array[temp] >= array[i] && array[temp - 1] < array[i])
                        {
                            double valueToPut = array[i];
                            //value should be put to temp position and array should be shifted to right from temp till i..
                            shiftArray(ref array, temp, i);
                            array[temp] = valueToPut;
                            break;
                        }
                        temp--;
                    }

                }
            }

        }
    }
}
