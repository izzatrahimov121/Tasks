int[] arr = { 2, 3, 342, 6645, 63, 4325, 34, 9 };
int num;

for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            num = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = num;
        }
    }
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}