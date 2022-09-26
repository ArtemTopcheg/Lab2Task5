//Task5
int[] nums = new int[5];
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    int iElement = Convert.ToInt32(Console.ReadLine());
    nums[i] = iElement;

    if (iElement < 0)
    {
        continue;
    }
    else
    {
        nums[count] = iElement;
        count++;

    }
}
Console.WriteLine("Итоговый массив");
for (int i = 0; i < count; i++)
{
    Console.Write(nums[i] + " ");
}