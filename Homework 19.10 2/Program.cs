//Задание 1

//int[] A = new int[5];
//double[,] B = new double[3, 4];
//Random random = new Random();

//for (int i = 0; i < A.Length; i++)
//{
//    Console.Write("A[" + i + "] = ");
//    A[i] = Convert.ToInt32(Console.ReadLine());
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        B[i, j] = random.Next(-10, 11);
//    }
//}

//Console.WriteLine("Массив A:");
//foreach (int x in A)
//    Console.Write(x + " ");

//Console.WriteLine("\nМатрица B:");

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//        Console.Write(B[i, j] + "\t");

//    Console.WriteLine();
//}

//double max = A[0], min = A[0];
//double sum = 0, product = 1;
//int evenSum = 0;
//double oddColumnsSum = 0;

//foreach (int x in A)
//{
//    if (x > max) max = x;
//    if (x < min) min = x;

//    sum += x;
//    product *= x;

//    if (x % 2 == 0)
//        evenSum += x;
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        double x = B[i, j];

//        if (x > max) max = x;
//        if (x < min) min = x;

//        sum += x;
//        product *= x;

//        if (j % 2 == 0)
//            oddColumnsSum += x;
//    }
//}

//Console.WriteLine("Максимум: " + max);
//Console.WriteLine("Минимум: " + min);
//Console.WriteLine("Сумма всех элементов: " + sum);
//Console.WriteLine("Произведение всех элементов: " + product);
//Console.WriteLine("Сумма четных элементов A: " + evenSum);
//Console.WriteLine("Сумма нечетных столбцов B: " + oddColumnsSum);

//Задание 2

//int[,] A = new int[5, 5];
//Random random = new Random();

//int min = 101, max = -101;
//int minIndex = 0, maxIndex = 0;

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        A[i, j] = random.Next(-100, 101);
//        Console.Write(A[i, j] + "\t");

//        int index = i * 5 + j;

//        if (A[i, j] < min)
//        {
//            min = A[i, j];
//            minIndex = index;
//        }

//        if (A[i, j] > max)
//        {
//            max = A[i, j];
//            maxIndex = index;
//        }
//    }

//    Console.WriteLine();
//}

//int start = Math.Min(minIndex, maxIndex);
//int end = Math.Max(minIndex, maxIndex);
//int sum = 0;

//for (int k = start + 1; k < end; k++)
//{
//    sum += A[k / 5, k % 5];
//}

//Console.WriteLine("Минимум: " + min);
//Console.WriteLine("Максимум: " + max);
//Console.WriteLine("Сумма между ними: " + sum);

//Задание 3

//Console.Write("Введите текст: ");
//string text = Console.ReadLine();

//Console.Write("Введите ключ: ");
//int key = Convert.ToInt32(Console.ReadLine());

//string encrypted = "";
//string decrypted = "";

//foreach (char c in text)
//{
//    if (c >= 'a' && c <= 'z')
//        encrypted += (char)('a' + (c - 'a' + key % 26 + 26) % 26);
//    else if (c >= 'A' && c <= 'Z')
//        encrypted += (char)('A' + (c - 'A' + key % 26 + 26) % 26);
//    else
//        encrypted += c;
//}

//foreach (char c in encrypted)
//{
//    if (c >= 'a' && c <= 'z')
//        decrypted += (char)('a' + (c - 'a' - key % 26 + 26) % 26);
//    else if (c >= 'A' && c <= 'Z')
//        decrypted += (char)('A' + (c - 'A' - key % 26 + 26) % 26);
//    else
//        decrypted += c;
//}

//Console.WriteLine("Зашифрованный текст: " + encrypted);
//Console.WriteLine("Расшифрованный текст: " + decrypted);

//Задание 4

//int[,] A = new int[2, 2];
//int[,] B = new int[2, 2];

//Console.WriteLine("Введите матрицу A:");
//for (int i = 0; i < 2; i++)
//    for (int j = 0; j < 2; j++)
//        A[i, j] = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите матрицу B:");
//for (int i = 0; i < 2; i++)
//    for (int j = 0; j < 2; j++)
//        B[i, j] = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите число: ");
//int k = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Умножение A на число:");
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//        Console.Write(A[i, j] * k + "\t");
//    Console.WriteLine();
//}

//Console.WriteLine("Сложение матриц:");
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//        Console.Write((A[i, j] + B[i, j]) + "\t");
//    Console.WriteLine();
//}

//Console.WriteLine("Умножение матриц:");
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        int result = 0;

//        for (int m = 0; m < 2; m++)
//            result += A[i, m] * B[m, j];

//        Console.Write(result + "\t");
//    }

//    Console.WriteLine();
//}

//Задание 5

//Console.Write("Введите выражение: ");
//string expression = Console.ReadLine();

//string[] numbers = expression.Replace("-", "+-").Split('+');

//int result = 0;

//foreach (string number in numbers)
//{
//    if (number.Trim() != "")
//        result += Convert.ToInt32(number.Trim());
//}

//Console.WriteLine("Результат: " + result);

//Задание 6

//Console.Write("Введите текст: ");
//string text = Console.ReadLine();

//bool newSentence = true;
//string result = "";

//foreach (char c in text)
//{
//    if (newSentence && char.IsLetter(c))
//    {
//        result += char.ToUpper(c);
//        newSentence = false;
//    }
//    else
//    {
//        result += c;
//    }

//    if (c == '.' || c == '!' || c == '?')
//        newSentence = true;
//}

//Console.WriteLine(result);

//Задание 7

//Console.Write("Введите текст: ");
//string text = Console.ReadLine();

//Console.Write("Введите запрещенное слово: ");
//string word = Console.ReadLine();

//string[] words = text.Split(' ');
//int count = 0;

//for (int i = 0; i < words.Length; i++)
//{
//    string clean = words[i].Trim('.', ',', '!', '?', ':', ';', '"', '\'');

//    if (clean.Equals(word, StringComparison.OrdinalIgnoreCase))
//    {
//        int start = words[i].IndexOf(clean);
//        words[i] = words[i].Remove(start, clean.Length)
//            .Insert(start, new string('*', clean.Length));

//        count++;
//    }
//}

//Console.WriteLine(string.Join(" ", words));
//Console.WriteLine("Количество замен: " + count);

//Задание 8

//Console.Write("Введите текст: ");
//string text = Console.ReadLine();

//Console.Write("Введите ключ сдвига: ");
//int key = Convert.ToInt32(Console.ReadLine());

//string result = "";

//foreach (char c in text)
//{
//    if (c >= 'a' && c <= 'z')
//    {
//        result += (char)('a' + (c - 'a' + key % 26 + 26) % 26);
//    }
//    else if (c >= 'A' && c <= 'Z')
//    {
//        result += (char)('A' + (c - 'A' + key % 26 + 26) % 26);
//    }
//    else
//    {
//        result += c;
//    }
//}

//Console.WriteLine("Зашифрованный текст: " + result);

//Задание 9


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число для умножения: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] A = new int[rows, cols];
Random random = new Random();

Console.WriteLine("Результат:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        A[i, j] = random.Next(1, 11);
        A[i, j] = A[i, j] * k;

        Console.Write(A[i, j] + "\t");
    }

    Console.WriteLine();
}
