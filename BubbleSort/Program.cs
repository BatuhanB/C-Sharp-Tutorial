using BubbleSort;

var myBubble = new MyBubbleSort();

int[] nums = { 1, 3, 5, 2, 6, 85, 23, 12 };
myBubble.Sort(nums);

foreach (int i in nums)
{
    Console.WriteLine(i);
}