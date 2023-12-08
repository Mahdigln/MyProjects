using System.Collections;

SortedList sortedList1 = new SortedList();
sortedList1.Add(3, "Three");
sortedList1.Add(4, "Four");
sortedList1.Add(1, "One");
sortedList1.Add(5, "Five");
sortedList1.Add(2, "Two");

SortedList sortedList2 = new SortedList();
sortedList2.Add("one", 1);
sortedList2.Add("two", 2);
sortedList2.Add("three", 3);
sortedList2.Add("four", 4);

SortedList sortedList3 = new SortedList();
sortedList3.Add(1.5, 100);
sortedList3.Add(3.5, 200);
sortedList3.Add(2.4, 300);
sortedList3.Add(2.3, null);
sortedList3.Add(1.1, null);

for (int i = 0; i < sortedList2.Count; i++)
{
    Console.WriteLine("key: {0}, value: {1}",
        sortedList2.GetKey(i), sortedList2.GetByIndex(i));
}