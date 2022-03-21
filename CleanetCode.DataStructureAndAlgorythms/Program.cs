// See https://aka.ms/new-console-template for more information

using CleanetCode.DataStructureAndAlgorythms;

Console.WriteLine("Hello, World!");


List<int> listOfNumbers = new List<int> { 1, 2, 3, 4 };
listOfNumbers.Add(10);
listOfNumbers.Prepend(10);
listOfNumbers.Append(10);
listOfNumbers.Insert(3, 10);
listOfNumbers.Remove(2);
listOfNumbers.Sort();

Queue<int> queueOfNumbers = new Queue<int>();
queueOfNumbers.Enqueue(1);
queueOfNumbers.Enqueue(2);
queueOfNumbers.Enqueue(3);
queueOfNumbers.Enqueue(4);
queueOfNumbers.Dequeue();
queueOfNumbers.Dequeue();

Stack<int> stackOfNumbers = new Stack<int>();
stackOfNumbers.Push(1);
stackOfNumbers.Push(2);
stackOfNumbers.Push(3);
stackOfNumbers.Push(4);
stackOfNumbers.Pop();
stackOfNumbers.Pop();

HashSet<int> setOfNumbers = new HashSet<int> { 1, 2, 4, 5, 5 };
setOfNumbers.Add(2);
setOfNumbers.Add(10);
setOfNumbers.Add(22);
setOfNumbers.Remove(24);
setOfNumbers.Remove(22);

Dictionary<int, string> map = new Dictionary<int, string>
{
    { 1, "test" },
    { 2, "test1" },
    { 3, "test2" },
    { 4, "test3" },
    { 5, "test4" },
};

map.Add(13, "fdsfljsd");
map.Remove(3);

string value = map[13];


int[] numbers = { 3, 4, 8, 7, 6, 2, 1, 5 };

int[] orderedNumbers = SortingModule.QuickSort(numbers);

foreach (var number in orderedNumbers)
{
    Console.Write(number);
}