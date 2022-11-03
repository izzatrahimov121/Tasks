#region Selection Sort
//int[] arr = { -333, 2, 9, -84, 4, 0 };
//int temp, min;
//for (int i = 0; i < arr.Length; i++)
//{
//    min = i; for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[j] < arr[min])
//        {
//            min = j;
//        }
//    }
//    if (min != i)
//    {
//        temp = arr[min];
//        arr[min] = arr[i];
//        arr[i] = temp;
//    }
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

#endregion

#region Bubble Sort
//int[] arr = { 4, 225, 5, 3, 0, -23, 13, 45 };
//int temp;
//for (int i = 0; i < arr.Length - 1; i++)
//{
//    for (int j = 0; j < arr.Length - 1; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//            temp = arr[j + 1];
//            arr[j + 1] = arr[j]; arr[j] = temp;

//        }
//    }
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
#endregion

#region Insertion Sort
//int[] arr = { 2, 4, 67, 23, -4, 0, -65 };
//int indexValue, j; 
//bool temp = false;
//for (int i = 1; i < arr.Length; i++)
//{
//    indexValue = arr[i];
//    temp = false;
//    j = i - 1;
//    while (j >= 0 && temp != true)
//    {
//        if (indexValue < arr[j])
//        {
//            arr[j + 1] = arr[j];
//            j--;
//            arr[j + 1] = indexValue;
//        }
//        else
//        {
//            temp = true;
//        }
//    }

//}
//for (int i = 0; i < arr.Length - 1; i++)
//{
//    Console.WriteLine(arr[i]);
//}
#endregion