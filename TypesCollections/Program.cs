using System.Collections;
//Generic List


List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

numbers.Remove(5);

foreach ( var Number in numbers)
{ 
    Console.WriteLine(Number);
}


Console.WriteLine("---HashTable---");
//Hashtable

Hashtable Num =  new Hashtable();
Num.Add(1, "1");
Num.Add(2, "2");
Num.Add(3, "3");
Num.Add(4, "4");

foreach ( var Number in Num.Values)
{ 
    Console.WriteLine(Number);
}


Console.WriteLine("---Dictionary---");
//Dictionary

Dictionary<int, string> number = new Dictionary<int, string>();
number.Add(11, "1");
number.Add(22, "2");
number.Add(32, "3");
number.Add(44, "4");
foreach ( var Number in number.Values)
{ 
    Console.WriteLine(Number);
}


//Colas 
Console.WriteLine("---Queue---");

Queue<int> Numbers  = new Queue<int>();
Numbers.Enqueue(1);
Numbers.Enqueue(12);
Numbers.Enqueue(123);
Numbers.Enqueue(1234);
Numbers.Dequeue();

foreach (var Number in Numbers)
{
    Console.WriteLine(Number);

}


//Pilas
Console.WriteLine ("---Stack---");

Stack<int> nums = new Stack<int>();
nums.Push(7);
nums.Push(5);
nums.Push(10);
nums.Push(2);

int last = nums.Pop();

foreach (var Numero in nums)
{
    Console.WriteLine(Numero);
}

