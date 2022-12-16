// Задача 34.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int  i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}

int EvenNum(int[] array)
{
    int sum = 0;

    for(int i = 0;i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            sum+=1;
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = EvenNum(myArray);
Console.WriteLine(result); 

// Задача 36.

// Часть кода из первой задачи

int[] CreateRandomArray1(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

int UnEvenSum(int[] array)
{
    int sum = 0;

    for(int i = 0;i < array.Length; i++)
    {
        if(i % 2 != 0)
            sum+= array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int length1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray1 = CreateRandomArray1(length1, min, max);
ShowArray(myArray1);

int result1 = UnEvenSum(myArray1);
Console.Write(result1); 

// Задача 38.

double[] CreateRandomArray2(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    double[] array1 = new double[size];
    double[] arrayresult = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array1[i] = new Random().NextDouble();
        arrayresult[i] = array[i] + array1[i];
    }
    
    return arrayresult;
}

double ComparisonNum(double[] array)
{
    for(int i = 0;i < array.Length - 1; i++)
    {
        double min = 0;
        double max = 0;

        if(array[i] > array[i + 1])
            max = array[i];
        if(array[i] < array[i + 1]) 
            min = array[i];   
    }
    double sum = max - min;
    return sum;
}

void ShowArray1(double[] array)
{
    for(int  i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}

Console.Write("Input a number of elements: ");
int length2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max1 = Convert.ToInt32(Console.ReadLine());

double[] myArray2 = CreateRandomArray2(length2, min1, max1);
ShowArray1(myArray2);

double result2 = ComparisonNum(myArray2);
Console.Write(result2); 