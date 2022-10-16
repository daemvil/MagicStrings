Console.WriteLine("Введите количество строк массива: ");
int strCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное количество символов строки в массиве: ");
int maxLength = Convert.ToInt32(Console.ReadLine());
// метод, формирующий исходный массив строк
string[] GetArray(int m, int n)
{
	var rnd = new Random();
	string[] result = new string[n];
	int stringlen = rnd.Next(1, m);
	char randChar;
	for (int k = 0; k < n; k++)
	{
		string str = ""; stringlen = rnd.Next(1, m);
		for (int i = 0; i < stringlen + 1; i++)
		{
			randChar = Convert.ToChar(rnd.Next(26) + 65);
			str = str + randChar;
		}
		result[k] = str;
	}
	return result;
}
string[] matrix = GetArray(maxLength, strCount);
Console.WriteLine("Исходный массив: ");
Console.WriteLine(String.Join(",", matrix));
string[] resMatrix = new string[strCount];
for (int i = 0; i < strCount; i++)
{
	if (matrix[i].Length <= 3)
	{
		resMatrix[i] = matrix[i];
	}
}
Console.WriteLine("Строки с количеством символов не больше 3: ");
var result = resMatrix.Where(x => !string.IsNullOrWhiteSpace(x));
Console.WriteLine(String.Join(",", result));
