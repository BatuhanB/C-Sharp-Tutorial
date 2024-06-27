//var arr = new DataStructers.Array.Array("2", "3", "4", "Test");

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

var arrList = new DataStructers.Array.ArrayList();
for (int i = 0; i < 12; i++)
{
    arrList.Add(i);
}

for (int i = 0; i < 5; i++)
{
    arrList.Remove();
}


Console.WriteLine($"C => {arrList.Count}");
Console.WriteLine($"L => {arrList.Length}");

Console.ReadKey();