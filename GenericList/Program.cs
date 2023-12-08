IList<int> intList = new List<int>();
intList.Add(10);
intList.Add(20);
intList.Add(30);
intList.Add(40);

IList<string> strList = new List<string>();
strList.Add("one");
strList.Add("two");
strList.Add("three");
strList.Add("four");
strList.Add("four");
strList.Add(null);
strList.Add(null);

IList<int> intList1 = new List<int>();
intList1.Add(10);
intList1.Add(20);
intList1.Add(30);
intList1.Add(40);

List<int> intList2 = new List<int>();
intList2.AddRange(intList1);

foreach (var el in intList)
    Console.WriteLine(el);


Console.WriteLine("**********************");
intList.Insert(1, 11);// inserts 11 at 1st index


Console.WriteLine("-------------------------------");
intList.Remove(10); // removes the 10 from a list
intList.RemoveAt(2); //removes the 3rd element (index starts from 0)

Console.WriteLine("/////////////////////////");
List<int> truetList = new List<int>() { 10, 20, 30, 40 };

bool res = truetList.TrueForAll(el => el % 2 == 0);// returns true