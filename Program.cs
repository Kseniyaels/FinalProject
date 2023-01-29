string[]array = {"Hello", "2", "world", ":-)"};
int finalArraySize = 0;
int finalArrayIndex = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) finalArraySize++;

string[] finalArray = new string[finalArraySize];

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) finalArray[finalArrayIndex++] = array[i];

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
Console.WriteLine(array[i] + ((i != array.Length-1)? ", ": ""));
Console.WriteLine();

Console.WriteLine("Измененный массив: ");
for (int i = 0; i < finalArray.Length; i++)
Console.WriteLine(finalArray[i] + ((i != finalArray.Length-1)? ", ": ""));