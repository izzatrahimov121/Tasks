#region Linear Search
//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//int value = 55;
//bool status = false;
//for (int i = 0; i < arr.Length; i++)
//{
//	if (value == arr[i])
//	{
//		Console.WriteLine(i);
//		status = true;
//		break;
//	}
//}
//if (!status)
//	Console.WriteLine("-1");
#endregion

#region Binary Search
//int[] arr = { 1, 2, 3, 4, 5, 6 };
//int max = arr.Length-1, min = 0;
//int mid=0, value = 3;
//bool status=true;
//while (true)
//{
//    mid=(max+min)/2;
//	if (value == arr[mid])
//	{
//		Console.WriteLine(mid);
//		status=false;
//		break;
//	}
//	if(value < arr[mid])
//	{
//        max = mid - 1;
//    }
//	else
//	{ 
//        min = mid + 1;
//    }
//}
//if (status)
//{
//	Console.WriteLine("-1");
//}
#endregion

#region Jump Search
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int jump = (int)Math.Sqrt(arr.Length);
//bool status = true;
//int value = 100;
//while (jump <= arr.Length - 1)
//{
//    if (arr[jump] == value)
//    {
//        Console.WriteLine(jump);
//        status = false;
//        break;
//    }
//    if (arr[jump] < value)
//    {
//        if (jump + (int)Math.Sqrt(arr.Length) <= arr.Length - 1)
//        {
//            jump += (int)Math.Sqrt(arr.Length);
//        }
//        else
//        {
//            jump++;
//        }

//    }
//    if (arr[jump] > value)
//    {
//        jump -= 1;
//    }
//    if (jump == arr.Length-1 && status)
//    {
//        Console.WriteLine("-1");
//        break;
//    }
//}
#endregion

#region Interpolation Search

#endregion