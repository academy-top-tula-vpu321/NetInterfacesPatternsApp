int size = 10;

int[] array = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++)
    array[i] = random.Next(20);

foreach (var item in array)
    Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine($"Length = {array.Length}");
Console.WriteLine($"{Array.Exists(array, (item) => item < 0)}");
Console.WriteLine($"{Array.Find(array, (item) => item % 2 == 0)}");
Console.WriteLine($"{Array.FindLast(array, (item) => item % 2 == 0)}");
Console.WriteLine($"{Array.FindIndex(array, (item) => item % 2 == 0)}");
Console.WriteLine($"{Array.FindLastIndex(array, (item) => item % 2 == 0)}");

var results = Array.FindAll(array, (item) => item % 2 == 0);
foreach(var item in results)
    Console.Write($"{item} ");
Console.WriteLine();

Console.WriteLine($"{Array.IndexOf(array, 10)}");
Console.WriteLine($"{Array.LastIndexOf(array, 10)}");
Array.Reverse(array);
Array.Sort(array);
Array.BinarySearch(array, 10);

size = 20;
Array.Resize(ref array, size);

Array.Fill(array, 1);
Array.Clear(array);


int[] arrCopy = new int[size];
Array.Copy(array, arrCopy, array.Length);
foreach (var item in arrCopy)
    Console.Write($"{item} ");
Console.WriteLine();
