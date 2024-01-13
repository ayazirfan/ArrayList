using System.Collections;

ArrayList list = new ArrayList ();
// list.Add("Ayşe");
// list.Add(2);
// list.Add(true);
// list.Add('A');

// //içerisinde verilere erişim
// System.Console.WriteLine(list[1]);

// foreach (var item in list)
// {
//     System.Console.WriteLine(item);
// }

//Addrange
System.Console.WriteLine("*******Add Renge******");
List<int> sayilar =new List<int>(){1,8,3,7,9,92,5};
list.AddRange(sayilar);

foreach (var item in list)
{
    System.Console.WriteLine(item);
}
//sort
System.Console.WriteLine("**** Sort****");
list.Sort();

foreach (var item in list)
{
    System.Console.WriteLine(item);
}

// Binary Search
System.Console.WriteLine("*****Binary Serach*****");
System.Console.WriteLine(list.BinarySearch(9));
// Reverse 
System.Console.WriteLine("******Reverse******");
list.Reverse();
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
// Clear
System.Console.WriteLine("*****Clear*****");
list.Clear();
foreach (var item in list)
{
    System.Console.WriteLine(item);
}