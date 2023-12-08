using System.Collections;

ArrayList arryList1 = new ArrayList();
arryList1.Add(1);
arryList1.Add("Two");
arryList1.Add(3);
arryList1.Add(4.5);

ArrayList arryList2 = new ArrayList();
arryList2.Add(100);
arryList2.Add(200);

//adding entire arryList2 into arryList1
arryList1.AddRange(arryList2);


//use var keyword
var firstElement = arryList1[0]; //returns 1

//ForEach
Console.WriteLine("ForEach:");
foreach (var val in arryList1)
    Console.WriteLine(val);

//Or
Console.WriteLine("For:");
for (int i = 0; i < arryList1.Count; i++)
    Console.WriteLine(arryList1[i]);

//Insert Data
arryList1.Insert(1, "Second Item");
arryList1.Insert(2, 100);


//InsertData from specific Index
arryList2.InsertRange(2, arryList1);

// //Removes 1 from ArrayList
arryList1.Remove(100);

//Removes the first index from an ArrayList
arryList1.RemoveAt(1);

//Removes two elements starting from 1st item (0 index)
arryList1.RemoveRange(0, 2);


//Sort by Ascending
arryList1.Sort();

//Sort by Descending
arryList1.Reverse();

//Check 100 is exist?
Console.WriteLine(arryList1.Contains(100));